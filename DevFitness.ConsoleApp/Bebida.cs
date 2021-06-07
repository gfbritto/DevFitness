using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFitness.ConsoleApp
{
    class Bebida : Refeicao
    {
        public Bebida(int calorias, string descricao, bool contemLactose) : base(calorias, descricao)
        {

        }
        public bool ContemLactose { get; private set; }
    }
}
