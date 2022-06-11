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
            //string fileName = "clientes.txt";
            //string fileUsuario = "UsuarioEnSesion.txt";
            //StreamReader reader = File.OpenText(fileName);
            //StreamReader reader2 = File.OpenText(fileUsuario);
            //string Cliente = reader2.ReadLine();
            //while (!reader.EndOfStream)
            //{
            //    string lineaActual = reader.ReadLine();
            //    char[] separador = { '&' };
            //    string[] datos = lineaActual.Split(separador);
            //    if (datos[1] == Cliente)
            //    {
            //        textBoxTransladarSaldoActual.Text = datos[6];
            //    }
            //}
            //reader.Close();
            //reader2.Close();
        }

        private void btnRetirarDinero_Click(object sender, EventArgs e)
        {
            if (textBoxTransValorATransladar.Text == String.Empty || textBoxTransPersonaRecibe.Text == String.Empty)
                MessageBox.Show("Debe Digitar todos los campos");
            else
            {
                ClientesSingleton TransferirDinero = ClientesSingleton.Getinstancia();
                string fileName = "clientes.txt";
                string fileCopia = "Copia_Clientes.txt";
                string ValorATranferir = textBoxTransValorATransladar.Text;
                string PersonaAtransferir = textBoxTransPersonaRecibe.Text;
                TransferirDinero.DatosClienteActual(TransferirDinero.Nombre);
                TransferirDinero.Archivo(fileName, fileCopia, TransferirDinero.Nombre, null, ValorATranferir, ValorATranferir, PersonaAtransferir, null, null);
                try
                {
                    string fileName = "clientes.txt";
                    string fileUsuario = "UsuarioEnSesion.txt";
                    string fileCopia = "Copia_Clientes.txt";
                    StreamReader reader = File.OpenText(fileName);
                    StreamReader reader2 = File.OpenText(fileUsuario);
                    StreamWriter writer = File.AppendText(fileCopia);
                    string Cliente = reader2.ReadLine();
                    string ValorATranferir = textBoxTransValorATransladar.Text;
                    int ValorARerirarNumero = int.Parse(ValorATranferir);
                    string PersonaAtransferir = textBoxTransPersonaRecibe.Text;
                    int band = 0;
                    while (!reader.EndOfStream)
                    {
                        string lineaActual = reader.ReadLine();
                        char[] separador = { '&' };
                        string[] datos = lineaActual.Split(separador);
                        if (datos[1] == Cliente)
                        {
                            int SaldoNumero = int.Parse(datos[6]);
                            if (SaldoNumero > 0)
                            {
                                int suma = SaldoNumero - ValorARerirarNumero;
                                string sumaRealizada = suma.ToString();
                                band = 1;
                                writer.WriteLine(datos[0] + "&" + datos[1] + "&" + datos[2] + "&" + datos[3] + "&" + datos[4] + "&" + datos[5] + "&" + sumaRealizada);
                            }
                            else
                            {
                                writer.WriteLine(lineaActual);
                            }
                        }
                        else
                        {
                            writer.WriteLine(lineaActual);
                        }
                    }
                    if (band == 0)
                    {
                        MessageBox.Show("NO se puedo hacer el retiro no tienes saldo!");
                    }
                    else
                    {
                        textBoxTransValorATransladar.Clear();
                        textBoxTransPersonaRecibe.Clear();
                    }       
                    MessageBox.Show("Transferencia REALIZADA");
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
