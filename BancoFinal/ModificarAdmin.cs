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
    public partial class ModificarAdmin : Form
    {
        public ModificarAdmin()
        {
            InitializeComponent();
        }

        private void btbBuscarDatosModificarClientes_Click(object sender, EventArgs e)
        {
            //este es el nombre del archivo que administra los clientes
            string fileName = "clientes.txt";
            //este es el nombre de un archivo de copia
            //string fileCopia = "copia_clientes.txt";
            // esto inserta texto en un archivo existente, si el archivo no existe lo crea
            //StreamWriter writer = File.AppendText(fileCopia);
            StreamReader reader = File.OpenText(fileName);
            string Cliente = textBoxModificarCliente.Text;
            int band = 0;
            while (!reader.EndOfStream)
            {
                string lineaActual = reader.ReadLine();
                string[] datos = lineaActual.Split('&');
                if (datos[0] == Cliente || datos[1] == Cliente || datos[2] == Cliente)
                {
                    band = 1;
                    dataGridViewModificar.Rows.Clear();
                    //StreamReader archivo = new StreamReader("clientes.txt");
                    string texto = lineaActual;
                    string[] leer = texto.Split('&');
                    dataGridViewModificar.Rows.Add(leer[0], leer[1], leer[2], leer[3], leer[4], leer[5], leer[6]);
                }
            }
            if (band == 0)
                MessageBox.Show("El cliente no se Encuentra en la Base de Datos");
            reader.Close();
        }

        private void btbGuardarDatosModificarClientes_Click(object sender, EventArgs e)
        {
            //este es el nombre del archivo que administra los clientes
            string fileName = "clientes.txt";
            //este es el nombre de un archivo de copia
            string fileCopia = "copia_clientes.txt";
            // esto inserta texto en un archivo existente, si el archivo no existe lo crea
            StreamWriter writer = File.AppendText(fileCopia);
            StreamReader reader = File.OpenText(fileName);
            string Cliente =textBoxModificarCliente.Text;
            int band = 0;
            while (!reader.EndOfStream)
            {
                string lineaActual = reader.ReadLine();
                string[] datos = lineaActual.Split('&');
                if (datos[0] == Cliente || datos[1] == Cliente || datos[2] == Cliente)
                {
                    band = 1;
                    MessageBox.Show("El cliente ha sido Modificado");
                    string clave, nombre, apellido, direccion, telefono, email, saldo;
                    clave = dataGridViewModificar.Rows[0].Cells[0].Value.ToString();
                    nombre = dataGridViewModificar.Rows[0].Cells[1].Value.ToString();
                    apellido = dataGridViewModificar.Rows[0].Cells[2].Value.ToString();
                    direccion = dataGridViewModificar.Rows[0].Cells[3].Value.ToString();
                    telefono = dataGridViewModificar.Rows[0].Cells[4].Value.ToString();
                    email = dataGridViewModificar.Rows[0].Cells[5].Value.ToString();
                    saldo = dataGridViewModificar.Rows[0].Cells[6].Value.ToString();
                    writer.WriteLine(clave + "&" + nombre + "&" + apellido + "&" + direccion + "&" + telefono + "&" + email + "&" + saldo);

                }
                else
                {
                    writer.WriteLine(lineaActual);
                }
            }
            if (band == 0)
                MessageBox.Show("El cliente no se Encuentra en la Base de Datos");
            writer.Close();
            reader.Close();
            File.Replace(fileCopia, fileName, null, true);
        }
    }
}
