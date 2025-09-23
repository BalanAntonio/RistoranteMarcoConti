using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RistoranteCarloConti
{
    public partial class Visualizza : Form
    {
        public Visualizza()
        {
            InitializeComponent();
        }

        private Ordine pordine;
        private int pid;

        internal void SalvaValori(Ordine ordine, int id)
        {
            pordine = ordine;
            pid = id;
        }

        private void Visualizza_Load(object sender, EventArgs e)
        {
            lbl_nc.Text = pordine.Nome;
            lbl_tavolo.Text = "Tavolo n. " + pid;

            for (int i = 0; i < pordine.Piatti.Length; i++)
            {
                lst_piatti.Items.Add(pordine.Piatti[i].Quantita.ToString() + " x " + pordine.Piatti[i].Nome.ToString());
            }
        }
    }
}
