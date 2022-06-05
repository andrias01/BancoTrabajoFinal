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
    public partial class ConsultarDatosUsuario : Form
    {
        public ConsultarDatosUsuario()
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
        private void btnActualizarInfoUsuario_Click(object sender, EventArgs e)
        {
            if (textBoxClaveConsultaUsuario.Text == String.Empty || textBoxNombreConsultaUsuario.Text == String.Empty || textBoxApellidoConsultaUsuario.Text == String.Empty
                || textBoxDireccionConsultaUsuario.Text == String.Empty || textBoxTelefonoConsultaUsuario.Text == String.Empty || textBoxEmailConsultaUsuario.Text == String.Empty || textBoxSaldoConsultaUsuario.Text == String.Empty)
                MessageBox.Show("Debe Digitar todos los campos");
            else
            {
                Cliente cliente = new Cliente();
                cliente.codigo = textBoxClaveConsultaUsuario.Text;
                cliente.nombre = textBoxNombreConsultaUsuario.Text;
                cliente.apellido = textBoxApellidoConsultaUsuario.Text;
                cliente.direccion = textBoxDireccionConsultaUsuario.Text;
                cliente.telefono = textBoxTelefonoConsultaUsuario.Text;
                cliente.email = textBoxEmailConsultaUsuario.Text;
                cliente.saldo = textBoxSaldoConsultaUsuario.Text;
                //se define el nombre del archivo en el cual se almacenarán los datos del sistema
                string fileName = "clientes.txt";
                // esto inserta texto en un archivo existente, si el archivo no existe lo crea
                StreamWriter writer = File.AppendText(fileName);
                //escribe cada campo separado por el signo & de esta forma el split ayudará en la recuperación
                writer.WriteLine("{0}&{1}&{2}&{3}&{4}&{5}&{6}", cliente.codigo, cliente.nombre, cliente.apellido,
                    cliente.direccion, cliente.telefono, cliente.email, cliente.saldo);
                writer.Close();
                //textBoxClaveCreacion.Clear();
                //textBoxNombreCreacion.Clear();
                //textBoxApellidoCreacion.Clear();
                //textBoxDireccionCreacion.Clear();
                //textBoxTelefonoCreacion.Clear();
                //textBoxEmailCreacion.Clear();
                //textBoxSaldoCreacion.Clear();
            }
        }
    }
}
