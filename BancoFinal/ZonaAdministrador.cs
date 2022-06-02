using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoFinal
{
    public partial class ZonaAdministrador : Form
    {
        public ZonaAdministrador()
        {
            InitializeComponent();
        }

        private void CerrarZonaAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ArbrirConsignarenMenuZonaAdmin(object Formhijo)
        {
            if (this.panelinformacionZonaAdmin.Controls.Count > 0)
                this.panelinformacionZonaAdmin.Controls.RemoveAt(0);
            Form Fconsignar = Formhijo as Form;
            Fconsignar.TopLevel = false;
            Fconsignar.Dock = DockStyle.Fill;
            this.panelinformacionZonaAdmin.Controls.Add(Fconsignar);
            this.panelinformacionZonaAdmin.Tag = Fconsignar;
            Fconsignar.Show();
        }
        private void btnCosultarZonaAdmin_Click(object sender, EventArgs e)
        {
            ArbrirConsignarenMenuZonaAdmin(new ConsultarzonaAdminr());
        }

        private void btnCrearZonaAdmin_Click(object sender, EventArgs e)
        {
            ArbrirConsignarenMenuZonaAdmin(new CrearAdmin());
        }

        private void btnEliminarzonaAdmin_Click(object sender, EventArgs e)
        {
            ArbrirConsignarenMenuZonaAdmin(new EliminarAdmin());
        }

        private void btnSingout_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Se Cerro la seciòn");
        }
    }
}
