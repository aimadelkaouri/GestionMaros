using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            materiel materiel = new materiel();
            materiel.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            client client = new client();
            client.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            site site = new site();
            site.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            type type = new type();
            type.ShowDialog();
        }
    }
}
