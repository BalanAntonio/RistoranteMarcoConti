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
            
        }
    }
}
