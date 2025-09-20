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
        private int q;

        public string Nome { get { return n; } }
        public float Prezzo { get { return p; } }
        public float Quantita { get { return q; } }

        public Piatto(string nome, float prezzo, int quantita)
        {
            n = nome;
            p = prezzo;
            q = quantita;
        }
    }
}
