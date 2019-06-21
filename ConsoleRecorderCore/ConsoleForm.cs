using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.IO.Compression;
using System.Runtime.InteropServices;
using System.IO.MemoryMappedFiles;
using System.Threading;

namespace ConsoleRecorderCore
{
    public partial class ConsoleForm : Form
    {
        private const int COMANDO_INICIAR_GRAVACAO_CHAMADA = 1;
        private const int COMANDO_PARAR_GRAVACAO_CHAMADA = 2;
        private const int COMANDO_OBTER_GRAVACAO = 10;
        private const int COMANDO_OBTER_VERSAO = 11;

        ConexaoGravador _conexao_gravador = new ConexaoGravador();

        public ConsoleForm()
        {
            InitializeComponent();

            _conexao_gravador.AoComandoEnviado += ao_receber_comando_enviado;

            popular_lista_gravadores();
            popular_combo_comandos();
            cbo_comandos.SelectedIndex = 0;
        }

        private void popular_lista_gravadores()
        {
            lst_gravadores.Items.Add(new Gravador("localhost:8888", "localhost", 8888));
            lst_gravadores.Items.Add(new Gravador("(DUNKIRK) (Inativo)", "10.0.35.194", 8881));
            lst_gravadores.Items.Add(new Gravador("HA", "10.0.35.194", 8882));
            lst_gravadores.Items.Add(new Gravador("Agente Virtual (ANTIBES)", "10.0.35.194", 8883));
            lst_gravadores.Items.Add(new Gravador("LGW-SIP (NANCY)", "10.0.35.194", 8886));
            lst_gravadores.Items.Add(new Gravador("Paraguai (BEDER)", "10.0.35.194", 8888));

            lst_gravadores.Items.Add(new Gravador("Centronorte", "10.0.35.195", 8880));
            lst_gravadores.Items.Add(new Gravador("Argentina", "10.0.35.195", 8882));
            lst_gravadores.Items.Add(new Gravador("Nordeste", "10.0.35.195", 8883));
            lst_gravadores.Items.Add(new Gravador("São Paulo Interior", "10.0.35.195", 8884));
            lst_gravadores.Items.Add(new Gravador("Rio de Janeiro", "10.0.35.195", 8885));
            lst_gravadores.Items.Add(new Gravador("Sul", "10.0.35.195", 8886));
            lst_gravadores.Items.Add(new Gravador("São Paulo II", "10.0.35.195", 8887));
            lst_gravadores.Items.Add(new Gravador("Minas", "10.0.35.195", 8888));

            lst_gravadores.DisplayMember = "_nome";
        }

        private void popular_combo_comandos()
        {
            foreach (InteracaoGravador.Comando item in Enum.GetValues(typeof(InteracaoGravador.Comando)))
                cbo_comandos.Items.Add(item);
        }

        private void btn_tocar_audio_Click(object sender, EventArgs e)
        {
            string diretorio_arquivo = @"C:\Users\marcelosr\Downloads\135818653.wav";

            byte[] bytes_arquivo = File.ReadAllBytes(diretorio_arquivo);
            //string gravacao = Convert.ToBase64String(bytes_arquivo);

            using (MemoryMappedFile mmf = MemoryMappedFile.CreateNew("audiomap", bytes_arquivo.Length))
            {
                bool mutexCreated;
                Mutex mutex = new Mutex(true, "audiomapmutex", out mutexCreated);

                using (MemoryMappedViewStream stream = mmf.CreateViewStream())
                {
                    BinaryWriter writer = new BinaryWriter(stream);
                    writer.Write(bytes_arquivo);
                }
                mutex.ReleaseMutex();

                string argumentos = String.Format("{0} {1}", bytes_arquivo.Length, 135818653);
                Process.Start(@"C:\Users\marcelosr\Desktop\Repo\application\bin\x64\Release\AltriumPlayer\AltriumPlayer.exe", argumentos);

                Thread.Sleep(1000);

                mutex.WaitOne();
            }
        }

        private void btn_gravar_arquivo_Click(object sender, EventArgs e)
        {
            TextBox txt_sqc_gravacao = (TextBox)panel.Controls[0].Controls.Find("txt_sqc_gravacao", false)[0];
            string gravacao = _conexao_gravador.obter_gravacao(Convert.ToInt32(txt_sqc_gravacao.Text));

            byte[] data = Convert.FromBase64String(gravacao);
            File.WriteAllBytes(String.Format(@"C:\Users\marcelosr\Desktop\{0}.wav", txt_sqc_gravacao.Text), data);
        }

        private void cbo_comandos_SelectedValueChanged(object sender, EventArgs e)
        {
            panel.Controls.Clear();

            switch (cbo_comandos.SelectedItem)
            {
                case InteracaoGravador.Comando.COMANDO_INICIAR_GRAVACAO_CHAMADA:
                    {
                        UserControlGravar user_control = new UserControlGravar();
                        panel.Controls.Add(user_control);
                    }
                    break;

                case InteracaoGravador.Comando.COMANDO_PARAR_GRAVACAO_CHAMADA:
                    {
                        UserControlPararGravar user_control = new UserControlPararGravar();
                        panel.Controls.Add(user_control);
                    }
                    break;

                case InteracaoGravador.Comando.COMANDO_OBTER_GRAVACAO:
                    {
                        UserControlObterGravacao user_control = new UserControlObterGravacao();
                        panel.Controls.Add(user_control);
                    }
                    break;

                default:
                    break;
            }
        }

        private void lst_gravadores_SelectedValueChanged(object sender, EventArgs e)
        {
            var selectedItem = (Gravador)lst_gravadores.SelectedItem;

            _conexao_gravador.definir_endereco_gravador(selectedItem._ip, selectedItem._porta);
            _conexao_gravador.conectar();
        }

        private void btn_enviar_comando_Click(object sender, EventArgs e)
        {
            switch (cbo_comandos.SelectedItem)
            {
                case InteracaoGravador.Comando.COMANDO_INICIAR_GRAVACAO_CHAMADA:
                    {
                        TextBox txt_chamada_id = (TextBox)panel.Controls[0].Controls.Find("txt_chamada_id", false)[0];
                        int chamada_id = Convert.ToInt32(txt_chamada_id.Text);

                        TextBox txt_nmr_dispositivo = (TextBox)panel.Controls[0].Controls.Find("txt_nmr_dispositivo", false)[0];
                        int nmr_ramal = Convert.ToInt32(txt_nmr_dispositivo.Text);

                        alimentar_texto_console(_conexao_gravador.gravar(chamada_id, nmr_ramal));
                        alimentar_texto_console(_conexao_gravador.obter_retorno(), true);
                    }

                    break;

                case InteracaoGravador.Comando.COMANDO_PARAR_GRAVACAO_CHAMADA:
                    {
                        TextBox txt_chamada_id = (TextBox)panel.Controls[0].Controls.Find("txt_gravacao_id", false)[0];
                        int gravacao_id = Convert.ToInt32(txt_chamada_id.Text);

                        alimentar_texto_console(_conexao_gravador.parar_gravar(gravacao_id));
                        alimentar_texto_console(_conexao_gravador.obter_retorno(), true);
                    }

                    break;

                case InteracaoGravador.Comando.COMANDO_OBTER_GRAVACAO:
                    {
                        TextBox txt_sqc_gravacao = (TextBox)panel.Controls[0].Controls.Find("txt_sqc_gravacao", false)[0];
                        string gravacao = _conexao_gravador.obter_gravacao(Convert.ToInt32(txt_sqc_gravacao.Text));

                        alimentar_texto_console(gravacao);
                        alimentar_texto_console(_conexao_gravador.obter_retorno(), true);
                    }

                    break;

                case InteracaoGravador.Comando.COMANDO_OBTER_VERSAO:
                    {
                        string versao = _conexao_gravador.obter_versao();

                        alimentar_texto_console(versao);
                    }

                    break;

                default:
                    break;
            }
        }

        private void alimentar_texto_console(string txtConsole, bool pula_duas_linhas = false)
        {
            rct_retorno.AppendText("[" + DateTime.Now.ToString() + "]");
            rct_retorno.AppendText(" ");
            rct_retorno.AppendText(txtConsole);
            rct_retorno.AppendText("\n");

            if (pula_duas_linhas)
                rct_retorno.AppendText("\n");

            rct_retorno.ScrollToCaret();
        }

        private void ao_receber_comando_enviado(string comando)
        {
            alimentar_texto_console(comando);
        }
    }

    public class CompressUtil
    {
        /// <summary> Compacta uma string </summary>
        /// <param name=”inputText”> Texto de entrada </param>
        /// <returns> Texto compactado Base64 encoded </returns>
        public static string Compress(string inputText)
        {
            return Compress(System.Text.Encoding.UTF8.GetBytes(inputText));
        }

        /// <summary> Compacta uma string </summary>
        /// <param name=”inputBytes”> Texto de entrada </param>
        /// <returns> Texto compactado Base64 encoded </returns>
        public static string Compress(byte[] inputBytes)
        {
            byte[] compressed;

            using (MemoryStream ms = new MemoryStream())
            {
                using (GZipStream zip = new GZipStream(ms, CompressionMode.Compress))
                {
                    zip.Write(inputBytes, 0, inputBytes.Length);
                    zip.Close();

                    compressed = ms.ToArray();
                }
            }

            return Convert.ToBase64String(compressed);
        }

        /// <summary> Descompacta uma string. </summary>
        /// <param name=”compressedText”> Texto compactado Base64 encoded </param>
        /// <returns> descompacta um texto </returns>
        public static string DecompressText(string compressedText)
        {
            return System.Text.Encoding.UTF8.GetString(DecompressBytes(compressedText));
        }

        /// <summary> Descompacta uma string </summary>
        /// <param name=”compressedText”> Texto compactado Base64 encoded </param>
        /// <returns> descompacta byte array </returns>
        public static byte[] DecompressBytes(string compressedText)
        {
            byte[] bytes = Convert.FromBase64String(compressedText);
            byte[] outputBytes;

            using (MemoryStream inputStream = new MemoryStream(bytes))
            {
                using (GZipStream zip = new GZipStream(inputStream, CompressionMode.Decompress))
                {
                    using (MemoryStream outputStream = new MemoryStream())
                    {
                        zip.CopyTo(outputStream);

                        outputBytes = outputStream.ToArray();
                    }
                }
            }

            return outputBytes;
        }
    }
}
