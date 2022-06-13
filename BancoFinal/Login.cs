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
            ClientesSingleton guardarDatosClienteSesion = ClientesSingleton.Getinstancia();
            string fileName = "clientes.txt";
            guardarDatosClienteSesion.Nombre = textBoxUsuario.Text;
            guardarDatosClienteSesion.Clave = textBoxContraseña.Text;
            guardarDatosClienteSesion.Archivo(fileName, null, guardarDatosClienteSesion.Nombre, textBoxContraseña.Text, null,null,null,null,null);
            guardarDatosClienteSesion.DatosClienteActual(guardarDatosClienteSesion.Nombre);
        }

        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            LoginAdmin fomularioAdmin = new LoginAdmin();
            fomularioAdmin.Show();
        }
        private void OlvidadoContraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (textBoxUsuario.Text == String.Empty)
                MessageBox.Show("Debe Digitar el nombre de usuario");
            else
            {
                ClientesSingleton olvidoSesion = ClientesSingleton.Getinstancia();
                olvidoSesion.Nombre = textBoxUsuario.Text;
                olvidoSesion.DatosClienteActual(olvidoSesion.Nombre);
                MessageBox.Show("Su clave es "+ olvidoSesion.Clave,"Esta es la contraseña de " + olvidoSesion.Nombre);
            }
            
        }
    }
}
