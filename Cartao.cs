namespace Aula13Uber
{
    public class Cartao
    {
        public string numero { get;set; }
        public string titular { get;set; }
        public string bandeira { get;set; }
        public string cvv { get;set; }

        /// <summary>
        /// Cadastro de um novo cartão
        /// </summary>
        /// <returns>Dados do cartão e confirmação</returns>
        public string cadastrarCartao( string titular, string numero, string bandeira ){
            return $"Pagamento Novo Cartão \nTitular: {titular}\nNúmero: {numero}\nBandeira: {bandeira}";
        }
    }
}