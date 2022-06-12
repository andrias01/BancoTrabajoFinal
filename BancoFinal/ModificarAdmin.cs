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
            LectorArchivo("BUscar", "clientes.txt",null);
        }
        private void btbGuardarDatosModificarClientes_Click(object sender, EventArgs e)
        {
            LectorArchivo("MOdificar", "clientes.txt", "copia_clientes.txt");           
        }
        public void LectorArchivo (string buscar,string archivo, string copia)
        {
            string nombre = textBoxModificarCliente.Text;
            StreamReader reader = File.OpenText(archivo);
            StreamWriter writer = null;
            if (copia != null) writer = File.AppendText(copia);
            int band = 0;
            while (!reader.EndOfStream)
            {
                string lineaActual = reader.ReadLine();
                string[] datos = lineaActual.Split('&');
                if (buscar == "BUscar" && copia == null)
                {
                    if (datos[0] == nombre || datos[1] == nombre || datos[2] == nombre)
                    {
                        band = 1;
                        dataGridViewModificar.Rows.Clear();
                        string texto = lineaActual;
                        string[] leer = texto.Split('&');
                        dataGridViewModificar.Rows.Add(leer[0], leer[1], leer[2], leer[3], leer[4], leer[5], leer[6]);
                    }
                }
                    
                if (buscar == "MOdificar" && copia != null)
                {
                    if (datos[0] == nombre || datos[1] == nombre || datos[2] == nombre)
                    {
                        band = 1;
                        MessageBox.Show("El cliente ha sido Modificado");
                        string clave, nombree, apellido, direccion, telefono, email, saldo;
                        clave = dataGridViewModificar.Rows[0].Cells[0].Value.ToString();
                        nombree = dataGridViewModificar.Rows[0].Cells[1].Value.ToString();
                        apellido = dataGridViewModificar.Rows[0].Cells[2].Value.ToString();
                        direccion = dataGridViewModificar.Rows[0].Cells[3].Value.ToString();
                        telefono = dataGridViewModificar.Rows[0].Cells[4].Value.ToString();
                        email = dataGridViewModificar.Rows[0].Cells[5].Value.ToString();
                        saldo = dataGridViewModificar.Rows[0].Cells[6].Value.ToString();
                        writer.WriteLine(clave + "&" + nombree + "&" + apellido + "&" + direccion + "&" + telefono + "&" + email + "&" + saldo);
                    }
                    else
                    {
                        writer.WriteLine(lineaActual);
                    }
                }
            }
            if (band == 0)
                if (buscar == "BUscar") Sino("BUscar");
                else Sino("MOdificar");
            reader.Close();
            if (copia != null)
            {
                writer.Close();
                File.Replace(copia, archivo, null, true);
            }
            
        }
        public void Sino(string sinoQue)
        {
            if (sinoQue == "BUscar") MessageBox.Show("El cliente no se Encuentra en la Base de Datos");
            if (sinoQue == "MOdificar") MessageBox.Show("No se pudo modificar");
        }
    }
}
