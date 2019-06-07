#include <string>
#include <iostream>
#include <windows.h> 
#include <stdio.h>
#pragma warning( disable : 4800 ) // stupid warning about bool
#define BUFSIZE 4096
HANDLE g_hChildStd_OUT_Rd = NULL;
HANDLE g_hChildStd_OUT_Wr = NULL;
HANDLE g_hChildStd_ERR_Rd = NULL;
HANDLE g_hChildStd_ERR_Wr = NULL;

PROCESS_INFORMATION CreateChildProcess(void);
void ReadFromPipe(PROCESS_INFORMATION);

int main(int argc, char *argv[]) {
	SECURITY_ATTRIBUTES sa;
	printf("\n->Start of parent execution.\n");
	// Set the bInheritHandle flag so pipe handles are inherited. 
	sa.nLength = sizeof(SECURITY_ATTRIBUTES);
	sa.bInheritHandle = TRUE;
	sa.lpSecurityDescriptor = NULL;
	// Create a pipe for the child process's STDERR. 
	if (!CreatePipe(&g_hChildStd_ERR_Rd, &g_hChildStd_ERR_Wr, &sa, 0)) {
		exit(1);
	}
	// Ensure the read handle to the pipe for STDERR is not inherited.
	if (!SetHandleInformation(g_hChildStd_ERR_Rd, HANDLE_FLAG_INHERIT, 0)) {
		exit(1);
	}
	// Create a pipe for the child process's STDOUT. 
	if (!CreatePipe(&g_hChildStd_OUT_Rd, &g_hChildStd_OUT_Wr, &sa, 0)) {
		exit(1);
	}
	// Ensure the read handle to the pipe for STDOUT is not inherited
	if (!SetHandleInformation(g_hChildStd_OUT_Rd, HANDLE_FLAG_INHERIT, 0)) {
		exit(1);
	}
	// Create the child process. 
	PROCESS_INFORMATION piProcInfo = CreateChildProcess();

	// Read from pipe that is the standard output for child process. 
	printf("\n->Contents of child process STDOUT:\n\n", argv[1]);
	ReadFromPipe(piProcInfo);

	printf("\n->End of parent execution.\n");

	// The remaining open handles are cleaned up when this process terminates. 
	// To avoid resource leaks in a larger application, 
	//   close handles explicitly.
	return 0;
}

// Create a child process that uses the previously created pipes
//  for STDERR and STDOUT.
PROCESS_INFORMATION CreateChildProcess() {
	// Set the text I want to run
	char szCmdline[] = "test --log_level=all --report_level=detailed";
	PROCESS_INFORMATION piProcInfo;
	STARTUPINFO siStartInfo;
	bool bSuccess = FALSE;

	// Set up members of the PROCESS_INFORMATION structure. 
	ZeroMemory(&piProcInfo, sizeof(PROCESS_INFORMATION));

	// Set up members of the STARTUPINFO structure. 
	// This structure specifies the STDERR and STDOUT handles for redirection.
	ZeroMemory(&siStartInfo, sizeof(STARTUPINFO));
	siStartInfo.cb = sizeof(STARTUPINFO);
	siStartInfo.hStdError = g_hChildStd_ERR_Wr;
	siStartInfo.hStdOutput = g_hChildStd_OUT_Wr;
	siStartInfo.dwFlags |= STARTF_USESTDHANDLES;

	// Create the child process. 
	bSuccess = CreateProcess(NULL,
		szCmdline,     // command line 
		NULL,          // process security attributes 
		NULL,          // primary thread security attributes 
		TRUE,          // handles are inherited 
		0,             // creation flags 
		NULL,          // use parent's environment 
		NULL,          // use parent's current directory 
		&siStartInfo,  // STARTUPINFO pointer 
		&piProcInfo);  // receives PROCESS_INFORMATION
	CloseHandle(g_hChildStd_ERR_Wr);
	CloseHandle(g_hChildStd_OUT_Wr);
	// If an error occurs, exit the application. 
	if (!bSuccess) {
		exit(1);
	}
	return piProcInfo;
}

// Read output from the child process's pipe for STDOUT
// and write to the parent process's pipe for STDOUT. 
// Stop when there is no more data. 
void ReadFromPipe(PROCESS_INFORMATION piProcInfo) {
	DWORD dwRead;
	CHAR chBuf[BUFSIZE];
	bool bSuccess = FALSE;
	std::string out = "", err = "";
	for (;;) {
		bSuccess = ReadFile(g_hChildStd_OUT_Rd, chBuf, BUFSIZE, &dwRead, NULL);
		if (!bSuccess || dwRead == 0) break;

		std::string s(chBuf, dwRead);
		out += s;
	}
	dwRead = 0;
	for (;;) {
		bSuccess = ReadFile(g_hChildStd_ERR_Rd, chBuf, BUFSIZE, &dwRead, NULL);
		if (!bSuccess || dwRead == 0) break;

		std::string s(chBuf, dwRead);
		err += s;

	}
	std::cout << "stdout:" << out << std::endl;
	std::cout << "stderr:" << err << std::endl;
}