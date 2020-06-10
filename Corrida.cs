namespace Aula13Uber
{
    public class Corrida
    {
        public string localInicio;
        public string localChegada;
        private string statusCorrida { get;set; }
        private string motorista { get;set; }
        private string passageiro { get;set; }

        /// <summary>
        /// Cancelar corrida
        /// </summary>
        /// <returns>Mensagem de cancelamento</returns>
        private string Cancelar(){
            return "A corrida foi cancelada";
        }
    }
}