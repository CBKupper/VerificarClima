namespace VerificarClima
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.txbTemperatura = new System.Windows.Forms.TextBox();
            this.pibResultado = new System.Windows.Forms.PictureBox();
            this.lblData = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pibResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Location = new System.Drawing.Point(54, 82);
            this.lblTemperatura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(151, 19);
            this.lblTemperatura.TabIndex = 0;
            this.lblTemperatura.Text = "Digite a temperatura:";
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(193, 123);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(164, 63);
            this.btnVerificar.TabIndex = 1;
            this.btnVerificar.Text = "Verificar Clima";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // txbTemperatura
            // 
            this.txbTemperatura.Location = new System.Drawing.Point(212, 79);
            this.txbTemperatura.Name = "txbTemperatura";
            this.txbTemperatura.Size = new System.Drawing.Size(127, 27);
            this.txbTemperatura.TabIndex = 2;
            // 
            // pibResultado
            // 
            this.pibResultado.Location = new System.Drawing.Point(202, 215);
            this.pibResultado.Name = "pibResultado";
            this.pibResultado.Size = new System.Drawing.Size(137, 103);
            this.pibResultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibResultado.TabIndex = 5;
            this.pibResultado.TabStop = false;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(208, 356);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(0, 19);
            this.lblData.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(541, 499);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.pibResultado);
            this.Controls.Add(this.txbTemperatura);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.lblTemperatura);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = ":: Verificar clima ::";
            ((System.ComponentModel.ISupportInitialize)(this.pibResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.TextBox txbTemperatura;
        private System.Windows.Forms.PictureBox pibResultado;
        private System.Windows.Forms.Label lblData;
    }
}

