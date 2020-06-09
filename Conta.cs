namespace Aula13Uber
{
    public class Conta
    {
        private string agencia = "2296-7";
        private string conta = "7789-2";


        //Adicionar uma nova conta
        public string cadastrarConta( string agenciaNova, string contaNova){
            return $"Nova conta\nAgencia {agenciaNova}\nConta {contaNova}";
        }

        public void excluir(){
            System.Console.WriteLine("cancelado");
        }
    }
}