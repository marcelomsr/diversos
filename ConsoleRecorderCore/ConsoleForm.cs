using System;
using System.Diagnostics;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ConsoleRecorderCore
{
    public partial class ConsoleForm : Form
    {
        RecorderInteraction _recorderInteraction;

        private Thread _threadStress;
        private bool _stress = false;

        public ConsoleForm()
        {
            InitializeComponent();

            LoadListRecorders();
            LoadComboCommands();
            ValidateInteractions();
            cbo_comandos.SelectedIndex = 0;

            _threadStress = new Thread(Stress);
        }

        private void LoadListRecorders()
        {
            lst_gravadores.Items.Add(new Recorder("localhost:8889", "localhost", 8889));
            //lst_gravadores.Items.Add(new Recorder("Campinas", "10.0.72.194", 8884));
            //lst_gravadores.Items.Add(new Recorder("HA", "10.0.72.194", 8882));
            //lst_gravadores.Items.Add(new Recorder("Agente Virtual (ANTIBES)", "10.0.72.194", 8883));
            //lst_gravadores.Items.Add(new Recorder("Paraguai (BEDER)", "10.0.72.194", 8888));

            //lst_gravadores.Items.Add(new Recorder("Centronorte", "10.0.72.195", 8880));
            //lst_gravadores.Items.Add(new Recorder("Argentina", "10.0.72.195", 8882));
            //lst_gravadores.Items.Add(new Recorder("Nordeste", "10.0.72.195", 8883));
            //lst_gravadores.Items.Add(new Recorder("São Paulo Interior", "10.0.72.195", 8884));
            //lst_gravadores.Items.Add(new Recorder("Rio de Janeiro", "10.0.72.195", 8885));
            //lst_gravadores.Items.Add(new Recorder("Sul", "10.0.72.195", 8886));
            //lst_gravadores.Items.Add(new Recorder("São Paulo II", "10.0.72.195", 8887));
            //lst_gravadores.Items.Add(new Recorder("Minas", "10.0.72.195", 8888));

            lst_gravadores.DisplayMember = "Name";
        }

        private void LoadComboCommands()
        {
            foreach (RecorderInteraction.Command item in Enum.GetValues(typeof(RecorderInteraction.Command)))
                cbo_comandos.Items.Add(item);
        }

        private void btn_tocar_audio_Click(object sender, EventArgs e)
        {
            byte[] kChavePura = {
                90, 15, 226, 197, 55, 209, 65, 19, 225, 160, 212, 199, 192, 233, 164, 218, 129, 197, 69, 132, 140, 66, 129, 156, 211, 8, 9, 186, 74, 183, 24, 110 };


            byte[] iv = Encoding.ASCII.GetBytes("1427716122012020");

            string arquivo_descriptografar = @"C:\gravacoes\2020\1\22\142771615.wavc";

            byte[] cipherText2 = File.ReadAllBytes(arquivo_descriptografar);

            string audio_decrypted = AesOperation.Decrypt(cipherText2, kChavePura, iv);

            var audio_decryptedbytes = Encoding.ASCII.GetBytes(audio_decrypted);

            File.WriteAllBytes(@"C:\gravacoes\2020\1\22\142771615.wav", audio_decryptedbytes);

        }

        private void cbo_comandos_SelectedValueChanged(object sender, EventArgs e)
        {
            panel.Controls.Clear();

            switch (cbo_comandos.SelectedItem)
            {
                case RecorderInteraction.Command.INICIAR_GRAVACAO_CHAMADA:
                    {
                        UserControlGravar user_control = new UserControlGravar();
                        panel.Controls.Add(user_control);
                    }
                    break;

                //case RecorderInteraction.Command.PARAR_GRAVACAO_CHAMADA:
                //    {
                //        UserControlPararGravar user_control = new UserControlPararGravar();
                //        panel.Controls.Add(user_control);
                //    }
                //    break;

                case RecorderInteraction.Command.OBTER_GRAVACAO:
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

            ValidateInteractions();
        }

        private void btn_enviar_comando_Click(object sender, EventArgs e)
        {
            switch (cbo_comandos.SelectedItem)
            {
                case RecorderInteraction.Command.INICIAR_GRAVACAO_CHAMADA:
                    {
                        TextBox txt_chamada_id = (TextBox)panel.Controls[0].Controls.Find("txt_chamada_id", false)[0];
                        int chamada_id = Convert.ToInt32(txt_chamada_id.Text);

                        TextBox txt_nmr_dispositivo = (TextBox)panel.Controls[0].Controls.Find("txt_nmr_dispositivo", false)[0];
                        string device = txt_nmr_dispositivo.Text;

                        // FIXME: Colocar a quota como parâmetro, quota é o cdg_identificacao da tabela cct.cct_grv_gravador_quota.
                        // Que é o mesmo de cdg_interface_cti, ou seja, é a identificação de qual interface cti possui a cota.
                        int quota = -1;

                        AppendTextConsole(_recorderInteraction.Record(chamada_id, device, quota), true);
                        AppendTextConsole(_recorderInteraction.GetResponse());
                    }

                    break;

                //case RecorderInteraction.Command.PARAR_GRAVACAO_CHAMADA:
                //    {
                //        TextBox txt_chamada_id = (TextBox)panel.Controls[0].Controls.Find("txt_gravacao_id", false)[0];
                //        int gravacao_id = Convert.ToInt32(txt_chamada_id.Text);

                //        // FIXME
                //        //AppendTextConsole(_recorderInteraction.StopRecording(gravacao_id), true);
                //        //AppendTextConsole(_recorderInteraction.GetResponse());
                //    }

                //    break;

                case RecorderInteraction.Command.OBTER_GRAVACAO:
                    {
                        TextBox txt_sqc_gravacao = (TextBox)panel.Controls[0].Controls.Find("txt_sqc_gravacao", false)[0];

                        // FIXME
                        string gravacao = _recorderInteraction.GetRecording(Convert.ToInt32(txt_sqc_gravacao.Text));

                        AppendTextConsole(_recorderInteraction.GetResponse());
                        AppendTextConsole(gravacao, true);
                    }

                    break;

                case RecorderInteraction.Command.OBTER_VERSAO:
                    AppendTextConsole(_recorderInteraction.GetVersion());
                    AppendTextConsole(_recorderInteraction.GetResponse());
                    break;

                default:
                    AppendTextConsole("Comando não suportado.");
                    break;
            }
        }

        private void AppendTextConsole(string logMessage, bool skipTwoLines = false)
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)(() =>
                {
                    AppendTextConsole(logMessage, skipTwoLines);
                }));

                return;
            }

            rct_retorno.AppendText("[" + DateTime.Now.ToString() + "]");
            rct_retorno.AppendText(" ");
            rct_retorno.AppendText(logMessage);
            rct_retorno.AppendText("\n");

            if (skipTwoLines)
                rct_retorno.AppendText("\n");

            rct_retorno.ScrollToCaret();
        }

        private void ao_receber_comando_enviado(string command)
        {
            AppendTextConsole(command);
        }

        private void btn_stress_Click(object sender, EventArgs e)
        {
            if (!_threadStress.IsAlive)
            {
                _stress = true;

                if (_threadStress.ThreadState == System.Threading.ThreadState.Stopped)
                    _threadStress = new Thread(Stress);

                _threadStress.Start();

                btn_stress.Text = "Parar stress";
            }
            else
            {
                _stress = false;
                btn_stress.Text = "Stressar";
            }
        }

        private void Stress()
        {
            // FIXME
            //AppendTextConsole(_recorderInteraction.Record("1", "SIP/190001", -1));
            //AppendTextConsole(_recorderInteraction.GetResponse());

            Thread.Sleep(500);

            if (_stress)
                Stress();
        }

        private void ValidateInteractions()
        {
            btn_stress.Enabled = _recorderInteraction != null;
            btn_enviar_comando.Enabled = _recorderInteraction != null;
            btn_tocar_audio.Enabled = _recorderInteraction != null;
        }

        private void btn_analisar_gravacoes_Click(object sender, EventArgs e)
        {
            new AnalisarGravacoesCortadas();
        }
    }
}