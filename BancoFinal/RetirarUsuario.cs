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
    public partial class RetirarUsuario : Form
    {
        public RetirarUsuario()
        {
            InitializeComponent();
        }

        private void btnRetirarDinero_Click(object sender, EventArgs e)
        {
            ClientesSingleton ParaRetirar = ClientesSingleton.Getinstancia();
            string fileName = "clientes.txt";
            string fileCopia = "Copia_Clientes.txt";
            string ValorARetirar = textBoxRetirarValorARetirar.Text;
            ParaRetirar.Archivo(fileName,fileCopia,ParaRetirar.Nombre,ParaRetirar.Clave,null,ValorARetirar,null,null,null);
            ParaRetirar.DatosClienteActual(ParaRetirar.Nombre);
            labelRetirarSaldoActual.Text = ParaRetirar.Saldo.ToString();
        }
    }
}
