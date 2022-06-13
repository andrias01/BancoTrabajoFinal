using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BancoFinal
{
    public partial class ConsignarUsuario : Form
    {
        public ConsignarUsuario()
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

        private void btnConsignarAccion_Click(object sender, EventArgs e)
        {
            ClientesSingleton ConsiganarSegunElCliente = ClientesSingleton.Getinstancia();
            string fileName = "clientes.txt";
            string fileCopia = "Copia_Clientes.txt";
            string NombreUsuario = ConsiganarSegunElCliente.Nombre;
            string ValorAConsignar = textBoxConsignar.Text;
            ConsiganarSegunElCliente.Archivo(fileName, fileCopia, NombreUsuario, null, ValorAConsignar, null, null, null, null);
        }
        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString("hh:");
            labelMinutos.Text = DateTime.Now.ToString("mm:");
            labelSegundos.Text = DateTime.Now.ToString("ss");
            labelDia.Text = DateTime.Now.ToString("dddd");
            labelMes.Text = DateTime.Now.ToString("MMMMM");
            labelAño.Text = DateTime.Now.ToString("yyy");
        }
    }
}
