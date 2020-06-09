namespace Aula13Uber
{
    public class Cartao
    {
        private string numero;
        private string titular;
        private string bandeira;
        private string cvv;

        /// <summary>
        /// Cadastro de um novo cartão
        /// </summary>
        /// <returns>Dados do cartão e confirmação</returns>
        public string cadastrarCartao( string titular, string numero, string bandeira ){
            return $"Pagamento Novo Cartão \nTitular: {titular}\nNúmero: {numero}\nBandeira: {bandeira}";
        }
    }
}