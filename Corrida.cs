namespace Aula13Uber
{
    public class Corrida
    {
        public string localInicio;
        public string localChegada;
        private string statusCorrida = "Iniciada/Finalizada";
        private string motorista = "Wagner";
        private string passageiro = "Fernanda";


        /// <summary>
        /// Cancelar corrida
        /// </summary>
        /// <returns>Mensagem de cancelamento</returns>
        private string Cancelar(){
            return "A corrida foi cancelada";
        }
    }
}