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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void suma_Click(object sender, EventArgs e)
        {
            Oper.Text = "+";
            int producto = Convert.ToInt32(Prod1.Text);
            int producto2 = Convert.ToInt32(Prod2.Text);
            resultado.Text = $"{producto + producto2}";
        }

        private void resta_Click(object sender, EventArgs e)
        {
            Oper.Text = "-";
            int producto = Convert.ToInt32(Prod1.Text);
            int producto2 = Convert.ToInt32(Prod2.Text);
            resultado.Text = $"{producto - producto2}";
        }

        private void multiplicación_Click(object sender, EventArgs e)
        {
            Oper.Text = "*";
            int producto = Convert.ToInt32(Prod1.Text);
            int producto2 = Convert.ToInt32(Prod2.Text);
            resultado.Text = $"{producto * producto2}";
        }

        private void division_Click(object sender, EventArgs e)
        {
            Oper.Text = "/";
            int producto = Convert.ToInt32(Prod1.Text);
            int producto2 = Convert.ToInt32(Prod2.Text);
            resultado.Text = $"{producto / producto2}";
        }
    }
}
