namespace Aula13Uber
{
    public class Conta
    {
        private string agencia;
        private string conta;

        public string cadastrar(){
            return $"Nova conta\nAgencia {agencia}\nConta {conta}";
        }
        public void excluir(){
        }
    }
}