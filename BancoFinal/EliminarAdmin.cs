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
    public partial class EliminarAdmin : Form
    {
        public EliminarAdmin()
        {
            InitializeComponent();
        }

        private void btnGuardarCrearAdmin_Click(object sender, EventArgs e)
        {
            //este es el nombre del archivo que administra los clientes
            string fileName = "clientes.txt";
            //este es el nombre de un archivo de copia
            string fileCopia = "copia_clientes.txt";
            // esto inserta texto en un archivo existente, si el archivo no existe lo crea
            StreamWriter writer = File.AppendText(fileCopia);
            StreamReader reader = File.OpenText(fileName);
            string Cliente =textBoxEliminarCliente.Text;
            int band = 0;
            while (!reader.EndOfStream)
            {
                string lineaActual = reader.ReadLine();
                string[] datos = lineaActual.Split('&');
                if (datos[0] == Cliente|| datos[1] == Cliente || datos[2] == Cliente)
                {
                    band = 1;
                    MessageBox.Show("El cliente ha sido Borrado");
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
