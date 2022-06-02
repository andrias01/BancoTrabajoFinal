
namespace BancoFinal
{
    partial class EliminarAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarAdmin));
            this.tituloCrear = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNombreCreacion = new System.Windows.Forms.TextBox();
            this.textBoxEliminarCliente = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tituloCrear
            // 
            this.tituloCrear.AutoSize = true;
            this.tituloCrear.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloCrear.Location = new System.Drawing.Point(128, 9);
            this.tituloCrear.Name = "tituloCrear";
            this.tituloCrear.Size = new System.Drawing.Size(239, 33);
            this.tituloCrear.TabIndex = 1;
            this.tituloCrear.Text = "ELIMINAR CLIENTE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "CLIENTE : ";
            // 
            // textBoxNombreCreacion
            // 
            this.textBoxNombreCreacion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxNombreCreacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNombreCreacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreCreacion.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxNombreCreacion.Location = new System.Drawing.Point(134, 85);
            this.textBoxNombreCreacion.Name = "textBoxNombreCreacion";
            this.textBoxNombreCreacion.Size = new System.Drawing.Size(263, 20);
            this.textBoxNombreCreacion.TabIndex = 13;
            // 
            // textBoxEliminarCliente
            // 
            this.textBoxEliminarCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxEliminarCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEliminarCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEliminarCliente.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxEliminarCliente.Location = new System.Drawing.Point(134, 59);
            this.textBoxEliminarCliente.Name = "textBoxEliminarCliente";
            this.textBoxEliminarCliente.Size = new System.Drawing.Size(263, 20);
            this.textBoxEliminarCliente.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(134, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarCliente.FlatAppearance.BorderSize = 0;
            this.btnEliminarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnEliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCliente.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCliente.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnEliminarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarCliente.Location = new System.Drawing.Point(152, 203);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(176, 31);
            this.btnEliminarCliente.TabIndex = 23;
            this.btnEliminarCliente.Text = "ELIMINAR";
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnGuardarCrearAdmin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 42);
            this.label2.TabIndex = 24;
            this.label2.Text = "NOTA : Puedes poner la CLAVE , NOMBRE\r\n o APELLIDO del usuario...";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EliminarAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(485, 311);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEliminarCliente);
            this.Controls.Add(this.textBoxNombreCreacion);
            this.Controls.Add(this.textBoxEliminarCliente);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tituloCrear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EliminarAdmin";
            this.Text = "EliminarAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloCrear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombreCreacion;
        private System.Windows.Forms.TextBox textBoxEliminarCliente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Label label2;
    }
}