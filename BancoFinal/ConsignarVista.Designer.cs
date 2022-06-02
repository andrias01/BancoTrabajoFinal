
namespace BancoFinal
{
    partial class ConsignarVista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsignarVista));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxConsignar = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnConsignarAccion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(144, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(140, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "CUANTO VAS A CONSIGNAR?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(36, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "VALOR = ";
            // 
            // textBoxConsignar
            // 
            this.textBoxConsignar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxConsignar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConsignar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConsignar.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxConsignar.Location = new System.Drawing.Point(144, 200);
            this.textBoxConsignar.Name = "textBoxConsignar";
            this.textBoxConsignar.Size = new System.Drawing.Size(263, 20);
            this.textBoxConsignar.TabIndex = 8;
            this.textBoxConsignar.Text = "CANTIDAD";
            this.textBoxConsignar.Enter += new System.EventHandler(this.textBoxConsignar_Enter);
            this.textBoxConsignar.Leave += new System.EventHandler(this.textBoxConsignar_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(144, 214);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(263, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // btnConsignarAccion
            // 
            this.btnConsignarAccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsignarAccion.FlatAppearance.BorderSize = 0;
            this.btnConsignarAccion.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnConsignarAccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsignarAccion.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsignarAccion.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnConsignarAccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsignarAccion.Location = new System.Drawing.Point(186, 278);
            this.btnConsignarAccion.Name = "btnConsignarAccion";
            this.btnConsignarAccion.Size = new System.Drawing.Size(199, 45);
            this.btnConsignarAccion.TabIndex = 10;
            this.btnConsignarAccion.Text = "CONSIGNAR";
            this.btnConsignarAccion.UseVisualStyleBackColor = true;
            // 
            // ConsignarVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(601, 400);
            this.Controls.Add(this.btnConsignarAccion);
            this.Controls.Add(this.textBoxConsignar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsignarVista";
            this.Text = "Consignar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxConsignar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnConsignarAccion;
    }
}