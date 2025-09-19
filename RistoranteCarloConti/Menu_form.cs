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

        private void AggiornaMenu(string cosa)
        {
            using (StreamReader sr = new StreamReader("menu.csv"))
            {
                string tutto = sr.ReadToEnd();
                string[] tutti = tutto.Split('\n');

                lst_menu.Items.Clear();

                for (int i = 0; i < tutti.Length; i++)
                {
                    string[] diviso = tutti[i].Split(';');
                    if(cosa == "" || diviso[0].ToLower() == cosa.ToLower())
                    {
                        lst_menu.Items.Add(diviso[0] + "\t\t\t" + diviso[1]);
                    }
                }

            }
        }

        private void Menu_form_Load(object sender, EventArgs e)
        {
            AggiornaMenu("");
        }

        private void txt_cerca_MouseUp(object sender, MouseEventArgs e) { txt_cerca.Text = ""; }
        private void txt_nomeOrdine_MouseUp(object sender, MouseEventArgs e) { txt_nomeOrdine.Text = ""; }
        private void txt_nome_MouseUp(object sender, MouseEventArgs e) { txt_nome.Text = ""; }

        private void btn_cerca_Click(object sender, EventArgs e)
        {
            AggiornaMenu(txt_cerca.Text);
        }
    }
}
