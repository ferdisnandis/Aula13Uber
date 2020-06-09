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

                //Malandragem
                Passageiro passageiro = new Passageiro();
                Motorista motorista = new Motorista();
                Cartao cartao = new Cartao();
                Corrida corrida = new Corrida();
                Pagamento pagamento = new Pagamento ();



                //Local Inicial
                System.Console.WriteLine("Digite onde você está: ");
                corrida.localInicio = Console.ReadLine();

                //Destino da corrida
                System.Console.WriteLine("Informe seu destino: ");
                corrida.localChegada = Console.ReadLine();

                System.Console.WriteLine();

                //Cadastro Cartão
                System.Console.WriteLine("Selecione o cartão já cadastrado para pagamento: ");
                System.Console.WriteLine("Digite o número do cartão: ");
                cartao.numero = Console.ReadLine();
                System.Console.WriteLine("Digite a bandeira do cartão: ");
                cartao.bandeira = Console.ReadLine();
                System.Console.WriteLine("Digite o CVV do cartão: ");
                cartao.cvv = Console.ReadLine();

                System.Console.WriteLine();

                System.Console.WriteLine(passageiro.procurarMotorista());

                //Dados do motorista
                System.Console.WriteLine("Nome do motorista:");
                System.Console.WriteLine("Wagner");

                System.Console.WriteLine("Modelo do carro:");
                System.Console.WriteLine(motorista.carro = "Fiat");

                System.Console.WriteLine("Placa do carro:");
                System.Console.WriteLine(motorista.placa = "ABC1234");

                System.Console.WriteLine();

                System.Console.WriteLine("A corrida foi finalizada?");
                string statusCorrida = Console.ReadLine();

                System.Console.WriteLine(passageiro.Pagar(statusCorrida));

            }else{
                Console.WriteLine("Usuário deslogado");
            }


        }
    }
}
