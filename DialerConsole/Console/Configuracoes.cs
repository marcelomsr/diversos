
namespace Console
{
    public class Configuracoes
    {
        private static Configuracoes _instance;

        public static Configuracoes Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Configuracoes();

                return _instance;
            }
        }

        public bool usar_modo_superadministrador { get; set; }
        public bool registrar_log_dialer4COM { get; set; }
        public bool mostrar_identificacao_colunas { get; set; }
        public bool medir_tempo_resposta { get; set; }
        public bool repetir_ultimo_comando { get; set; }

        private Configuracoes()
        {
            registrar_log_dialer4COM = false;
            mostrar_identificacao_colunas = false;
            repetir_ultimo_comando = false;
        }
    }
}
