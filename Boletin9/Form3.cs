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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int mesnum = Convert.ToInt32(textBox2.Text);
                string mes;

                if (mesnum == 1) 
                {
                    mes = "Enero";
                    label6.Text = $"{textBox1.Text} de {mes} de {textBox3.Text}";
                }
                else if (mesnum == 2) 
                {
                    mes = "Febrero";
                    label6.Text = $"{textBox1.Text} de {mes} de {textBox3.Text}";
                }
                else if (mesnum == 3)
                {
                    mes = "Marzo";
                    label6.Text = $"{textBox1.Text} de {mes} de {textBox3.Text}";
                }
                else if (mesnum == 4)
                {
                    mes = "Abril"; label6.Text = $"{textBox1.Text} de {mes} de {textBox3.Text}";
                }
                else if (mesnum == 5)
                {
                    mes = "Mayo"; label6.Text = $"{textBox1.Text} de {mes} de {textBox3.Text}";
                }
                else if (mesnum == 6)
                {
                    mes = "Junio"; label6.Text = $"{textBox1.Text} de {mes} de {textBox3.Text}";
                }
                else if (mesnum == 7)
                {
                    mes = "Julio"; label6.Text = $"{textBox1.Text} de {mes} de {textBox3.Text}";
                }
                else if (mesnum == 8)
                {
                    mes = "Agosto"; label6.Text = $"{textBox1.Text} de {mes} de {textBox3.Text}";
                }
                else if (mesnum == 9)
                {
                    mes = "Septiembre"; label6.Text = $"{textBox1.Text} de {mes} de {textBox3.Text}";
                }
                else if (mesnum == 10)
                {
                    mes = "Octubre"; label6.Text = $"{textBox1.Text} de {mes} de {textBox3.Text}";
                }
                else if (mesnum == 11)
                {
                    mes = "Noviembre"; label6.Text = $"{textBox1.Text} de {mes} de {textBox3.Text}";
                }
                else if (mesnum == 12)
                {
                    mes = "Diciembre"; label6.Text = $"{textBox1.Text} de {mes} de {textBox3.Text}";
                }
                else
                {
                    MessageBox.Show("¡Número de mes inválido!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                
            }
            catch 
            { 
                MessageBox.Show("¡Texto inválido!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
        }
    }
}
