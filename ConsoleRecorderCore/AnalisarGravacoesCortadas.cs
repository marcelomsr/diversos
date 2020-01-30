using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace ConsoleRecorderCore
{
    public class AnalisarGravacoesCortadas
    {
        private RecorderInteraction _recorderInteraction;
        SimplePlayback _player;

        private int _QTD_SEGUNDOS_MAX_GRAVACAO = 120;
        private List<GravacaoComDefeito> _gravacoes;

        private string _desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        //{0} endereço do exe ffmpeg, {1} início do corte, {2} duração do audio, {3} audio original, {4} recorte
        private string _base_script = "{0} -ss {1} -t {2} -i {3} {4}";

        public AnalisarGravacoesCortadas()
        {
            Recorder recorder = new Recorder("HA", "10.0.72.194", 8882);
            _recorderInteraction = new RecorderInteraction(recorder);

            _player = new SimplePlayback();

            obter_gravacoes_com_defeito();
        }

        private void obter_gravacoes_com_defeito()
        {
            _gravacoes = new List<GravacaoComDefeito>();
            
            string[] gravacoes = File.ReadAllLines(Path.Combine(_desktop, "gravacoes.txt"));

            foreach (string gravacao in gravacoes)
            {
                var split = gravacao.Split(',');

                string data_gravacao = split[0];
                int gravacao_aceite = Convert.ToInt32(split[2]);
                int gravacao_full = Convert.ToInt32(split[3]);
                int inicio_gravacao_aceite = Convert.ToInt32(split[1]);
                string caminho_gravacao_aceite = @"S:\" + _recorderInteraction.GetPathRecording(gravacao_aceite);
                string caminho_gravacao_full = @"S:\" + _recorderInteraction.GetPathRecording(gravacao_full);

                try
                {
                    _player.BeginPlayback(new MemoryStream(File.ReadAllBytes(caminho_gravacao_aceite)));
                }/*
                catch(FileNotFoundException fnfe)
                {

                }
                catch(FormatException fe)
                {

                }*/
                catch(Exception e)
                {
                    string diretorio_final = _desktop + @"\gravacoes\" + data_gravacao + "\\";
                    
                    if (!Directory.Exists(diretorio_final))
                        Directory.CreateDirectory(diretorio_final);

                    executar_script(
                        string.Format(_base_script,
                        _desktop + @"\ffmpeg.exe",
                        inicio_gravacao_aceite,
                        _QTD_SEGUNDOS_MAX_GRAVACAO,
                        caminho_gravacao_full,
                        _desktop + @"\gravacoes\" + data_gravacao + "\\" + Path.GetFileName(caminho_gravacao_aceite)));
                    
                    _gravacoes.Add(new GravacaoComDefeito(gravacao_aceite, gravacao_full, inicio_gravacao_aceite, caminho_gravacao_aceite, caminho_gravacao_full));
                }                
            }
        }

        private void executar_script(string argumentos)
        {
            //Define uma instância da classe ProcessStartInfo
            ProcessStartInfo pro = new ProcessStartInfo();
            //Define a propriedade FileName a ser iniciada
            pro.FileName = "cmd.exe";
            pro.Arguments = "/c " + argumentos;
            pro.CreateNoWindow = true;
            //inicia o processo
            Process proStart = new Process();
            // Define o nome do processo
            proStart.StartInfo = pro;
            // chama o método Start para começar
            proStart.Start();
        }
    }

    public class GravacaoComDefeito
    {
        public int gravacao_aceite;
        public int gravacao_full;
        public int inicio_gravacao_aceite;
        public string caminho_gravacao_aceite;
        public string caminho_gravacao_full;

        public GravacaoComDefeito(int gravacao_aceite, int gravacao_full, int inicio_gravacao_aceite, string caminho_gravacao_aceite, string caminho_gravacao_full)
        {
            this.gravacao_aceite = gravacao_aceite;
            this.gravacao_full = gravacao_full;
            this.inicio_gravacao_aceite = inicio_gravacao_aceite;
        }
    }
}
