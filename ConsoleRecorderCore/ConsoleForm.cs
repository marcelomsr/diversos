﻿using System;
using System.Diagnostics;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Threading;
using System.Windows.Forms;

namespace ConsoleRecorderCore
{
    public partial class ConsoleForm : Form
    {
        RecorderInteraction _recorderInteraction;

        public ConsoleForm()
        {
            InitializeComponent();            

            popular_lista_gravadores();
            popular_combo_comandos();
            cbo_comandos.SelectedIndex = 0;
        }

        private void popular_lista_gravadores()
        {
            lst_gravadores.Items.Add(new Recorder("localhost:8888", "localhost", 8888));
            lst_gravadores.Items.Add(new Recorder("Campinas", "10.0.72.194", 8884));
            lst_gravadores.Items.Add(new Recorder("HA", "10.0.72.194", 8882));
            lst_gravadores.Items.Add(new Recorder("Agente Virtual (ANTIBES)", "10.0.72.194", 8883));
            lst_gravadores.Items.Add(new Recorder("Paraguai (BEDER)", "10.0.72.194", 8888));

            lst_gravadores.Items.Add(new Recorder("Centronorte", "10.0.72.195", 8880));
            lst_gravadores.Items.Add(new Recorder("Argentina", "10.0.72.195", 8882));
            lst_gravadores.Items.Add(new Recorder("Nordeste", "10.0.72.195", 8883));
            lst_gravadores.Items.Add(new Recorder("São Paulo Interior", "10.0.72.195", 8884));
            lst_gravadores.Items.Add(new Recorder("Rio de Janeiro", "10.0.72.195", 8885));
            lst_gravadores.Items.Add(new Recorder("Sul", "10.0.72.195", 8886));
            lst_gravadores.Items.Add(new Recorder("São Paulo II", "10.0.72.195", 8887));
            lst_gravadores.Items.Add(new Recorder("Minas", "10.0.72.195", 8888));

            lst_gravadores.DisplayMember = "Name";
        }

        private void popular_combo_comandos()
        {
            foreach (RecorderInteraction.Command item in Enum.GetValues(typeof(RecorderInteraction.Command)))
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
            string recording = _recorderInteraction.GetRecording(Convert.ToInt32(txt_sqc_gravacao.Text));

            byte[] data = Convert.FromBase64String(recording);
            File.WriteAllBytes(String.Format(@"C:\Users\marcelosr\Desktop\{0}.wav", txt_sqc_gravacao.Text), data);
        }

        private void cbo_comandos_SelectedValueChanged(object sender, EventArgs e)
        {
            panel.Controls.Clear();

            switch (cbo_comandos.SelectedItem)
            {
                case RecorderInteraction.Command.COMANDO_INICIAR_GRAVACAO_CHAMADA:
                    {
                        UserControlGravar user_control = new UserControlGravar();
                        panel.Controls.Add(user_control);
                    }
                    break;

                case RecorderInteraction.Command.COMANDO_PARAR_GRAVACAO_CHAMADA:
                    {
                        UserControlPararGravar user_control = new UserControlPararGravar();
                        panel.Controls.Add(user_control);
                    }
                    break;

                case RecorderInteraction.Command.COMANDO_OBTER_GRAVACAO:
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
            var recorder = (Recorder)lst_gravadores.SelectedItem;

            _recorderInteraction = new RecorderInteraction(recorder);
            _recorderInteraction.CommandSended += ao_receber_comando_enviado;
        }

        private void btn_enviar_comando_Click(object sender, EventArgs e)
        {
            switch (cbo_comandos.SelectedItem)
            {
                case RecorderInteraction.Command.COMANDO_INICIAR_GRAVACAO_CHAMADA:
                    {
                        TextBox txt_chamada_id = (TextBox)panel.Controls[0].Controls.Find("txt_chamada_id", false)[0];
                        int chamada_id = Convert.ToInt32(txt_chamada_id.Text);

                        TextBox txt_nmr_dispositivo = (TextBox)panel.Controls[0].Controls.Find("txt_nmr_dispositivo", false)[0];
                        string device = txt_nmr_dispositivo.Text;

                        // FIXME: Colocar a quota como parâmetro, quota é o cdg_identificacao da tabela cct.cct_grv_gravador_quota.
                        // Que é o mesmo de cdg_interface_cti, ou seja, é a identificação de qual interface cti possui a cota.
                        int quota = 54;

                        AppendTextConsole(_recorderInteraction.Record(chamada_id, device, quota), true);
                        AppendTextConsole(_recorderInteraction.GetResponse());
                    }

                    break;

                case RecorderInteraction.Command.COMANDO_PARAR_GRAVACAO_CHAMADA:
                    {
                        TextBox txt_chamada_id = (TextBox)panel.Controls[0].Controls.Find("txt_gravacao_id", false)[0];
                        int gravacao_id = Convert.ToInt32(txt_chamada_id.Text);                        
                        AppendTextConsole(_recorderInteraction.StopRecording(gravacao_id), true);
                        AppendTextConsole(_recorderInteraction.GetResponse());
                    }

                    break;

                case RecorderInteraction.Command.COMANDO_OBTER_GRAVACAO:
                    {
                        TextBox txt_sqc_gravacao = (TextBox)panel.Controls[0].Controls.Find("txt_sqc_gravacao", false)[0];
                        string gravacao = _recorderInteraction.GetRecording(Convert.ToInt32(txt_sqc_gravacao.Text));

                        AppendTextConsole(_recorderInteraction.GetResponse());
                        AppendTextConsole(gravacao, true);                        
                    }

                    break;

                case RecorderInteraction.Command.COMANDO_OBTER_VERSAO:
                    {                        
                        string versao = _recorderInteraction.GetVersion();
                        AppendTextConsole(_recorderInteraction.GetResponse());
                        AppendTextConsole(versao, true);
                    }

                    break;

                default:
                    AppendTextConsole("Comando não suportado.");
                    break;
            }
        }

        private void AppendTextConsole(string logMessage, bool skipTwoLines = false)
        {
            rct_retorno.AppendText("[" + DateTime.Now.ToString() + "]");
            rct_retorno.AppendText(" ");
            rct_retorno.AppendText(logMessage);
            rct_retorno.AppendText("\n");

            if (skipTwoLines)
                rct_retorno.AppendText("\n");

            rct_retorno.ScrollToCaret();
        }

        private void ao_receber_comando_enviado(string commnad)
        {
            AppendTextConsole(commnad);
        }
    }
}
