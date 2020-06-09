namespace Aula13Uber
{
    public class Cartao
    {
        private string numero;
        private string titular;
        private string bandeira;
        private string cvv;

        public string Cadastrar(){
            return $"Cadastrar cartão \nNúmero: {numero}";
        }
    }
}