
namespace BancoFinal
{
    partial class ConsignarUsuario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsignarUsuario));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxConsignar = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnConsignarAccion = new System.Windows.Forms.Button();
            this.labelHora = new System.Windows.Forms.Label();
            this.labelMinutos = new System.Windows.Forms.Label();
            this.labelSegundos = new System.Windows.Forms.Label();
            this.labelDia = new System.Windows.Forms.Label();
            this.labelMes = new System.Windows.Forms.Label();
            this.labelAño = new System.Windows.Forms.Label();
            this.HoraFecha = new System.Windows.Forms.Timer(this.components);
            this.labelTextoTiempo = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
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
            this.textBoxConsignar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConsignar.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxConsignar.Location = new System.Drawing.Point(144, 200);
            this.textBoxConsignar.Name = "textBoxConsignar";
            this.textBoxConsignar.Size = new System.Drawing.Size(263, 26);
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
            this.btnConsignarAccion.Click += new System.EventHandler(this.btnConsignarAccion_Click);
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelHora.Location = new System.Drawing.Point(663, 45);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(0, 41);
            this.labelHora.TabIndex = 12;
            // 
            // labelMinutos
            // 
            this.labelMinutos.AutoSize = true;
            this.labelMinutos.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinutos.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelMinutos.Location = new System.Drawing.Point(663, 86);
            this.labelMinutos.Name = "labelMinutos";
            this.labelMinutos.Size = new System.Drawing.Size(0, 41);
            this.labelMinutos.TabIndex = 13;
            // 
            // labelSegundos
            // 
            this.labelSegundos.AutoSize = true;
            this.labelSegundos.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSegundos.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelSegundos.Location = new System.Drawing.Point(663, 127);
            this.labelSegundos.Name = "labelSegundos";
            this.labelSegundos.Size = new System.Drawing.Size(0, 41);
            this.labelSegundos.TabIndex = 14;
            // 
            // labelDia
            // 
            this.labelDia.AutoSize = true;
            this.labelDia.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDia.ForeColor = System.Drawing.Color.DimGray;
            this.labelDia.Location = new System.Drawing.Point(633, 231);
            this.labelDia.Name = "labelDia";
            this.labelDia.Size = new System.Drawing.Size(0, 28);
            this.labelDia.TabIndex = 15;
            // 
            // labelMes
            // 
            this.labelMes.AutoSize = true;
            this.labelMes.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMes.ForeColor = System.Drawing.Color.DimGray;
            this.labelMes.Location = new System.Drawing.Point(651, 268);
            this.labelMes.Name = "labelMes";
            this.labelMes.Size = new System.Drawing.Size(0, 28);
            this.labelMes.TabIndex = 16;
            // 
            // labelAño
            // 
            this.labelAño.AutoSize = true;
            this.labelAño.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAño.ForeColor = System.Drawing.Color.DimGray;
            this.labelAño.Location = new System.Drawing.Point(651, 306);
            this.labelAño.Name = "labelAño";
            this.labelAño.Size = new System.Drawing.Size(0, 28);
            this.labelAño.TabIndex = 17;
            // 
            // HoraFecha
            // 
            this.HoraFecha.Enabled = true;
            this.HoraFecha.Tick += new System.EventHandler(this.HoraFecha_Tick);
            // 
            // labelTextoTiempo
            // 
            this.labelTextoTiempo.AutoSize = true;
            this.labelTextoTiempo.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextoTiempo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelTextoTiempo.Location = new System.Drawing.Point(631, 4);
            this.labelTextoTiempo.Name = "labelTextoTiempo";
            this.labelTextoTiempo.Size = new System.Drawing.Size(117, 41);
            this.labelTextoTiempo.TabIndex = 18;
            this.labelTextoTiempo.Text = "HORA";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.ForeColor = System.Drawing.Color.DimGray;
            this.labelFecha.Location = new System.Drawing.Point(646, 194);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(101, 32);
            this.labelFecha.TabIndex = 19;
            this.labelFecha.Text = "FECHA";
            // 
            // ConsignarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(760, 400);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelTextoTiempo);
            this.Controls.Add(this.labelAño);
            this.Controls.Add(this.labelMes);
            this.Controls.Add(this.labelDia);
            this.Controls.Add(this.labelSegundos);
            this.Controls.Add(this.labelMinutos);
            this.Controls.Add(this.labelHora);
            this.Controls.Add(this.btnConsignarAccion);
            this.Controls.Add(this.textBoxConsignar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsignarUsuario";
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
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Label labelMinutos;
        private System.Windows.Forms.Label labelSegundos;
        private System.Windows.Forms.Label labelDia;
        private System.Windows.Forms.Label labelMes;
        private System.Windows.Forms.Label labelAño;
        private System.Windows.Forms.Timer HoraFecha;
        private System.Windows.Forms.Label labelTextoTiempo;
        private System.Windows.Forms.Label labelFecha;
    }
}