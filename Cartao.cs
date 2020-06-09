namespace Aula13Uber
{
    public class Cartao
    {
        public string numero;
        public string titular;
        public string bandeira;
        public string cvv;

        /// <summary>
        /// Cadastro de um novo cartão
        /// </summary>
        /// <returns>Dados do cartão e confirmação</returns>
        public string cadastrarCartao( string titular, string numero, string bandeira ){
            return $"Pagamento Novo Cartão \nTitular: {titular}\nNúmero: {numero}\nBandeira: {bandeira}";
        }
    }
}