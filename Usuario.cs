namespace Aula13Uber
{
    public class Usuario
    {
        public string Nome { get;set; }
        private string login = "fernanda@gmail.com";
        private string senha = "fernanda1234";
        public string Foto { get; set; }
        public string LocalizacaoAtual { get;set; }
        public string TokenLogin { get; set; }

        public bool Login(string login, string senha){
            
            if(this.login == login && this.senha == senha){
                TokenLogin = "fiewohff5wa4faw";
                return true;
            }
            return false;
        }
        public void Logout(){
            TokenLogin = "";
        }
    }
}