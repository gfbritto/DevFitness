using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFitness.ConsoleApp
{
    public  class Refeicao
    {
        public Refeicao(int calorias, string descricao)
        {
            Calorias = calorias;
            Descricao = descricao;
        }

        public int Calorias { get; set; }
        public string Descricao { get;private set; }

        public virtual void ObterMensagem()
        {
            Console.WriteLine($"");
        }
    }
}
