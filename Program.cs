using System;

namespace Aula13Uber
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario user = new Usuario();

            //Entrada de dados
            System.Console.WriteLine("Digite seu login: ");
            string login = Console.ReadLine();

            System.Console.WriteLine("Digite a sua senha: ");
            string senha = Console.ReadLine();

            //Confirmação do login
            user.Login(login,senha);
            if(user.TokenLogin != "" && user.TokenLogin !=null){
                Console.WriteLine("Usuário logado");
                System.Console.WriteLine();

                Passageiro passageiro = new Passageiro();
                Motorista motorista = new Motorista();

                //Local Inicial
                System.Console.WriteLine("Digite onde você está: ");
                passageiro.localInicio = Console.ReadLine();

                //Destino da corrida
                System.Console.WriteLine("Infssssssssorme seu destino: ");
                passageiro.localChegada = Console.ReadLine();

                System.Console.WriteLine(passageiro.procurarMotorista());

                //Dados do motorista
                System.Console.WriteLine("Nome do motorista:");
                System.Console.WriteLine("Wagner");

                System.Console.WriteLine("Modelo do carro:");
                System.Console.WriteLine(motorista.carro = "Fiat");

                System.Console.WriteLine("Placa do carro:");
                System.Console.WriteLine(motorista.placa = "ABC1234");


                //Selecionar cartão
                System.Console.WriteLine("Cadastre o cartão para pagamento: ");

                System.Console.WriteLine();

                //Cadastro do cartão
                Console.WriteLine("Escreva o titular do cartão:");
                string titular = Console.ReadLine();

                System.Console.WriteLine("Escreva os números do cartão:");
                string numero = Console.ReadLine();

                System.Console.WriteLine("Informe a bandeira:");
                string bandeira = Console.ReadLine();

                System.Console.WriteLine("Informe o CVV:");
                string cvv = Console.ReadLine();

                System.Console.WriteLine("A corrida foi finalizada?");
                string statusCorrida = Console.ReadLine();

                System.Console.WriteLine(passageiro.Pagar(statusCorrida));

            }else{
                Console.WriteLine("Usuário deslogado");
            }

            
        }
    }
}
