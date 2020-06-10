namespace Aula13Uber
{
    public class Conta
    {
        private string agencia { get;set; }
        private string conta { get;set; }


        //Adicionar uma nova conta
        public string cadastrarConta( string agenciaNova, string contaNova){
            return $"Nova conta\nAgencia {agenciaNova}\nConta {contaNova}";
        }

        public void excluir(){
            System.Console.WriteLine("cancelado");
        }
    }
}