
namespace BancoFinal
{
    partial class ConsultarzonaAdminr
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tituloCrear = new System.Windows.Forms.Label();
            this.dataGridViewConsulta = new System.Windows.Forms.DataGridView();
            this.btnConsultarClientes = new System.Windows.Forms.Button();
            this.ColClave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // tituloCrear
            // 
            this.tituloCrear.AutoSize = true;
            this.tituloCrear.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloCrear.Location = new System.Drawing.Point(98, 9);
            this.tituloCrear.Name = "tituloCrear";
            this.tituloCrear.Size = new System.Drawing.Size(287, 33);
            this.tituloCrear.TabIndex = 2;
            this.tituloCrear.Text = "CONSULTAR CLIENTES";
            // 
            // dataGridViewConsulta
            // 
            this.dataGridViewConsulta.AllowUserToAddRows = false;
            this.dataGridViewConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColClave,
            this.ColNombre,
            this.ColApellido,
            this.ColDireccion,
            this.ColTelefono,
            this.ColEmail,
            this.ColSaldo});
            this.dataGridViewConsulta.Location = new System.Drawing.Point(1, 55);
            this.dataGridViewConsulta.Name = "dataGridViewConsulta";
            this.dataGridViewConsulta.ReadOnly = true;
            this.dataGridViewConsulta.Size = new System.Drawing.Size(483, 207);
            this.dataGridViewConsulta.TabIndex = 3;
            // 
            // btnConsultarClientes
            // 
            this.btnConsultarClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarClientes.FlatAppearance.BorderSize = 0;
            this.btnConsultarClientes.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnConsultarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarClientes.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarClientes.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnConsultarClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarClientes.Location = new System.Drawing.Point(151, 268);
            this.btnConsultarClientes.Name = "btnConsultarClientes";
            this.btnConsultarClientes.Size = new System.Drawing.Size(176, 31);
            this.btnConsultarClientes.TabIndex = 24;
            this.btnConsultarClientes.Text = "CONSULTAR";
            this.btnConsultarClientes.UseVisualStyleBackColor = true;
            this.btnConsultarClientes.Click += new System.EventHandler(this.btnConsultarClientes_Click);
            // 
            // ColClave
            // 
            this.ColClave.HeaderText = "Clave";
            this.ColClave.Name = "ColClave";
            this.ColClave.ReadOnly = true;
            this.ColClave.Width = 50;
            // 
            // ColNombre
            // 
            this.ColNombre.HeaderText = "Nombre";
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.ReadOnly = true;
            this.ColNombre.Width = 55;
            // 
            // ColApellido
            // 
            this.ColApellido.HeaderText = "Apellido";
            this.ColApellido.Name = "ColApellido";
            this.ColApellido.ReadOnly = true;
            this.ColApellido.Width = 55;
            // 
            // ColDireccion
            // 
            this.ColDireccion.HeaderText = "Direcciòn";
            this.ColDireccion.Name = "ColDireccion";
            this.ColDireccion.ReadOnly = true;
            this.ColDireccion.Width = 80;
            // 
            // ColTelefono
            // 
            this.ColTelefono.HeaderText = "Telefono";
            this.ColTelefono.Name = "ColTelefono";
            this.ColTelefono.ReadOnly = true;
            this.ColTelefono.Width = 55;
            // 
            // ColEmail
            // 
            this.ColEmail.HeaderText = "Email";
            this.ColEmail.Name = "ColEmail";
            this.ColEmail.ReadOnly = true;
            this.ColEmail.Width = 75;
            // 
            // ColSaldo
            // 
            this.ColSaldo.HeaderText = "Saldo";
            this.ColSaldo.Name = "ColSaldo";
            this.ColSaldo.ReadOnly = true;
            this.ColSaldo.Width = 68;
            // 
            // ConsultarzonaAdminr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 311);
            this.Controls.Add(this.btnConsultarClientes);
            this.Controls.Add(this.dataGridViewConsulta);
            this.Controls.Add(this.tituloCrear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarzonaAdminr";
            this.Text = "ConsultarzonaAdminr";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloCrear;
        private System.Windows.Forms.DataGridView dataGridViewConsulta;
        private System.Windows.Forms.Button btnConsultarClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColClave;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSaldo;
    }
}