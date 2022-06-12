using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace BancoFinal
{
    class ClientesSingleton
    {
        private static ClientesSingleton ClaseInstanciada; //El lugar donde quedara la instancia
        public static ClientesSingleton Getinstancia()//Logica del singleton
        {
            if (ClaseInstanciada == null)//si no existe se crea la instancia
            {
                return ClaseInstanciada = new ClientesSingleton();//Se crea
            }
            else
                return ClaseInstanciada; //si ya esta creada solo sigue abierta
        }
        //Variables que para usar 
        private string clave;
        private string nombre;
        private string apellido;
        private string direccion;
        private string telefono;
        private string email;
        private int saldo;
        public void DatosClienteActual(string NOmbreUsuario)
        {
            string fileName = "clientes.txt";
            Archivo(fileName, null, NOmbreUsuario, null, null, null, null, null, null);
        }
        //Cada variable tentra un metodo que permitira tomar los datos y guardarlos
        public void entrarASecion(string NOmbre)
        {
            menuInicial formulario2 = new menuInicial();
            formulario2.Show();
            MessageBox.Show($"Inicio SESION {0}", NOmbre);
        }
        //Mensajes Sino se Cumple
        public void EliminarsiNO()
        {
            MessageBox.Show("El cliente no se Encuentra en la Base de Datos");
        }
        public void RerirarsiNO()
        {
            MessageBox.Show("NO se puede hacer el retiro no tienes suficiente Saldo!");
        }
        public void ConsignarsiNO()
        {
            MessageBox.Show("NO se puedo hacer la consignaciòn. intenta denuevo!");
        }
        public void entrarASecionsiNO()
        {
            MessageBox.Show("NO se puede inciar secion tienes un error en el nombre o contraseña. intenta denuevo!");
        }
        //Metodo Principal de lectura y escritura de archivos

    public void Archivo(string ARchivoClientes,string ARchivoCopia,string NOmbre, string COntraseña,string VAlorConsignar,string VAlorRerirar,string PErsonaAtranferir, string VAlorAcambiar,string hola4)
        {
            StreamReader reader = File.OpenText(ARchivoClientes);
            StreamWriter writer = null;
            int ValorAConsignarNumero = 0;
            int ValorARerirarNumero = 0;
            if (ARchivoCopia != null) writer = File.AppendText(ARchivoCopia);
            if (VAlorConsignar != null) ValorAConsignarNumero = int.Parse(VAlorConsignar);
            if (VAlorRerirar != null) ValorARerirarNumero = int.Parse(VAlorRerirar);
            try
            {
                string siNoCual = "";
                int band = 0;
                while (!reader.EndOfStream)
                {
                    string lineaActual = reader.ReadLine();
                    char[] separador = { '&' };
                    string[] datos = lineaActual.Split(separador);
                    if (datos[0] == COntraseña && datos[1] == NOmbre && writer == null && reader != null)
                    {
                        siNoCual = "Sesion";
                        band = 1;
                        entrarASecion(NOmbre);
                    }
                    if (datos[1] == NOmbre && writer == null)
                    {
                        clave = datos[0];
                        nombre = datos[1];
                        apellido = datos[2];
                        direccion = datos[3];
                        telefono = datos[4];
                        email = datos[5];
                        saldo = int.Parse(datos[6]);
                    }
                    if (writer != null && VAlorConsignar != null && VAlorRerirar == null)
                    {
                        if (datos[1] == NOmbre && writer != null && VAlorConsignar != null)
                        {
                            int SaldoNumero = int.Parse(datos[6]);
                            int suma = SaldoNumero + ValorAConsignarNumero;
                            string sumaRealizada = suma.ToString();
                            band = 1;
                            siNoCual = "Consignar";
                            writer.WriteLine(datos[0] + "&" + datos[1] + "&" + datos[2] + "&" + datos[3] + "&" + datos[4] + "&" + datos[5] + "&" + sumaRealizada);
                            MessageBox.Show("Consignaciòn REALIZADA");
                        }
                        else
                        {
                            writer.WriteLine(lineaActual);
                        }
                    }
                    if (writer != null && VAlorRerirar != null && VAlorConsignar == null)
                    {
                        int SaldoNumero = int.Parse(datos[6]);
                        if (SaldoNumero > 0)
                        {
                            if (datos[1] == NOmbre && writer != null && VAlorRerirar != null && SaldoNumero > 0)
                            {
                                int suma = SaldoNumero - ValorARerirarNumero;
                                if (suma<0)
                                {
                                    writer.WriteLine(lineaActual);
                                    siNoCual = "RetirarUsuario";
                                }
                                else
                                {
                                    string sumaRealizada = suma.ToString();
                                    band = 1;
                                    writer.WriteLine(datos[0] + "&" + datos[1] + "&" + datos[2] + "&" + datos[3] + "&" + datos[4] + "&" + datos[5] + "&" + sumaRealizada);
                                    MessageBox.Show("Retiro REALIZADO");
                                }
                            }
                            else writer.WriteLine(lineaActual);
                            siNoCual = "RetirarUsuario";
                        }
                    }
                    if (VAlorAcambiar == "ELIMINAR")
                    {
                        if (datos[0] == NOmbre || datos[1] == NOmbre || datos[2] == NOmbre)
                        {
                            band = 1;
                            MessageBox.Show("El cliente ha sido Borrado");
                        }
                        else
                        {
                            writer.WriteLine(lineaActual);
                        }
                        siNoCual = "Eliminar";
                    }
                }
                if (band == 0)
                {
                    if (siNoCual == "Eliminar") EliminarsiNO();
                    if (siNoCual == "Consignar") ConsignarsiNO();
                    if (siNoCual == "Sesion") entrarASecionsiNO();
                    if (siNoCual == "RetirarUsuario") RerirarsiNO();
                }
                reader.Close();
                if (ARchivoCopia != null)
                {
                    writer.Close();
                    File.Replace(ARchivoCopia, ARchivoClientes, null, true);
                }
            }
            catch (Exception z)
            {
                MessageBox.Show("hubo un error" + z, "Error");
            }
        }
        public string Clave
        {
            get { return clave; }
            set { this.clave = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { this.nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { this.apellido = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { this.direccion = value; }
        }     
        public string Telefono
        {
            get { return telefono; }
            set { this.telefono = value; }
        }
        public string Email 
        {
            get { return email; }
            set { this.email = value; }
        }
        public int Saldo
        {
            get { return saldo; }
            set { this.saldo = value; }
        }
    }
}
