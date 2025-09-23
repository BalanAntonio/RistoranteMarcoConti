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
    public partial class Ristorante : Form
    {
        public Ristorante()
        {
            InitializeComponent();
        }

        int indice = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if(!File.Exists("menu.csv"))
            {
                StreamWriter sw = new StreamWriter("menu.csv");
                sw.Write("Bruschetta al pomodoro;6,50\r\nCarpaccio di manzo con rucola e grana;9,00\r\nInsalata caprese con mozzarella di bufala;8,00\r\nSpaghetti alla carbonara;12,00\r\nLasagna alla bolognese;13,50\r\nRisotto ai funghi porcini;14,00\r\nBistecca alla fiorentina;22,00\r\nFiletto di salmone al forno con erbe aromatiche;18,00\r\nPollo alla cacciatora;15,50\r\nPatate al forno;4,00\r\nVerdure grigliate;5,00\r\nInsalata mista;4,50\r\nTiramisù della casa;5,00\r\nCheesecake ai frutti di bosco;6,00\r\nPanna cotta con coulis di fragola;5,50");
                sw.Close();
            }

            Menu_form menu = new Menu_form();
            menu.ShowDialog();

            if(menu.DialogResult != DialogResult.OK) { return; } 

            string ordin = $"\n{indice};{menu.ordine.Nome};";

            for(int i = 0;i < menu.ordine.Piatti.Length; i++)
            {
                ordin += menu.ordine.Piatti[i].Quantita + ";" + menu.ordine.Piatti[i].Nome + ";";
            }
            ordin += "" + menu.ordine.PrezzoTot;

            lst_ordini.Items.Add("Tavolo n. " + indice + " " + menu.ordine.Nome);

            using(StreamWriter sw = new StreamWriter("ordini.csv",true))
            {
                sw.Write(ordin);
            }

            indice++;
        }

        private void Ristorante_Load(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("ordini.csv"))
            {
                sr.ReadLine();
                string[] tutto = sr.ReadToEnd().Split('\n');
                indice = tutto.Length;

                for (int i = 0; i < indice; i++)
                {
                    string[] diviso = tutto[i].Split(';');
                    lst_ordini.Items.Add("Tavolo n. " + diviso[0] + " " + diviso[1]);
                }
            }
        }

        private void lst_ordini_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            List<Piatto> piatti = new List<Piatto>();
            Ordine ordine;
            int id;

            using (StreamReader sr = new StreamReader("ordini.csv"))
            {
                sr.ReadLine();
                string[] tutto = sr.ReadToEnd().Split('\n')[lst_ordini.SelectedIndex].Split(';');

                id = int.Parse(tutto[0]);

                for (int i = 2; i < tutto.Length - 1; i += 2)
                {
                    Piatto piatt = new Piatto(tutto[i + 1], 0f, int.Parse(tutto[i]));
                    piatti.Add(piatt);
                }

                ordine = new Ordine(piatti.ToArray(), tutto[1], float.Parse(tutto[tutto.Length-1]));
            }

            Visualizza vis = new Visualizza();
            vis.SalvaValori(ordine, id);
            vis.ShowDialog();
        }
    }
}
