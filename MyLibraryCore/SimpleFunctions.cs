using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLibraryCore
{
	public static class SimpleFunctions
	{
		public static void Shuffle<T>(this IList<T> list)
		{
			Random rng = new Random();
			int n = list.Count;
			while (n > 1)
			{
				n--;
				int k = rng.Next(n + 1);
				T value = list[k];
				list[k] = list[n];
				list[n] = value;
			}
		}

		public static void PrintScreen(Screen[] screens, string fileNameOutput, ImageFormat imageFormat)
		{
			int screenLeft = 0, screenWidth = 0, screenTop = 0, screenHeight = 0;

			foreach (Screen screen in screens)
			{
				screenWidth += screen.Bounds.Width;

				if (screen.Bounds.Left < screenLeft)
					screenLeft = screen.Bounds.Left;

				if (screen.Bounds.Top < screenTop)
					screenTop = screen.Bounds.Top;

				if (screen.Bounds.Height > screenHeight)
					screenHeight = screen.Bounds.Height;
			}

			using (Bitmap bpm = new Bitmap(screenWidth, screenHeight))
			{
				Graphics graphics = Graphics.FromImage(bpm as Image);
				graphics.CopyFromScreen(screenLeft, screenTop, 0, 0, bpm.Size);
				bpm.Save(@fileNameOutput, imageFormat);
			}
		}

		public static void GetHtml(Uri site, ref string html)
		{
			WebClient wc = new WebClient();
			wc.Encoding = Encoding.UTF8;
			html = wc.DownloadString(site);
		}

		public static void GetHtml(String site, ref string html)
		{
			Uri uri = new Uri(site);
			GetHtml(uri, ref html);
		}

		public static void FileWriter(String path, bool append, String text)
		{
			StreamWriter wr = new StreamWriter(path, append, Encoding.UTF8);
			wr.Write(text);
			wr.Close();
		}

		///<summary>
		/// Encrypts a file using Rijndael algorithm.
		///</summary>
		///<param name="inputFile"></param>
		///<param name="outputFile"></param>
		public static void EncryptFile(string inputFile, string outputFile, string key)
		{
			UnicodeEncoding UE = new UnicodeEncoding();
			byte[] bytesKey = UE.GetBytes(key);

			string cryptFile = outputFile;
			FileStream fsCrypt = new FileStream(cryptFile, FileMode.Create);

			RijndaelManaged RMCrypto = new RijndaelManaged();

			CryptoStream cs = new CryptoStream(fsCrypt,
				RMCrypto.CreateEncryptor(bytesKey, bytesKey),
				CryptoStreamMode.Write);

			FileStream fsIn = new FileStream(inputFile, FileMode.Open);

			int data;
			while ((data = fsIn.ReadByte()) != -1)
				cs.WriteByte((byte)data);


			fsIn.Close();
			cs.Close();
			fsCrypt.Close();
		}

		///<summary>
		/// Decrypts a file using Rijndael algorithm.
		///</summary>
		///<param name="inputFile"></param>
		///<param name="outputFile"></param>
		public static void DecryptFile(string inputFile, string outputFile, string key)
		{
			UnicodeEncoding UE = new UnicodeEncoding();
			byte[] bytesKey = UE.GetBytes(key);

			FileStream fsCrypt = new FileStream(inputFile, FileMode.Open);

			RijndaelManaged RMCrypto = new RijndaelManaged();

			CryptoStream cs = new CryptoStream(fsCrypt,
				RMCrypto.CreateDecryptor(bytesKey, bytesKey),
				CryptoStreamMode.Read);

			FileStream fsOut = new FileStream(outputFile, FileMode.Create);

			int data;
			while ((data = cs.ReadByte()) != -1)
				fsOut.WriteByte((byte)data);

			fsOut.Close();
			cs.Close();
			fsCrypt.Close();
		}

		public static void EncryptString(string plainText, string passwordHash, string key, string iv, ref string cipherText)
		{
			byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);

			byte[] keyBytes = new Rfc2898DeriveBytes(passwordHash, Encoding.ASCII.GetBytes(key)).GetBytes(256 / 8);
			var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.Zeros };
			var encryptor = symmetricKey.CreateEncryptor(keyBytes, Encoding.ASCII.GetBytes(iv));

			byte[] cipherTextBytes;

			using (var memoryStream = new MemoryStream())
			{
				using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
				{
					cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
					cryptoStream.FlushFinalBlock();
					cipherTextBytes = memoryStream.ToArray();
					cryptoStream.Close();
				}
				memoryStream.Close();
			}

			cipherText = Convert.ToBase64String(cipherTextBytes);
		}

		public static void DecryptString(string cipherText, string passwordHash, string key, string iv, ref string plainText)
		{
			byte[] cipherTextBytes = Convert.FromBase64String(cipherText);
			byte[] keyBytes = new Rfc2898DeriveBytes(passwordHash, Encoding.ASCII.GetBytes(key)).GetBytes(256 / 8);
			var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.None };

			var decryptor = symmetricKey.CreateDecryptor(keyBytes, Encoding.ASCII.GetBytes(iv));
			var memoryStream = new MemoryStream(cipherTextBytes);
			var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
			byte[] plainTextBytes = new byte[cipherTextBytes.Length];

			int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
			memoryStream.Close();
			cryptoStream.Close();
			plainText = Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount).TrimEnd("\0".ToCharArray());
		}

		public static string GetEnumDescription<T>(T value)
		{
			Type type = typeof(T);
			var name = Enum.GetNames(type).Where(f => f.Equals(value.ToString(), StringComparison.CurrentCultureIgnoreCase)).Select(d => d).FirstOrDefault();

			if (name == null)
				return string.Empty;

			var field = type.GetField(name);
			var customAttribute = field.GetCustomAttributes(typeof(DescriptionAttribute), false);
			return customAttribute.Length > 0 ? ((DescriptionAttribute)customAttribute[0]).Description : name;
		}

		public static bool TimeOut(Action action, int millisecondsTimeOut)
		{
			var tokenSource = new CancellationTokenSource();
			CancellationToken token = tokenSource.Token;

			var task = Task.Factory.StartNew(action, token);

			// Estourou o tempo
			if (!task.Wait(millisecondsTimeOut, token))
				return true;

			return false;
		}

		public static long[] Fibonacci(int n)
		{
			if (n <= 0)
				return Array.Empty<long>();

			if (n == 1)
				return new long[] { 0 };

			long a = 0;
			long b = 1;
			long temp;

			List<long> fibonacci = new List<long>();
			fibonacci.Add(a);
			fibonacci.Add(b);
			n -= fibonacci.Count;

			for (int i = 0; i < n; i++)
			{
				temp = a;
				a = b;
				b = temp + a;

				fibonacci.Add(b);
			}

			return fibonacci.ToArray();
		}
	}
}
