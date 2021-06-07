using System;

namespace DevFitness.ConsoleApp
{
    public class Comida : Refeicao
    {
        public Comida(int calorias, string descricao, decimal preco) : base(calorias, descricao)
        {
            Preco = preco;
        }

        public decimal Preco { get; private set; }

        public override void ObterMensagem()
        {
            Console.WriteLine($"Descrição: {Descricao}, Calorias: {Calorias}");
        }
    }
}
