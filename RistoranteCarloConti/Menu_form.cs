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

        private void Menu_form_Load(object sender, EventArgs e)
        {
            using(StreamReader sr = new StreamReader(@"menu.csv"))
            {
                string tutto = sr.ReadToEnd();
                string[] tutti = tutto.Split('\n');
                MessageBox.Show("" + tutti.Length);
            }
        }
    }
}
