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
    public partial class CrearAdmin : Form
    {
        public CrearAdmin()
        {
            InitializeComponent();
        }
        public struct Cliente
        {
            public string codigo;
            public string nombre;
            public string apellido;
            public string direccion;
            public string telefono;
            public string email;
            public string saldo;

        }

        private void btnGuardarCrearAdmin_Click(object sender, EventArgs e)
        {
            if (textBoxClaveCreacion.Text == String.Empty || textBoxNombreCreacion.Text == String.Empty || textBoxApellidoCreacion.Text == String.Empty
                || textBoxDireccionCreacion.Text == String.Empty || textBoxTelefonoCreacion.Text == String.Empty || textBoxEmailCreacion.Text == String.Empty || textBoxSaldoCreacion.Text == String.Empty)
                MessageBox.Show("Debe Digitar todos los campos");
            else
            {
                Cliente cliente = new Cliente();
                cliente.codigo = textBoxClaveCreacion.Text;
                cliente.nombre = textBoxNombreCreacion.Text;
                cliente.apellido = textBoxApellidoCreacion.Text;
                cliente.direccion = textBoxDireccionCreacion.Text;
                cliente.telefono = textBoxTelefonoCreacion.Text;
                cliente.email = textBoxEmailCreacion.Text;
                cliente.saldo = textBoxSaldoCreacion.Text;
                //se define el nombre del archivo en el cual se almacenarán los datos del sistema
                string fileName = "clientes.txt";
                // esto inserta texto en un archivo existente, si el archivo no existe lo crea
                StreamWriter writer = File.AppendText(fileName);
                //escribe cada campo separado por el signo & de esta forma el split ayudará en la recuperación
                writer.WriteLine("{0}&{1}&{2}&{3}&{4}&{5}&{6}", cliente.codigo, cliente.nombre, cliente.apellido,
                    cliente.direccion, cliente.telefono, cliente.email, cliente.saldo);
                writer.Close();
                textBoxClaveCreacion.Clear();
                textBoxNombreCreacion.Clear();
                textBoxApellidoCreacion.Clear();
                textBoxDireccionCreacion.Clear();
                textBoxTelefonoCreacion.Clear();
                textBoxEmailCreacion.Clear();
                textBoxSaldoCreacion.Clear();
            }
        }

        private void CrearAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
