using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace DevFitness.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o seu nome: ");
            var nome = Console.ReadLine();

            Console.Write("Digite a sua altura: ");
            var altura = Console.ReadLine();

            Console.Write("Digite o seu peso: ");
            var peso = Console.ReadLine();

            var listaRefeicoes = new List<Refeicao>();

            var continuaPrograma = true;

            while (continuaPrograma)
            {
                ExibirOpções();

                var opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "0":
                        continuaPrograma = false;
                        break;
                    case "1":
                        Console.WriteLine($"Nome: {nome}, Altura: {altura}, Peso: {peso}");
                        break;
                    case "2":
                        Cadastrar(listaRefeicoes);
                        break;
                    case "3":
                        ListarRefeicoes(listaRefeicoes);
                        break;
                    default:
                        Console.WriteLine("Por favor, digite outra opção.");
                        break;
                }
                var bebida = new Bebida(123, "Suco", false);
                var comida = new Comida(123, "Suco", 0.5M);

                var listaComidas = new List<Refeicao> { bebida, comida };

            }
        }

        private static void ListarRefeicoes(List<Refeicao> refeicoes)
        {
            Console.WriteLine("Listando informações...");
            foreach (var item in refeicoes)
            {
                Console.WriteLine($"Descrição: {item.Descricao}, Calorias: {item.Calorias}");
            }
        }

        private static void Cadastrar(List<Refeicao> list)
        {
            Console.WriteLine("Digite a descrição da refeição.");
            var descricao = Console.ReadLine();

            Console.WriteLine("Digite a quantidade de calorias.");
            var calorias = Console.ReadLine();

            if (int.TryParse(calorias, out int caloriasInt))
            {
                var refeicao = new Refeicao(caloriasInt, descricao);
                list.Add(refeicao);
            }
            else
            {
                Console.WriteLine("Valor de calorias inválido");
            }
        }

        public static void ExibirOpções()
        {
            Console.WriteLine("--- Seja bem vindo (a) ao DevFitness ---");
            Console.WriteLine("1- Exibir detalhes de usuário");
            Console.WriteLine("2- Cadastrar nova refeição");
            Console.WriteLine("3- Listar todas as refeições");
            Console.WriteLine("0- Finalizar aplicação");
        }
    }
}
