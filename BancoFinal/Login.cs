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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Maximizar.Visible = false;
            Restablecer.Visible = true;
        }

        private void Restablecer_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Maximizar.Visible = true;
            Restablecer.Visible = false;
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void textBoxUsuario_Enter(object sender, EventArgs e)
        {
            if (textBoxUsuario.Text == "USUARIO")
            {
                textBoxUsuario.Text = "";
                textBoxUsuario.ForeColor = Color.LightGray;
            }
        }

        private void textBoxUsuario_Leave(object sender, EventArgs e)
        {
            if (textBoxUsuario.Text == "")
            {
                textBoxUsuario.Text = "USUARIO";
                textBoxUsuario.ForeColor = Color.DimGray;
            }
        }

        private void textBoxContraseña_Enter(object sender, EventArgs e)
        {
            if (textBoxContraseña.Text == "CONTRASEÑA")
            {
                textBoxContraseña.Text = "";
                textBoxContraseña.ForeColor = Color.LightGray;
                textBoxContraseña.UseSystemPasswordChar = true;
            }
        }

        private void textBoxContraseña_Leave(object sender, EventArgs e)
        {
            if (textBoxContraseña.Text == "")
            {
                textBoxContraseña.Text = "CONTRASEÑA";
                textBoxContraseña.ForeColor = Color.DimGray;
                textBoxContraseña.UseSystemPasswordChar = false;
            }
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            ZonaAdministrador formularioUsuarios = new ZonaAdministrador();
            try
            {
                string fileName = "clientes.txt";
                string fileUsuario = "UsuarioEnSesion.txt";
                StreamReader reader = File.OpenText(fileName);
                StreamWriter writer = File.CreateText(fileUsuario);
                string Cliente = textBoxUsuario.Text;
                string Contraseña = textBoxContraseña.Text;
                int band = 0;
                while (!reader.EndOfStream)
                {
                    string lineaActual = reader.ReadLine();
                    char[] separador = {'&'};
                    string[] datos = lineaActual.Split(separador);
                    if (datos[0] == Contraseña && datos[1] == Cliente)
                    {
                        band = 1;
                        writer.WriteLine(datos[1]);
                        writer.Close();
                        menuInicial formulario2 = new menuInicial();
                        formulario2.Show();
                        MessageBox.Show($"Inicio SESION {0}",Cliente);
                    }
                }
                if (band==0)
                {
                    MessageBox.Show("NO se puede inciar secion tienes un error en el nombre o contraseña. intenta denuevo!");
                }
                reader.Close();
            }
            catch (Exception z)
            {
                MessageBox.Show("hubo un error" + z, "Error");
            }
            
        }

        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            LoginAdmin fomularioAdmin = new LoginAdmin();
            fomularioAdmin.Show();
        }
    }
}
