namespace Aula13Uber
{
    public class Conta
    {
        private string agencia;
        private string conta;

        /// <summary>
        /// Adicionar uma nova conta
        /// </summary>
        /// <returns>Dados da nova conta</returns>
        public string cadastrarConta(){
            return $"Nova conta\nAgencia {agencia}\nConta {conta}";
        }

        /// <summary>
        /// Excluir conta
        /// </summary>
        public void excluir(){
        }
    }
}