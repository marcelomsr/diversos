namespace ConsoleRecorderCore
{
    public class RecorderInteraction
    {
        public enum Command
        {
            COMANDO_INICIAR_GRAVACAO_CHAMADA = 1,
            COMANDO_PARAR_GRAVACAO_CHAMADA = 2,
            COMANDO_OBTER_CAMINHO_GRAVACAO_LIGACAO = 3,
            COMANDO_OBTER_INFORMACOES_GRAVADOR = 4,
            COMANDO_OBTER_INFORMACOES_CANAL_GRAVACAO = 5,
            COMANDO_OBTER_CAMINHO_GRAVACAO = 6,
            COMANDO_INFORMAR_DADOS_GRAVACAO_COMPLETA = 7,
            COMANDO_OBTER_INFORMACOES_QUOTA = 9,
            COMANDO_OBTER_GRAVACAO = 10,
            COMANDO_OBTER_VERSAO = 11
        }
    }
}
