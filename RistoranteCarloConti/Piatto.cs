using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RistoranteCarloConti
{
    internal class Piatto
    {
        private string n;
        private float p;

        public string Nome { get { return n; } }
        public float Prezzo { get { return p; } }

        public Piatto(string nome, float prezzo)
        {
            n = nome;
            p = prezzo;
        }
    }
}
