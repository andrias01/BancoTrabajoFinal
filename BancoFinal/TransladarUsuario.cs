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
    public partial class TransladarUsuario : Form
    {
        public TransladarUsuario()
        {
            InitializeComponent();
        }
        private void btnRetirarDinero_Click(object sender, EventArgs e)
        {
            if (textBoxTransValorATransladar.Text == String.Empty || textBoxTransPersonaRecibe.Text == String.Empty)
                MessageBox.Show("Debe Digitar todos los campos");
            else
            {
                Transferir();
                Retirar();
            }
        }
        public void Retirar()
        {
            ClientesSingleton ParaRetirar = ClientesSingleton.Getinstancia();
            string fileName = "clientes.txt";
            string fileCopia = "Copia_Clientes.txt";
            string ValorARetirar = textBoxTransValorATransladar.Text;
            ParaRetirar.Archivo(fileName, fileCopia, ParaRetirar.Nombre, ParaRetirar.Clave, null, ValorARetirar, null, null, null);
            ParaRetirar.DatosClienteActual(ParaRetirar.Nombre);
            labelTransladarSaldoActual.Text = ParaRetirar.Saldo.ToString();
        }
        public void Transferir()
        {
            ClientesSingleton ConsiganarSegunElCliente = ClientesSingleton.Getinstancia();
            string fileName = "clientes.txt";
            string fileCopia = "Copia_Clientes.txt";
            string NombreUsuario = textBoxTransPersonaRecibe.Text;
            string ValorAConsignar = textBoxTransValorATransladar.Text;
            ConsiganarSegunElCliente.Archivo(fileName, fileCopia, NombreUsuario, null, ValorAConsignar, null, null, null, null);
        }
    }
}
