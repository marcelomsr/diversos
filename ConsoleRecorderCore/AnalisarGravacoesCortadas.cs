using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleRecorderCore
{
    public class AnalisarGravacoesCortadas
    {
        //ffmpeg -ss 50 -t 120 -i audio_origem.wav audio-cortado.wav
        private RecorderInteraction _recorderInteraction;

        private int _QTD_SEGUNDOS_MAX_GRAVACAO = 120;
        private List<GravacaoComDefeito> _gravacoes;

        public AnalisarGravacoesCortadas()
        {
            Recorder recorder = new Recorder("HA", "10.0.72.194", 8882);
            _recorderInteraction = new RecorderInteraction(recorder);

            obter_gravacoes_com_defeito();
        }

        private void obter_gravacoes_com_defeito()
        {
            _gravacoes = new List<GravacaoComDefeito>();

            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktop, "gravacoes.txt");

            string[] gravacoes = File.ReadAllLines(filePath);

            foreach (string gravacao in gravacoes)
            {
                var split = gravacao.Split(',');

                int gravacao_aceite = Convert.ToInt32(split[1]);
                int gravacao_full = Convert.ToInt32(split[2]);
                int inicio_gravacao_aceite = Convert.ToInt32(split[0]);
                string caminho_gravacao_aceite = @"S:\" + _recorderInteraction.GetPathRecording(gravacao_aceite);
                string caminho_gravacao_full = @"S:\" + _recorderInteraction.GetPathRecording(gravacao_full);

                _gravacoes.Add(new GravacaoComDefeito(gravacao_aceite, gravacao_full, inicio_gravacao_aceite, caminho_gravacao_aceite, caminho_gravacao_full));
            }
        }

        private void verificar_gravacao()
        {
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
