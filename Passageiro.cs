using System;

namespace Aula13Uber
{
    public class Passageiro : Usuario
    {

        /// <summary>
        /// Localizar motorista
        /// </summary>
        /// <returns>Mensagem de procura</returns>
        public string procurarMotorista(){
            return "Procurando mostoristas disponíveis...";
        }

        /// <summary>
        /// Pagamento
        /// </summary>
        /// <param name="statusCorrida">Finalizada ou não</param>
        /// <returns>Confirmação de pagamento</returns>
        public string Pagar(string statusCorrida){

            if(statusCorrida == "Finalizada"){
                return "Pagamento efetuado";
            }else{
                return"Pagamento pendente pois a corrida não foi finalizada";
        }
        }
        }
    }
