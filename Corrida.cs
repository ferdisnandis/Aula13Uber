namespace Aula13Uber
{
    public class Corrida
    {
        public string localInicio;
        public string localChegada;
        private string statusCorrida;
        private string motorista;
        private string passageiro;


        /// <summary>
        /// Cancelar corrida
        /// </summary>
        /// <returns>Mensagem de cancelamento</returns>
        private string Cancelar(){
            return "A corrida foi cancelada";
        }
    }
}