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
    public partial class menuInicial : Form
    {
        public menuInicial()
        {
            InitializeComponent();
            string fileName = "UsuarioEnSesion.txt";
            StreamReader reader = File.OpenText(fileName);
            string lineaActual = reader.ReadLine();
            textBoxUsuarioEnSesion.Text = lineaActual;
            reader.Close();
        }
        
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (PanelVertical.Width == 199)
            {
                PanelVertical.Width = 54;
            }
            else
                PanelVertical.Width = 199;
        }

        private void btncierremenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmaximenu_Click(object sender, EventArgs e)
        {
            //reacer
            this.WindowState = FormWindowState.Normal;
            btnmaximenu.Visible = false;
            btnReacermenu.Visible = true;
        }

        private void btnReacermenu_Click(object sender, EventArgs e)
        {
            //max
            this.WindowState = FormWindowState.Maximized;
            btnmaximenu.Visible = true;
            btnReacermenu.Visible = false;
        }

        private void btnminimenu_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PanelTitulo_Paint(object sender, PaintEventArgs e)
        {
        }

        private void PanelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ArbrirConsignarenMenu(object Formhijo)
        {
            if (this.InformacionPanel.Controls.Count>0)
                this.InformacionPanel.Controls.RemoveAt(0);
            Form Fconsignar = Formhijo as Form;
            Fconsignar.TopLevel = false;
            Fconsignar.Dock = DockStyle.Fill;
            this.InformacionPanel.Controls.Add(Fconsignar);
            this.InformacionPanel.Tag = Fconsignar;
            Fconsignar.Show();
        }
        private void btnConsignar_Click(object sender, EventArgs e)
        {
            ArbrirConsignarenMenu(new ConsignarUsuario());
        }

        private void btnsignOut_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Se Cerro la Sesiòn");
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ArbrirConsignarenMenu(new ConsultarDatosUsuario());
        }
    }
}
