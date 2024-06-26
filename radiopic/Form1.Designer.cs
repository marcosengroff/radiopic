namespace radiopic
{
    partial class frmveiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmveiculos));
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.radCarros = new System.Windows.Forms.RadioButton();
            this.radMotos = new System.Windows.Forms.RadioButton();
            this.picLamborguine = new System.Windows.Forms.PictureBox();
            this.picCamaro = new System.Windows.Forms.PictureBox();
            this.radLamborguine = new System.Windows.Forms.RadioButton();
            this.radCamaro = new System.Windows.Forms.RadioButton();
            this.radBiz = new System.Windows.Forms.RadioButton();
            this.radPop = new System.Windows.Forms.RadioButton();
            this.picBiz = new System.Windows.Forms.PictureBox();
            this.picPop = new System.Windows.Forms.PictureBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLamborguine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamaro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBiz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPop)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(94, 337);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 0;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(278, 337);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // radCarros
            // 
            this.radCarros.AutoSize = true;
            this.radCarros.Location = new System.Drawing.Point(56, 29);
            this.radCarros.Name = "radCarros";
            this.radCarros.Size = new System.Drawing.Size(55, 17);
            this.radCarros.TabIndex = 99;
            this.radCarros.TabStop = true;
            this.radCarros.Text = "Carros";
            this.radCarros.UseVisualStyleBackColor = true;
            this.radCarros.CheckedChanged += new System.EventHandler(this.radCarros_CheckedChanged);
            // 
            // radMotos
            // 
            this.radMotos.AutoSize = true;
            this.radMotos.Location = new System.Drawing.Point(331, 40);
            this.radMotos.Name = "radMotos";
            this.radMotos.Size = new System.Drawing.Size(54, 17);
            this.radMotos.TabIndex = 98;
            this.radMotos.TabStop = true;
            this.radMotos.Text = "Motos";
            this.radMotos.UseVisualStyleBackColor = true;
            this.radMotos.CheckedChanged += new System.EventHandler(this.radMotos_CheckedChanged);
            // 
            // picLamborguine
            // 
            this.picLamborguine.Image = ((System.Drawing.Image)(resources.GetObject("picLamborguine.Image")));
            this.picLamborguine.Location = new System.Drawing.Point(12, 68);
            this.picLamborguine.Name = "picLamborguine";
            this.picLamborguine.Size = new System.Drawing.Size(152, 101);
            this.picLamborguine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLamborguine.TabIndex = 4;
            this.picLamborguine.TabStop = false;
            this.picLamborguine.Visible = false;
            // 
            // picCamaro
            // 
            this.picCamaro.Image = ((System.Drawing.Image)(resources.GetObject("picCamaro.Image")));
            this.picCamaro.Location = new System.Drawing.Point(12, 200);
            this.picCamaro.Name = "picCamaro";
            this.picCamaro.Size = new System.Drawing.Size(152, 94);
            this.picCamaro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCamaro.TabIndex = 5;
            this.picCamaro.TabStop = false;
            this.picCamaro.Visible = false;
            // 
            // radLamborguine
            // 
            this.radLamborguine.AutoSize = true;
            this.radLamborguine.Location = new System.Drawing.Point(186, 106);
            this.radLamborguine.Name = "radLamborguine";
            this.radLamborguine.Size = new System.Drawing.Size(86, 17);
            this.radLamborguine.TabIndex = 6;
            this.radLamborguine.TabStop = true;
            this.radLamborguine.Text = "Lamborguine";
            this.radLamborguine.UseVisualStyleBackColor = true;
            this.radLamborguine.Visible = false;
            this.radLamborguine.CheckedChanged += new System.EventHandler(this.radLamborguine_CheckedChanged);
            // 
            // radCamaro
            // 
            this.radCamaro.AutoSize = true;
            this.radCamaro.Location = new System.Drawing.Point(186, 240);
            this.radCamaro.Name = "radCamaro";
            this.radCamaro.Size = new System.Drawing.Size(61, 17);
            this.radCamaro.TabIndex = 7;
            this.radCamaro.TabStop = true;
            this.radCamaro.Text = "Camaro";
            this.radCamaro.UseVisualStyleBackColor = true;
            this.radCamaro.Visible = false;
            this.radCamaro.CheckedChanged += new System.EventHandler(this.radCamaro_CheckedChanged);
            // 
            // radBiz
            // 
            this.radBiz.AutoSize = true;
            this.radBiz.Location = new System.Drawing.Point(452, 240);
            this.radBiz.Name = "radBiz";
            this.radBiz.Size = new System.Drawing.Size(39, 17);
            this.radBiz.TabIndex = 11;
            this.radBiz.TabStop = true;
            this.radBiz.Text = "Biz";
            this.radBiz.UseVisualStyleBackColor = true;
            this.radBiz.Visible = false;
            this.radBiz.CheckedChanged += new System.EventHandler(this.radBiz_CheckedChanged);
            // 
            // radPop
            // 
            this.radPop.AutoSize = true;
            this.radPop.Location = new System.Drawing.Point(452, 106);
            this.radPop.Name = "radPop";
            this.radPop.Size = new System.Drawing.Size(44, 17);
            this.radPop.TabIndex = 10;
            this.radPop.TabStop = true;
            this.radPop.Text = "Pop";
            this.radPop.UseVisualStyleBackColor = true;
            this.radPop.Visible = false;
            this.radPop.CheckedChanged += new System.EventHandler(this.radPop_CheckedChanged);
            // 
            // picBiz
            // 
            this.picBiz.Image = ((System.Drawing.Image)(resources.GetObject("picBiz.Image")));
            this.picBiz.Location = new System.Drawing.Point(278, 200);
            this.picBiz.Name = "picBiz";
            this.picBiz.Size = new System.Drawing.Size(152, 94);
            this.picBiz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBiz.TabIndex = 9;
            this.picBiz.TabStop = false;
            this.picBiz.Visible = false;
            // 
            // picPop
            // 
            this.picPop.Image = ((System.Drawing.Image)(resources.GetObject("picPop.Image")));
            this.picPop.Location = new System.Drawing.Point(278, 68);
            this.picPop.Name = "picPop";
            this.picPop.Size = new System.Drawing.Size(152, 101);
            this.picPop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPop.TabIndex = 8;
            this.picPop.TabStop = false;
            this.picPop.Visible = false;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(12, 318);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(35, 13);
            this.lblMensagem.TabIndex = 100;
            this.lblMensagem.Text = "label1";
            this.lblMensagem.Visible = false;
            // 
            // frmveiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 372);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.radBiz);
            this.Controls.Add(this.radPop);
            this.Controls.Add(this.picBiz);
            this.Controls.Add(this.picPop);
            this.Controls.Add(this.radCamaro);
            this.Controls.Add(this.radLamborguine);
            this.Controls.Add(this.picCamaro);
            this.Controls.Add(this.picLamborguine);
            this.Controls.Add(this.radMotos);
            this.Controls.Add(this.radCarros);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Name = "frmveiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veículos";
            ((System.ComponentModel.ISupportInitialize)(this.picLamborguine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamaro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBiz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.RadioButton radCarros;
        private System.Windows.Forms.RadioButton radMotos;
        private System.Windows.Forms.PictureBox picLamborguine;
        private System.Windows.Forms.PictureBox picCamaro;
        private System.Windows.Forms.RadioButton radLamborguine;
        private System.Windows.Forms.RadioButton radCamaro;
        private System.Windows.Forms.RadioButton radBiz;
        private System.Windows.Forms.RadioButton radPop;
        private System.Windows.Forms.PictureBox picBiz;
        private System.Windows.Forms.PictureBox picPop;
        private System.Windows.Forms.Label lblMensagem;
    }
}

