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
    public partial class ConsultarzonaAdminr : Form
    {
        public ConsultarzonaAdminr()
        {
            InitializeComponent();
        }

        private void btnConsultarClientes_Click(object sender, EventArgs e)
        {
            dataGridViewConsulta.Rows.Clear();
            StreamReader archivo = new StreamReader("clientes.txt");
            while (!archivo.EndOfStream)
            {
                string texto = archivo.ReadLine();
                string[] leer = texto.Split('&');
                dataGridViewConsulta.Rows.Add(leer[0], leer[1], leer[2], leer[3], leer[4], leer[5], leer[6]);
            }
            archivo.Close();
        }
    }
}
