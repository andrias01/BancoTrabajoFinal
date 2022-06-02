using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoFinal
{
    public partial class ConsignarVista : Form
    {
        public ConsignarVista()
        {
            InitializeComponent();
        }

        private void textBoxConsignar_Enter(object sender, EventArgs e)
        {
            if (textBoxConsignar.Text == "CANTIDAD")
            {
                textBoxConsignar.Text = "";
                textBoxConsignar.ForeColor = Color.LightGray;
            }
        }

        private void textBoxConsignar_Leave(object sender, EventArgs e)
        {
            if (textBoxConsignar.Text == "")
            {
                textBoxConsignar.Text = "CANTIDAD";
                textBoxConsignar.ForeColor = Color.DimGray;
            }
        }
    }
}
