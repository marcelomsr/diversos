using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//using System.Windows.Forms;

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

		//public static void PrintScreen(Screen[] screens, string fileNameOutput, ImageFormat imageFormat)
		//{
		//	int screenLeft = 0, screenWidth = 0, screenTop = 0, screenHeight = 0;

		//	foreach (Screen screen in screens)
		//	{
		//		screenWidth += screen.Bounds.Width;

		//		if (screen.Bounds.Left < screenLeft)
		//			screenLeft = screen.Bounds.Left;

		//		if (screen.Bounds.Top < screenTop)
		//			screenTop = screen.Bounds.Top;

		//		if (screen.Bounds.Height > screenHeight)
		//			screenHeight = screen.Bounds.Height;
		//	}

		//	using (Bitmap bpm = new Bitmap(screenWidth, screenHeight))
		//	{
		//		Graphics graphics = Graphics.FromImage(bpm as Image);
		//		graphics.CopyFromScreen(screenLeft, screenTop, 0, 0, bpm.Size);
		//		bpm.Save(@fileNameOutput, imageFormat);
		//	}
		//}

		public static void GetHtml(Uri site, ref string html)
		{
			WebClient wc = new WebClient();
			wc.Encoding = Encoding.UTF8;
			wc.Headers.Add("User-Agent: Other");
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

		#region Tested

		public static bool TimeOut(Action action, int millisecondsTimeOut)
		{
			var tokenSource = new CancellationTokenSource();
			CancellationToken token = tokenSource.Token;

			var task = Task.Factory.StartNew(action, token);

			// If time expired, returns true
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

		public static List<int> Lotofacil(int qtdNumbers = 15)
		{
			if (qtdNumbers < 15 || qtdNumbers > 18)
				throw new ArgumentOutOfRangeException("qtdNumbers", "Valor fora do range permitido. 15-18");

			List<int> numeros_sorteados = new List<int>();

			Random random = new Random();

			while (numeros_sorteados.Count < qtdNumbers)
			{
				int numero_sorteado = random.Next(1, 25);

				if (!numeros_sorteados.Contains(numero_sorteado))
					numeros_sorteados.Add(numero_sorteado);
			}

			numeros_sorteados.Sort();

			return numeros_sorteados;
		}

		public static void MeasurePerformance(Action action, ref long elapsedMilliseconds, ref long elapsedTicks)
        {
			Stopwatch stopwatch = new Stopwatch();			
			stopwatch.Start();

			action();
			stopwatch.Stop();

			elapsedMilliseconds = stopwatch.ElapsedMilliseconds;
			elapsedTicks = stopwatch.ElapsedTicks;
		}

		public static IList<string> SortearTabelaCampeonato(IList<string> competidores)
		{
			if (competidores.Count < 3)
				throw new ArgumentException("A lista de competidoes não pode ser menor que 3", "competidores");

			competidores.Shuffle();

			int qtd_competidores = competidores.Count;

			IList<string> competidores_1 = new List<string>();
			IList<string> competidores_2 = new List<string>();

			definir_lista_competidores(ref competidores, ref competidores_1, ref competidores_2);

			List<string> partidas_torneio = new List<string>();

			// A quantidade de rodadas do torneio é igual a quantidade de competidores no caso de quantidade de competidores ímpar
			// No caso de quantidade de competidores par, a quantidade de rodadas é a quantidade de competidores menos 1.
			int qtd_rodadas = qtd_competidores - (competidores.Contains("Folga") ? 0 : 1);

			for (int rodada = 0; rodada < qtd_rodadas; rodada++)
			{
				// A quantidade de partidas da rodada é igual a quantidade de competidores "real" dividido por 2.
				int qtd_partidas_rodada = qtd_competidores / 2;
				string[] partidas_rodada = new string[qtd_partidas_rodada];

				for (int partida = 0, competidor = 0; partida < qtd_partidas_rodada; partida++, competidor++)
				{
					// Se for uma partida válida, insere na rodada, senão, reduz o número da partida para não ignorar o último confronto da rodada.
					if (competidores_2[competidor] != "Folga" && competidores_1[competidor] != "Folga")
					{
						partidas_rodada[partida] = String.Format("Rodada {0}: {1} vs {2}", rodada + 1, competidores_1[competidor], competidores_2[competidor]);
					}
					else
					{
						partida--;
					}
				}

				// Pega os competidores que trocarão de lista.
				string competidor_lista1_para_lista2 = competidores_1[competidores_1.Count - 1];
				string competidor_lista2_para_lista1 = competidores_2[0];

				// Remove os competidores da lista.
				competidores_1.Remove(competidor_lista1_para_lista2);
				competidores_2.Remove(competidor_lista2_para_lista1);

				// Insere o competidor logo após o primeiro da lista.
				competidores_1.Insert(1, competidor_lista2_para_lista1);

				// Insere o competidor no final da lista.
				competidores_2.Add(competidor_lista1_para_lista2);

				partidas_torneio.AddRange(partidas_rodada);
			}

			return partidas_torneio;
		}

		private static void definir_lista_competidores(ref IList<string> competidores, ref IList<string> comp_1, ref IList<string> comp_2)
		{
			// Se a quantidade de competidores for ímpar, insere a folga para fazer a rodada completa.
			if (competidores.Count % 2 == 1)
				competidores.Add("Folga");

			int metade = competidores.Count / 2;

			for (int i = 0; i < competidores.Count; i++)
			{
				if (i + 1 <= metade)
					comp_1.Add(competidores[i]);
				else
					comp_2.Add(competidores[i]);
			}
		}

		public static void SetToClipboard(string text)
        {
			TextCopy.ClipboardService.SetText(text);
		}

		#endregion
	}
}
