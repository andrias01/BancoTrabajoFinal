
namespace BancoFinal
{
    partial class RetirarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RetirarUsuario));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRetirarValorARetirar = new System.Windows.Forms.TextBox();
            this.btnRetirarDinero = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelRetirarSaldoActual = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(165, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "CUANTO VAS A RETIRAR?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(206, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(63, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "SALDO ACTUAL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(75, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "VALOR A RETIRAR : ";
            // 
            // textBoxRetirarValorARetirar
            // 
            this.textBoxRetirarValorARetirar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxRetirarValorARetirar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRetirarValorARetirar.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRetirarValorARetirar.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxRetirarValorARetirar.Location = new System.Drawing.Point(312, 208);
            this.textBoxRetirarValorARetirar.Name = "textBoxRetirarValorARetirar";
            this.textBoxRetirarValorARetirar.Size = new System.Drawing.Size(263, 34);
            this.textBoxRetirarValorARetirar.TabIndex = 26;
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
            this.btnRetirarDinero.Location = new System.Drawing.Point(342, 276);
            this.btnRetirarDinero.Name = "btnRetirarDinero";
            this.btnRetirarDinero.Size = new System.Drawing.Size(192, 62);
            this.btnRetirarDinero.TabIndex = 38;
            this.btnRetirarDinero.Text = "RETIRAR";
            this.btnRetirarDinero.UseVisualStyleBackColor = true;
            this.btnRetirarDinero.Click += new System.EventHandler(this.btnRetirarDinero_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(27, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 72);
            this.label4.TabIndex = 39;
            this.label4.Text = "NOTA: Colocar el valor \r\na retirar sin puntos \r\ny sin signo de pesos ";
            // 
            // labelRetirarSaldoActual
            // 
            this.labelRetirarSaldoActual.AutoSize = true;
            this.labelRetirarSaldoActual.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRetirarSaldoActual.Location = new System.Drawing.Point(232, 128);
            this.labelRetirarSaldoActual.Name = "labelRetirarSaldoActual";
            this.labelRetirarSaldoActual.Size = new System.Drawing.Size(0, 36);
            this.labelRetirarSaldoActual.TabIndex = 40;
            // 
            // RetirarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(601, 400);
            this.Controls.Add(this.labelRetirarSaldoActual);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRetirarDinero);
            this.Controls.Add(this.textBoxRetirarValorARetirar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RetirarUsuario";
            this.Text = "ConsignarUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRetirarValorARetirar;
        private System.Windows.Forms.Button btnRetirarDinero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelRetirarSaldoActual;
    }
}