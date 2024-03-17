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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int horas = Convert.ToInt32(textBox1.Text);
                
                textBox2.Text = $"{horas * 60}";
                textBox3.Text = $"{horas * 3600}";
            }
            catch
            {
                MessageBox.Show("¡Texto vacío!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
    }
}
