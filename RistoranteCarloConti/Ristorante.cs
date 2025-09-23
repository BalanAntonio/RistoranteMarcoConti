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
    public partial class Ristorante : Form
    {
        public Ristorante()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu_form menu = new Menu_form();
            menu.ShowDialog();
            
        }
    }
}
