namespace Aula13Uber
{
    public class Motorista : Usuario
    {
        public string carro;
        public string placa;

        /// <summary>
        /// Aceitar corrida
        /// </summary>
        /// <param name="nome">Nome de usuário</param>
        /// <returns>Mensagem com o nome</returns>
        public string aceitarPassageiro( string nome ){
            return "Aceito corrida com "+nome;
        }

        /// <summary>
        /// Receber pagamento
        /// </summary>
        /// <param name="statusCorrida">Classe corrida</param>
        /// <returns>Verdadeiro ou falso</returns>
        public bool receberPagamento( string statusCorrida){
            if(statusCorrida == "Finalizado"){
                return true;
            }
            return false;
        }
    }
}