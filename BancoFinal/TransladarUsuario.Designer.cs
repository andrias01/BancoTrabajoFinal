﻿
namespace BancoFinal
{
    partial class TransladarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransladarUsuario));
            this.label4 = new System.Windows.Forms.Label();
            this.btnRetirarDinero = new System.Windows.Forms.Button();
            this.textBoxTransValorATransladar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTransladarSaldoActual = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textBoxTransPersonaRecibe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(26, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 72);
            this.label4.TabIndex = 47;
            this.label4.Text = "NOTA: Colocar el valor \r\na retirar sin puntos \r\ny sin signo de pesos ";
            // 
            // btnRetirarDinero
            // 
            this.btnRetirarDinero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetirarDinero.FlatAppearance.BorderSize = 0;
            this.btnRetirarDinero.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnRetirarDinero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetirarDinero.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetirarDinero.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnRetirarDinero.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRetirarDinero.Location = new System.Drawing.Point(298, 306);
            this.btnRetirarDinero.Name = "btnRetirarDinero";
            this.btnRetirarDinero.Size = new System.Drawing.Size(233, 62);
            this.btnRetirarDinero.TabIndex = 46;
            this.btnRetirarDinero.Text = "TRANSFERIR";
            this.btnRetirarDinero.UseVisualStyleBackColor = true;
            this.btnRetirarDinero.Click += new System.EventHandler(this.btnRetirarDinero_Click);
            // 
            // textBoxTransValorATransladar
            // 
            this.textBoxTransValorATransladar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxTransValorATransladar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTransValorATransladar.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTransValorATransladar.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxTransValorATransladar.Location = new System.Drawing.Point(270, 190);
            this.textBoxTransValorATransladar.Name = "textBoxTransValorATransladar";
            this.textBoxTransValorATransladar.Size = new System.Drawing.Size(263, 34);
            this.textBoxTransValorATransladar.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(26, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 24);
            this.label3.TabIndex = 44;
            this.label3.Text = "VALOR A TRANSLADAR : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(62, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 24);
            this.label2.TabIndex = 43;
            this.label2.Text = "SALDO ACTUAL";
            // 
            // textBoxTransladarSaldoActual
            // 
            this.textBoxTransladarSaldoActual.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxTransladarSaldoActual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTransladarSaldoActual.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTransladarSaldoActual.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxTransladarSaldoActual.Location = new System.Drawing.Point(231, 150);
            this.textBoxTransladarSaldoActual.Name = "textBoxTransladarSaldoActual";
            this.textBoxTransladarSaldoActual.ReadOnly = true;
            this.textBoxTransladarSaldoActual.Size = new System.Drawing.Size(263, 34);
            this.textBoxTransladarSaldoActual.TabIndex = 42;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(205, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(164, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 25);
            this.label1.TabIndex = 40;
            this.label1.Text = "CUANTO VAS A TRANSFERIR?";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(270, 214);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(263, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(268, 264);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(263, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 51;
            this.pictureBox3.TabStop = false;
            // 
            // textBoxTransPersonaRecibe
            // 
            this.textBoxTransPersonaRecibe.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxTransPersonaRecibe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTransPersonaRecibe.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTransPersonaRecibe.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxTransPersonaRecibe.Location = new System.Drawing.Point(268, 240);
            this.textBoxTransPersonaRecibe.Name = "textBoxTransPersonaRecibe";
            this.textBoxTransPersonaRecibe.Size = new System.Drawing.Size(263, 34);
            this.textBoxTransPersonaRecibe.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(11, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(266, 24);
            this.label5.TabIndex = 49;
            this.label5.Text = "PERSONA QUIEN RECIBE : ";
            // 
            // TransladarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(601, 400);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.textBoxTransPersonaRecibe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRetirarDinero);
            this.Controls.Add(this.textBoxTransValorATransladar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTransladarSaldoActual);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransladarUsuario";
            this.Text = "TransladarUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRetirarDinero;
        private System.Windows.Forms.TextBox textBoxTransValorATransladar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTransladarSaldoActual;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textBoxTransPersonaRecibe;
        private System.Windows.Forms.Label label5;
    }
}