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
            string fileName = "clientes.txt";
            string fileUsuario = "UsuarioEnSesion.txt";
            StreamReader reader = File.OpenText(fileName);
            StreamReader reader2 = File.OpenText(fileUsuario);
            string Cliente = reader2.ReadLine();
            while (!reader.EndOfStream)
            {
                string lineaActual = reader.ReadLine();
                char[] separador = { '&' };
                string[] datos = lineaActual.Split(separador);
                if (datos[1] == Cliente)
                {
                    textBoxClaveConsultaUsuario.Text = datos[0];
                    textBoxNombreConsultaUsuario.Text = datos[1];
                    textBoxApellidoConsultaUsuario.Text = datos[2];
                    textBoxDireccionConsultaUsuario.Text = datos[3];
                    textBoxTelefonoConsultaUsuario.Text = datos[4];
                    textBoxEmailConsultaUsuario.Text= datos[5];
                    textBoxSaldoConsultaUsuario.Text = datos[6];
                }
            }
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
                try
                {
                    string fileName = "clientes.txt";
                    string fileUsuario = "UsuarioEnSesion.txt";
                    string fileCopia = "Copia_Clientes.txt";
                    StreamReader reader = File.OpenText(fileName);
                    StreamReader reader2 = File.OpenText(fileUsuario);
                    StreamWriter writer = File.AppendText(fileCopia);
                    string Cliente = reader2.ReadLine();
                    int band = 0;
                    while (!reader.EndOfStream)
                    {
                        string lineaActual = reader.ReadLine();
                        char[] separador = { '&' };
                        string[] datos = lineaActual.Split(separador);
                        if (datos[1] == Cliente)
                        {

                            band = 1;
                            writer.WriteLine(cliente.codigo+"&"+cliente.nombre+"&"+cliente.apellido+"&"+cliente.direccion+"&"+cliente.telefono+"&"+cliente.email+"&"+cliente.saldo);
                        }
                        else
                        {
                            writer.WriteLine(lineaActual);
                        }
                    }
                    if (band == 0)
                    {
                        MessageBox.Show("NO se pudo hacer la actualización. intenta denuevo!");
                    }
                    
                    MessageBox.Show("Actualización REALIZADA");
                    reader.Close();
                    reader2.Close();
                    writer.Close();
                    File.Replace(fileCopia, fileName, null, true);
                }
                catch (Exception z)
                {
                    MessageBox.Show("hubo un error" + z, "Error");
                }
            }
            
        }
    }
}
