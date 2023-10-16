using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Montecarlo.Algoritmos
{
    internal class AlgoritmoGenerador
    {
        public int GenerarRandom()
        {
            Random random = new Random();
            return random.Next(1000, 5001);
        }
        public List<int> GenerarLista(int n)
        {
            List<int> lista = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int rand = GenerarRandom();
                lista.Add(rand);
            }  
            return lista;
        }
    }
}
