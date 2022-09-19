namespace pet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PanelLateral = new System.Windows.Forms.Panel();
            this.PanelCentral = new System.Windows.Forms.Panel();
            this.PanelTopo = new System.Windows.Forms.Panel();
            this.Cadastro = new System.Windows.Forms.Button();
            this.Atendimento = new System.Windows.Forms.Button();
            this.Financeiro = new System.Windows.Forms.Button();
            this.Inicio = new System.Windows.Forms.Button();
            this.PanelSelect = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.Carrossel1 = new System.Windows.Forms.Panel();
            this.PanelLateral.SuspendLayout();
            this.PanelTopo.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelLateral
            // 
            this.PanelLateral.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanelLateral.Controls.Add(this.Carrossel1);
            this.PanelLateral.Controls.Add(this.PanelSelect);
            this.PanelLateral.Controls.Add(this.Inicio);
            this.PanelLateral.Controls.Add(this.Financeiro);
            this.PanelLateral.Controls.Add(this.Atendimento);
            this.PanelLateral.Controls.Add(this.Cadastro);
            this.PanelLateral.Location = new System.Drawing.Point(0, 55);
            this.PanelLateral.Name = "PanelLateral";
            this.PanelLateral.Size = new System.Drawing.Size(288, 738);
            this.PanelLateral.TabIndex = 0;
            this.PanelLateral.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelLateral_Paint);
            // 
            // PanelCentral
            // 
            this.PanelCentral.BackColor = System.Drawing.Color.PeachPuff;
            this.PanelCentral.Location = new System.Drawing.Point(287, 58);
            this.PanelCentral.Name = "PanelCentral";
            this.PanelCentral.Size = new System.Drawing.Size(1132, 735);
            this.PanelCentral.TabIndex = 1;
            // 
            // PanelTopo
            // 
            this.PanelTopo.BackColor = System.Drawing.Color.LightCoral;
            this.PanelTopo.Controls.Add(this.btnMin);
            this.PanelTopo.Controls.Add(this.btnSair);
            this.PanelTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTopo.Location = new System.Drawing.Point(0, 0);
            this.PanelTopo.Name = "PanelTopo";
            this.PanelTopo.Size = new System.Drawing.Size(1419, 57);
            this.PanelTopo.TabIndex = 2;
            // 
            // Cadastro
            // 
            this.Cadastro.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Cadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cadastro.Location = new System.Drawing.Point(46, 281);
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.Size = new System.Drawing.Size(195, 68);
            this.Cadastro.TabIndex = 0;
            this.Cadastro.Text = "Cadastro Pet";
            this.Cadastro.UseVisualStyleBackColor = false;
            this.Cadastro.Click += new System.EventHandler(this.button1_Click);
            // 
            // Atendimento
            // 
            this.Atendimento.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Atendimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Atendimento.Location = new System.Drawing.Point(46, 376);
            this.Atendimento.Name = "Atendimento";
            this.Atendimento.Size = new System.Drawing.Size(195, 68);
            this.Atendimento.TabIndex = 1;
            this.Atendimento.Text = "Atendimentos";
            this.Atendimento.UseVisualStyleBackColor = false;
            this.Atendimento.Click += new System.EventHandler(this.Atendimento_Click);
            // 
            // Financeiro
            // 
            this.Financeiro.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Financeiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Financeiro.Location = new System.Drawing.Point(46, 467);
            this.Financeiro.Name = "Financeiro";
            this.Financeiro.Size = new System.Drawing.Size(195, 68);
            this.Financeiro.TabIndex = 2;
            this.Financeiro.Text = "Financeiro";
            this.Financeiro.UseVisualStyleBackColor = false;
            this.Financeiro.Click += new System.EventHandler(this.Financeiro_Click);
            // 
            // Inicio
            // 
            this.Inicio.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inicio.Location = new System.Drawing.Point(46, 183);
            this.Inicio.Name = "Inicio";
            this.Inicio.Size = new System.Drawing.Size(195, 68);
            this.Inicio.TabIndex = 3;
            this.Inicio.Text = "Inicio";
            this.Inicio.UseVisualStyleBackColor = false;
            this.Inicio.Click += new System.EventHandler(this.button4_Click);
            // 
            // PanelSelect
            // 
            this.PanelSelect.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.PanelSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelSelect.Location = new System.Drawing.Point(27, 183);
            this.PanelSelect.Name = "PanelSelect";
            this.PanelSelect.Size = new System.Drawing.Size(13, 68);
            this.PanelSelect.TabIndex = 0;
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.LightCoral;
            this.btnMin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMin.BackgroundImage")));
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Location = new System.Drawing.Point(1311, 9);
            this.btnMin.Margin = new System.Windows.Forms.Padding(0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(39, 36);
            this.btnMin.TabIndex = 1;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.BackColor = System.Drawing.Color.LightCoral;
            this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(1368, 9);
            this.btnSair.Margin = new System.Windows.Forms.Padding(0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(42, 36);
            this.btnSair.TabIndex = 0;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Carrossel1
            // 
            this.Carrossel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Carrossel1.BackgroundImage")));
            this.Carrossel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Carrossel1.Location = new System.Drawing.Point(46, 23);
            this.Carrossel1.Name = "Carrossel1";
            this.Carrossel1.Size = new System.Drawing.Size(195, 138);
            this.Carrossel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 792);
            this.Controls.Add(this.PanelCentral);
            this.Controls.Add(this.PanelLateral);
            this.Controls.Add(this.PanelTopo);
            this.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.PanelLateral.ResumeLayout(false);
            this.PanelTopo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLateral;
        private System.Windows.Forms.Button Inicio;
        private System.Windows.Forms.Button Financeiro;
        private System.Windows.Forms.Button Atendimento;
        private System.Windows.Forms.Button Cadastro;
        private System.Windows.Forms.Panel PanelCentral;
        private System.Windows.Forms.Panel PanelTopo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Panel PanelSelect;
        private System.Windows.Forms.Panel Carrossel1;
    }
}

