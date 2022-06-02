
namespace BancoFinal
{
    partial class LoginAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginAdmin));
            this.PanelLoginAdmin = new System.Windows.Forms.Panel();
            this.CerrarLoginAdmin = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OlvidadoContraseñaAdmin = new System.Windows.Forms.LinkLabel();
            this.btnAccederAdmin = new System.Windows.Forms.Button();
            this.textBoxContraseñaAdmin = new System.Windows.Forms.TextBox();
            this.textBoxUsuarioAdmin = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelLoginAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarLoginAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelLoginAdmin
            // 
            this.PanelLoginAdmin.BackColor = System.Drawing.SystemColors.Highlight;
            this.PanelLoginAdmin.Controls.Add(this.CerrarLoginAdmin);
            this.PanelLoginAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLoginAdmin.Location = new System.Drawing.Point(0, 0);
            this.PanelLoginAdmin.Name = "PanelLoginAdmin";
            this.PanelLoginAdmin.Size = new System.Drawing.Size(372, 38);
            this.PanelLoginAdmin.TabIndex = 0;
            // 
            // CerrarLoginAdmin
            // 
            this.CerrarLoginAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CerrarLoginAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CerrarLoginAdmin.Image = ((System.Drawing.Image)(resources.GetObject("CerrarLoginAdmin.Image")));
            this.CerrarLoginAdmin.Location = new System.Drawing.Point(344, 3);
            this.CerrarLoginAdmin.Name = "CerrarLoginAdmin";
            this.CerrarLoginAdmin.Size = new System.Drawing.Size(25, 25);
            this.CerrarLoginAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CerrarLoginAdmin.TabIndex = 5;
            this.CerrarLoginAdmin.TabStop = false;
            this.CerrarLoginAdmin.Click += new System.EventHandler(this.CerrarLoginAdmin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(66, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "LOGIN ADMINISTRADOR";
            // 
            // OlvidadoContraseñaAdmin
            // 
            this.OlvidadoContraseñaAdmin.ActiveLinkColor = System.Drawing.SystemColors.Highlight;
            this.OlvidadoContraseñaAdmin.AutoSize = true;
            this.OlvidadoContraseñaAdmin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OlvidadoContraseñaAdmin.LinkColor = System.Drawing.Color.DimGray;
            this.OlvidadoContraseñaAdmin.Location = new System.Drawing.Point(85, 315);
            this.OlvidadoContraseñaAdmin.Name = "OlvidadoContraseñaAdmin";
            this.OlvidadoContraseñaAdmin.Size = new System.Drawing.Size(198, 17);
            this.OlvidadoContraseñaAdmin.TabIndex = 13;
            this.OlvidadoContraseñaAdmin.TabStop = true;
            this.OlvidadoContraseñaAdmin.Text = "¿Ha olvidado la contraseña?";
            // 
            // btnAccederAdmin
            // 
            this.btnAccederAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAccederAdmin.FlatAppearance.BorderSize = 0;
            this.btnAccederAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAccederAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAccederAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccederAdmin.ForeColor = System.Drawing.Color.LightGray;
            this.btnAccederAdmin.Location = new System.Drawing.Point(55, 263);
            this.btnAccederAdmin.Name = "btnAccederAdmin";
            this.btnAccederAdmin.Size = new System.Drawing.Size(263, 40);
            this.btnAccederAdmin.TabIndex = 12;
            this.btnAccederAdmin.Text = "ACCEDER";
            this.btnAccederAdmin.UseVisualStyleBackColor = false;
            this.btnAccederAdmin.Click += new System.EventHandler(this.btnAccederAdmin_Click);
            // 
            // textBoxContraseñaAdmin
            // 
            this.textBoxContraseñaAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textBoxContraseñaAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxContraseñaAdmin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContraseñaAdmin.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxContraseñaAdmin.Location = new System.Drawing.Point(55, 190);
            this.textBoxContraseñaAdmin.Name = "textBoxContraseñaAdmin";
            this.textBoxContraseñaAdmin.Size = new System.Drawing.Size(263, 20);
            this.textBoxContraseñaAdmin.TabIndex = 10;
            this.textBoxContraseñaAdmin.Text = "CONTRASEÑA";
            this.textBoxContraseñaAdmin.Enter += new System.EventHandler(this.textBoxContraseñaAdmin_Enter);
            this.textBoxContraseñaAdmin.Leave += new System.EventHandler(this.textBoxContraseñaAdmin_Leave);
            // 
            // textBoxUsuarioAdmin
            // 
            this.textBoxUsuarioAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textBoxUsuarioAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsuarioAdmin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuarioAdmin.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxUsuarioAdmin.Location = new System.Drawing.Point(55, 139);
            this.textBoxUsuarioAdmin.Name = "textBoxUsuarioAdmin";
            this.textBoxUsuarioAdmin.Size = new System.Drawing.Size(263, 20);
            this.textBoxUsuarioAdmin.TabIndex = 8;
            this.textBoxUsuarioAdmin.Text = "USUARIO";
            this.textBoxUsuarioAdmin.TextChanged += new System.EventHandler(this.textBoxUsuarioAdmin_TextChanged);
            this.textBoxUsuarioAdmin.Enter += new System.EventHandler(this.textBoxUsuarioAdmin_Enter);
            this.textBoxUsuarioAdmin.Leave += new System.EventHandler(this.textBoxUsuarioAdmin_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(55, 203);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(263, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(55, 153);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // LoginAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(372, 354);
            this.Controls.Add(this.OlvidadoContraseñaAdmin);
            this.Controls.Add(this.btnAccederAdmin);
            this.Controls.Add(this.textBoxContraseñaAdmin);
            this.Controls.Add(this.textBoxUsuarioAdmin);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanelLoginAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginAdmin";
            this.Opacity = 0.9D;
            this.Text = "LoginAdmin";
            this.PanelLoginAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CerrarLoginAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelLoginAdmin;
        private System.Windows.Forms.PictureBox CerrarLoginAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel OlvidadoContraseñaAdmin;
        private System.Windows.Forms.Button btnAccederAdmin;
        private System.Windows.Forms.TextBox textBoxContraseñaAdmin;
        private System.Windows.Forms.TextBox textBoxUsuarioAdmin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}