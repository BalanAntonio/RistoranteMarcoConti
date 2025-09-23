using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RistoranteCarloConti
{
    public partial class Menu_form : Form
    {
        public Menu_form()
        {
            InitializeComponent();
        }

        private string[] listaPiatti;
        private float[] prezziPiatti;
        private float prezzoTot = 0f;
        private List<Piatto> piatti;

        internal Ordine ordine;

        private void AggiornaMenu(string cosa)
        {
            using (StreamReader sr = new StreamReader("menu.csv"))
            {
                string tutto = sr.ReadToEnd();
                string[] tutti = tutto.Split('\n');

                lst_menu.Items.Clear();

                listaPiatti = new string[tutti.Length];
                prezziPiatti = new float[tutti.Length];

                if(string.IsNullOrWhiteSpace(cosa) || cosa =="Cerca piatto...")
                {
                    for (int i = 0; i < tutti.Length; i++)
                    {
                        string[] diviso = tutti[i].Split(';');
                        lst_menu.Items.Add(diviso[0] + "\t\t\t" + diviso[1]);

                        listaPiatti[i] = diviso[0];
                        prezziPiatti[i] = float.Parse(diviso[1]);
                    }
                }
                else
                {
                    for (int i = 0; i < tutti.Length; i++)
                    {
                        string[] diviso = tutti[i].Split(';');
                        if (diviso[0].ToLower() == cosa.ToLower())
                        {
                            lst_menu.Items.Add(diviso[0] + "\t\t\t" + diviso[1]);
                            prezziPiatti[i] = float.Parse(diviso[1]);
                        }
                    }
                }

            }
        }


        private bool PiattoValido(string nome)
        {
            for(int i = 0; i < listaPiatti.Length; i++)
            {
                if (nome.ToLower() == listaPiatti[i].ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        private float PrezzoPiatto(string nome)
        {
            for(int i = 0; i<listaPiatti.Length; i++)
            {
                if(nome.ToLower() == listaPiatti[i].ToLower())
                {
                    return prezziPiatti[i];
                }
            }
            return -1;
        }

        private void Menu_form_Load(object sender, EventArgs e)
        {
            AggiornaMenu("");
            piatti = new List<Piatto>();
        }

        private void txt_cerca_MouseUp(object sender, MouseEventArgs e) { txt_cerca.Text = ""; }
        private void txt_nomeOrdine_MouseUp(object sender, MouseEventArgs e) { txt_nomeOrdine.Text = ""; }
        private void txt_nome_MouseUp(object sender, MouseEventArgs e) { txt_nome.Text = ""; }



        private void btn_cerca_Click(object sender, EventArgs e)
        {
            AggiornaMenu(txt_cerca.Text);
        }


        private void btn_aggiungi_Click(object sender, EventArgs e)
        {
            if (!PiattoValido(txt_nomeOrdine.Text))
            {
                MessageBox.Show("Piatto non valido");
                return;
            }
            else
            {
                Piatto piatto = new Piatto(txt_nomeOrdine.Text, (float)nmr_quantitaOrdine.Value * PrezzoPiatto(txt_nomeOrdine.Text), (int)nmr_quantitaOrdine.Value);
                piatti.Add(piatto);

                lst_ordini.Items.Add(piatto.Nome + "\t\t\t" + piatto.Quantita);
                prezzoTot += piatto.Prezzo;
                lbl_totale.Text = $"Tot. {prezzoTot} euro";
            }
        }

        private void btn_conferma_Click(object sender, EventArgs e)
        {
            if(txt_nome.Text != "Nome e cognome..." && !string.IsNullOrWhiteSpace(txt_nome.Text) && piatti.Any())
            {
                ordine = new Ordine(piatti.ToArray(), txt_nome.Text, prezzoTot);
                MessageBox.Show("Ordine confermato.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Errore: controllare i dati inseriti.");
            }
        }
    }
}
