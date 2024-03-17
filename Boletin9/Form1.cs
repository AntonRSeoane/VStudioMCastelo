using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boletin9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 ej1 = new Form2();
            ej1.Show();
        }

        private void ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 ej2 = new Form3();
            ej2.Show();
        }

        private void ejercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 ej3 = new Form4();
            ej3.Show();
        }

        private void ejercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 ej4 = new Form5();
            ej4.Show();
        }

        private void ejercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 ej5 = new Form6();
            ej5.Show();
        }

        private void ejercicio6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 ej6 = new Form7();
            ej6.Show();
        }
    }
}
