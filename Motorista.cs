namespace Aula13Uber
{
    public class Motorista : Usuario
    {
        private string carro;
        private string placa;

        public string aceitarPassageiro( string nome ){
            return "Aceito corrida com "+nome;
        }

        public bool receberPagamento( string statusCorrida){
            if(statusCorrida == "Finalizado"){
                return true;
            }
            return false;
        }
    }
}