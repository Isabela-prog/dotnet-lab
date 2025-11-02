using NET.C_.Financeiro;

namespace NET.C_.Financeiro
{
    internal class Programa
    {
        private static List<Cliente> Clientes = new();

        static void Main(string[] args)
        {
            ConsultarCliente();
        }

        static void ConsultarCliente()
        {
            Console.WriteLine("Olá, seja bem-vindo ao Seu Banco!");
            Console.WriteLine("Digite o seu código de cliente: ");
            string codigo = Console.ReadLine();
            Cliente cliente = null;

            foreach (Cliente cli in Clientes)
            {
                if (cli.Codigo == codigo)
                {
                    cliente = cli;
                }
            }

            if (cliente == null)
            {
                Console.WriteLine("Cliente não encontrado! Deseja se cadastrar? Digite S ou N");
                string cadastrarCliente = Console.ReadLine().ToUpper();
                if (cadastrarCliente == "S")
                {
                    Console.WriteLine("Digite o seu código: ");
                    string codigoClienteNovo = Console.ReadLine();
                    Console.WriteLine("Digite o seu nome: ");
                    string NomeClienteNovo = Console.ReadLine();
                    Console.WriteLine("Digite PF ou PJ");
                    string TipoCliente = Console.ReadLine().ToUpper();

                    if (TipoCliente == "PF")
                    {
                        cliente = new PF(codigoClienteNovo, NomeClienteNovo);
                    }
                    else if (TipoCliente == "PJ")
                    {
                        cliente = new PJ(codigoClienteNovo, NomeClienteNovo);
                    }
                    else
                    {
                        Console.WriteLine("Tipo de cliente inválido. Encerrando o programa.");
                        return;
                    }
                    Clientes.Add(cliente);
                    ExibirMenu(cliente);
                }
                else
                {
                    Console.WriteLine("Encerrando o programa. Até mais!");
                    return;
                }
            }
        }

        static void ExibirMenu(Cliente cliente)
        {
            Console.WriteLine($"Bem-vindo, {cliente.Nome}!");
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Verificar saldo");
            Console.WriteLine("2 - Depositar");
            Console.WriteLine("3 - Sacar");
            Console.WriteLine("4 - Sair");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine($"Seu saldo é: R$ {cliente.Saldo}");
                    break;
                case "2":
                    Console.WriteLine("Digite o valor para depositar: ");
                    decimal valorDeposito = Convert.ToDecimal(Console.ReadLine());
                    cliente.RealizarDeposito(valorDeposito);
                    Console.WriteLine("Depósito realizado com sucesso!");
                    break;
                case "3":
                    Console.WriteLine("Digite o valor para sacar: ");
                    decimal valorSaque = Convert.ToDecimal(Console.ReadLine());
                    decimal saldoAntes = cliente.Saldo;
                    cliente.RealizarSaque(valorSaque);
                    if (cliente.Saldo < saldoAntes)
                    {
                        Console.WriteLine("Saque realizado com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Saldo insuficiente para saque.");
                    }
                    break;
                case "4":
                    Console.WriteLine("Encerrando o programa. Até mais!");
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
            ExibirMenu(cliente);
        }
    }
}




