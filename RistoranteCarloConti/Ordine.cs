using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RistoranteCarloConti
{
    internal class Ordine
    {
        private Piatto[] p;
        private string n;
        private float pr;

        public Piatto[] Piatti { get { return p; } }
        public string Nome { get { return n; } }
        public float PrezzoTot { get { return pr; } }

        public Ordine(Piatto[] piatti, string chi, float prezzo)
        {
            p = piatti;
            n = chi;
            pr = prezzo;
        }
    }
}
