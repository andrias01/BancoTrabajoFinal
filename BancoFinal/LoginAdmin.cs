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
    public partial class LoginAdmin : Form
    {
        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void CerrarLoginAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxUsuarioAdmin_Enter(object sender, EventArgs e)
        {
            if (textBoxUsuarioAdmin.Text == "USUARIO")
            {
                textBoxUsuarioAdmin.Text = "";
                textBoxUsuarioAdmin.ForeColor = Color.LightGray;
            }
        }

        private void textBoxUsuarioAdmin_Leave(object sender, EventArgs e)
        {
            if (textBoxUsuarioAdmin.Text == "")
            {
                textBoxUsuarioAdmin.Text = "USUARIO";
                textBoxUsuarioAdmin.ForeColor = Color.DimGray;
            }
        }

        private void textBoxContraseñaAdmin_Enter(object sender, EventArgs e)
        {
            if (textBoxContraseñaAdmin.Text == "CONTRASEÑA")
            {
                textBoxContraseñaAdmin.Text = "";
                textBoxContraseñaAdmin.ForeColor = Color.LightGray;
                textBoxContraseñaAdmin.UseSystemPasswordChar = true;
            }
        }

        private void textBoxContraseñaAdmin_Leave(object sender, EventArgs e)
        {
            if (textBoxContraseñaAdmin.Text == "")
            {
                textBoxContraseñaAdmin.Text = "CONTRASEÑA";
                textBoxContraseñaAdmin.ForeColor = Color.DimGray;
                textBoxContraseñaAdmin.UseSystemPasswordChar = false;
            }
        }

        private void textBoxUsuarioAdmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAccederAdmin_Click(object sender, EventArgs e)
        {
            ZonaAdministrador formularioZonaAdmin = new ZonaAdministrador();
            try
            {
                TextReader InicioAdmin = new StreamReader(textBoxUsuarioAdmin.Text + ".txt");
                if (InicioAdmin.ReadLine() == textBoxContraseñaAdmin.Text)
                {
                    MessageBox.Show("Se inicio seciòn de ADMINISTRADOR");
                    formularioZonaAdmin.Show();
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show("No se pudo Iniciar seciòn");
                }
            }
            catch (Exception z)
            {
                MessageBox.Show("hubo un error" + z, "Error");
            }

        }

        private void OlvidadoContraseñaAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            ClientesSingleton ClaveAdmin = ClientesSingleton.Getinstancia();
            ClaveAdmin.Archivo("Admin.txt", null, null, null, null, null,null,"OlvidoAdmin",null);
            MessageBox.Show("Tiene como Clave de ADMINISTRADOR : "+ClaveAdmin.Clave,"Usuario Admin");
        }
    }
}
