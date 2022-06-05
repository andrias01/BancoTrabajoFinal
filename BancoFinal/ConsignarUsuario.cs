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
            try
            {
                string fileName = "clientes.txt";
                string fileUsuario = "UsuarioEnSesion.txt";
                string fileCopia = "Copia_Clientes.txt";
                StreamReader reader = File.OpenText(fileName);
                StreamReader reader2 = File.OpenText(fileUsuario);
                StreamWriter writer = File.AppendText(fileCopia);
                string Cliente = reader2.ReadLine();
                string ValorAConsignar = textBoxConsignar.Text;
                int ValorAConsignarNumero = int.Parse(ValorAConsignar);
                int band = 0;
                while (!reader.EndOfStream)
                {
                    string lineaActual = reader.ReadLine();
                    char[] separador = { '&' };
                    string[] datos = lineaActual.Split(separador);
                    if (datos[1] == Cliente)
                    {
                        int SaldoNumero = int.Parse(datos[6]);
                        int suma = SaldoNumero + ValorAConsignarNumero;
                        string sumaRealizada = suma.ToString();
                        band = 1;
                        writer.WriteLine(datos[0]+"&"+datos[1]+ "&" + datos[2]+ "&" + datos[3]+ "&" + datos[4]+ "&" + datos[5]+ "&"+sumaRealizada);
                    }
                    else
                    {
                        writer.WriteLine(lineaActual);
                    }
                }
                if (band == 0)
                {
                    MessageBox.Show("NO se puedo hacer la consignaciòn. intenta denuevo!");
                }
                else
                    textBoxConsignar.Clear();
                    MessageBox.Show("Consignaciòn REALIZADA");
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
