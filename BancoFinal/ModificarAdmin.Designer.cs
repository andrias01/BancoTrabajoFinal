
namespace BancoFinal
{
    partial class ModificarAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarAdmin));
            this.tituloCrear = new System.Windows.Forms.Label();
            this.textBoxNombreCreacion = new System.Windows.Forms.TextBox();
            this.textBoxModificarCliente = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btbBuscarDatosModificarClientes = new System.Windows.Forms.Button();
            this.btbGuardarDatosModificarClientes = new System.Windows.Forms.Button();
            this.dataGridViewModificar = new System.Windows.Forms.DataGridView();
            this.ColClavee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColApellidoo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDireccionn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTelefonoo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmaill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSaldoo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModificar)).BeginInit();
            this.SuspendLayout();
            // 
            // tituloCrear
            // 
            this.tituloCrear.AutoSize = true;
            this.tituloCrear.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloCrear.Location = new System.Drawing.Point(98, -1);
            this.tituloCrear.Name = "tituloCrear";
            this.tituloCrear.Size = new System.Drawing.Size(284, 33);
            this.tituloCrear.TabIndex = 2;
            this.tituloCrear.Text = "MODIFICAR CLIENTES";
            // 
            // textBoxNombreCreacion
            // 
            this.textBoxNombreCreacion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxNombreCreacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNombreCreacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreCreacion.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxNombreCreacion.Location = new System.Drawing.Point(16, 93);
            this.textBoxNombreCreacion.Name = "textBoxNombreCreacion";
            this.textBoxNombreCreacion.Size = new System.Drawing.Size(263, 20);
            this.textBoxNombreCreacion.TabIndex = 17;
            // 
            // textBoxModificarCliente
            // 
            this.textBoxModificarCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxModificarCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxModificarCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxModificarCliente.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxModificarCliente.Location = new System.Drawing.Point(16, 67);
            this.textBoxModificarCliente.Name = "textBoxModificarCliente";
            this.textBoxModificarCliente.Size = new System.Drawing.Size(263, 20);
            this.textBoxModificarCliente.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "CLIENTE PARA MODIFICAR : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "NOTA : buscalo por nombre ";
            // 
            // btbBuscarDatosModificarClientes
            // 
            this.btbBuscarDatosModificarClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btbBuscarDatosModificarClientes.FlatAppearance.BorderSize = 0;
            this.btbBuscarDatosModificarClientes.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btbBuscarDatosModificarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbBuscarDatosModificarClientes.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbBuscarDatosModificarClientes.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btbBuscarDatosModificarClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btbBuscarDatosModificarClientes.Location = new System.Drawing.Point(285, 57);
            this.btbBuscarDatosModificarClientes.Name = "btbBuscarDatosModificarClientes";
            this.btbBuscarDatosModificarClientes.Size = new System.Drawing.Size(185, 38);
            this.btbBuscarDatosModificarClientes.TabIndex = 27;
            this.btbBuscarDatosModificarClientes.Text = "BUSCAR";
            this.btbBuscarDatosModificarClientes.UseVisualStyleBackColor = true;
            this.btbBuscarDatosModificarClientes.Click += new System.EventHandler(this.btbBuscarDatosModificarClientes_Click);
            // 
            // btbGuardarDatosModificarClientes
            // 
            this.btbGuardarDatosModificarClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btbGuardarDatosModificarClientes.FlatAppearance.BorderSize = 0;
            this.btbGuardarDatosModificarClientes.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btbGuardarDatosModificarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbGuardarDatosModificarClientes.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbGuardarDatosModificarClientes.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btbGuardarDatosModificarClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btbGuardarDatosModificarClientes.Location = new System.Drawing.Point(163, 210);
            this.btbGuardarDatosModificarClientes.Name = "btbGuardarDatosModificarClientes";
            this.btbGuardarDatosModificarClientes.Size = new System.Drawing.Size(176, 31);
            this.btbGuardarDatosModificarClientes.TabIndex = 28;
            this.btbGuardarDatosModificarClientes.Text = "GUARDAR";
            this.btbGuardarDatosModificarClientes.UseVisualStyleBackColor = true;
            this.btbGuardarDatosModificarClientes.Click += new System.EventHandler(this.btbGuardarDatosModificarClientes_Click);
            // 
            // dataGridViewModificar
            // 
            this.dataGridViewModificar.AllowUserToAddRows = false;
            this.dataGridViewModificar.AllowUserToDeleteRows = false;
            this.dataGridViewModificar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewModificar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColClavee,
            this.ColNombree,
            this.ColApellidoo,
            this.ColDireccionn,
            this.ColTelefonoo,
            this.ColEmaill,
            this.ColSaldoo});
            this.dataGridViewModificar.Location = new System.Drawing.Point(2, 133);
            this.dataGridViewModificar.Name = "dataGridViewModificar";
            this.dataGridViewModificar.Size = new System.Drawing.Size(481, 54);
            this.dataGridViewModificar.TabIndex = 30;
            // 
            // ColClavee
            // 
            this.ColClavee.HeaderText = "Clave";
            this.ColClavee.Name = "ColClavee";
            this.ColClavee.Width = 55;
            // 
            // ColNombree
            // 
            this.ColNombree.HeaderText = "Nombre";
            this.ColNombree.Name = "ColNombree";
            this.ColNombree.Width = 55;
            // 
            // ColApellidoo
            // 
            this.ColApellidoo.HeaderText = "Apellido";
            this.ColApellidoo.Name = "ColApellidoo";
            this.ColApellidoo.Width = 55;
            // 
            // ColDireccionn
            // 
            this.ColDireccionn.HeaderText = "Direcciòn";
            this.ColDireccionn.Name = "ColDireccionn";
            this.ColDireccionn.Width = 75;
            // 
            // ColTelefonoo
            // 
            this.ColTelefonoo.HeaderText = "Telefono";
            this.ColTelefonoo.Name = "ColTelefonoo";
            this.ColTelefonoo.Width = 60;
            // 
            // ColEmaill
            // 
            this.ColEmaill.HeaderText = "Email";
            this.ColEmaill.Name = "ColEmaill";
            this.ColEmaill.Width = 75;
            // 
            // ColSaldoo
            // 
            this.ColSaldoo.HeaderText = "Saldo";
            this.ColSaldoo.Name = "ColSaldoo";
            this.ColSaldoo.Width = 60;
            // 
            // ModificarAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(485, 311);
            this.Controls.Add(this.dataGridViewModificar);
            this.Controls.Add(this.btbGuardarDatosModificarClientes);
            this.Controls.Add(this.btbBuscarDatosModificarClientes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNombreCreacion);
            this.Controls.Add(this.textBoxModificarCliente);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tituloCrear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificarAdmin";
            this.Text = "ModificarAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModificar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloCrear;
        private System.Windows.Forms.TextBox textBoxNombreCreacion;
        private System.Windows.Forms.TextBox textBoxModificarCliente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btbBuscarDatosModificarClientes;
        private System.Windows.Forms.Button btbGuardarDatosModificarClientes;
        private System.Windows.Forms.DataGridView dataGridViewModificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColClavee;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombree;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColApellidoo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDireccionn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTelefonoo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmaill;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSaldoo;
    }
}