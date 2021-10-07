using Projeto02.Model;
using Projeto02.Model.Enum;
using System;

namespace Projeto02
{
    public class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            int nAleatorio = random.Next(0,99);

            Console.WriteLine("Bem vindo ao ---Bar Inteligente---" + "\nEscolha uma opção válida:");
            Console.WriteLine("1- Pedido" +
                            "\n2- Funcionario" +
                            "\n3- Financeiro" +
                            "\n4- Estoque" +
                            "\n5- Delivery" +
                            "\n6- contrato" +
                            "\n7- Outros");
            Console.WriteLine("--------------------------------------------");

            int Result = int.Parse(Console.ReadLine());

            switch ((MenuEnum)Result)
            {
                case MenuEnum.Pedido:
                    Console.WriteLine("\nO que gostaria?");
                    string Item = Console.ReadLine();

                    Console.WriteLine("Quantos(a) " + Item + "(s)" + " você gostaria?");
                    int Qnts = int.Parse(Console.ReadLine());

                    Console.WriteLine("E qual o valor?");
                    decimal Qvalor = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Alguma observação?");
                    string Obs = Console.ReadLine();

                    var bebida = new Bebida();
                    bebida.BebidaId = nAleatorio;
                    bebida.Nome = Item;
                    bebida.Valor = Qvalor;
                    bebida.Quantidade = Qnts;
                    bebida.Data = DateTime.Now;
                    bebida.Observacao = Obs;

                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("Voce Pediu " + bebida.Quantidade + "(s)" + bebida.Nome, "(s)");
                    Console.WriteLine("Cada uma a R$:" + bebida.Valor);
                    Console.WriteLine("Na data: " + bebida.Data);
                    Console.WriteLine("Com a observação: " + bebida.Observacao);
                    Console.WriteLine("E o total deu R$:" + bebida.Valor * bebida.Quantidade);
                    Console.WriteLine("--------------------------------------------");
                    break;
                case MenuEnum.Funcionario:
                    Console.WriteLine("\nDigite o nome completo do funcionário");
                    string func = Console.ReadLine();

                    Console.WriteLine(func + ", qual o seu cargo?");
                    string cargo = Console.ReadLine();

                    Console.WriteLine("Digite seu email");
                    string email = Console.ReadLine();

                    Console.WriteLine(func + ", digite seu endereço");
                    string endrc = Console.ReadLine();

                    Console.WriteLine("Digite um telefone válido");
                    string tel = Console.ReadLine();

                    var usuario = new Usuario();
                    usuario.UsuarioId = nAleatorio;
                    usuario.Nome = func;
                    usuario.Cargo = cargo;
                    usuario.Email = email;
                    usuario.Endereco = endrc;
                    usuario.Telefone = tel;

                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("Funcionário: " + usuario.Nome + " Identificador:359 " + usuario.UsuarioId);
                    Console.WriteLine("Cargo: " + usuario.Cargo);
                    Console.WriteLine("Registrado");
                    Console.WriteLine("--------------------------------------------");

                    break;
                case MenuEnum.Financeiro:
                    break;
                case MenuEnum.Estoque:
                    break;
                case MenuEnum.Delivery:
                    break;
                case MenuEnum.Contrato:
                    break;
                case MenuEnum.Outros:
                    break;
                default:
                    Console.WriteLine("Opção inválida, tente uma opção válida!");
                    break;
            }
        }
    }
}

