namespace FormLogin
{
    partial class primeiraFase
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
            this.tmrAnima = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAnim = new System.Windows.Forms.Label();
            this.lbResposta = new System.Windows.Forms.Label();
            this.txtResposta = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblVidas = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrAnima
            // 
            this.tmrAnima.Tick += new System.EventHandler(this.tmrAnima_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::FormLogin.Properties.Resources.Dialogo;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.lblAnim);
            this.panel2.Location = new System.Drawing.Point(12, 264);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(835, 111);
            this.panel2.TabIndex = 1;
            // 
            // lblAnim
            // 
            this.lblAnim.BackColor = System.Drawing.Color.Transparent;
            this.lblAnim.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnim.Location = new System.Drawing.Point(16, 10);
            this.lblAnim.Name = "lblAnim";
            this.lblAnim.Size = new System.Drawing.Size(795, 92);
            this.lblAnim.TabIndex = 0;
            this.lblAnim.Click += new System.EventHandler(this.lblAnim_Click);
            // 
            // lbResposta
            // 
            this.lbResposta.AutoSize = true;
            this.lbResposta.BackColor = System.Drawing.Color.Transparent;
            this.lbResposta.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResposta.ForeColor = System.Drawing.Color.White;
            this.lbResposta.Location = new System.Drawing.Point(576, 376);
            this.lbResposta.Name = "lbResposta";
            this.lbResposta.Size = new System.Drawing.Size(90, 19);
            this.lbResposta.TabIndex = 2;
            this.lbResposta.Text = "Resposta:";
            this.lbResposta.Visible = false;
            // 
            // txtResposta
            // 
            this.txtResposta.Location = new System.Drawing.Point(672, 377);
            this.txtResposta.Name = "txtResposta";
            this.txtResposta.Size = new System.Drawing.Size(100, 20);
            this.txtResposta.TabIndex = 3;
            this.txtResposta.Visible = false;
            this.txtResposta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtResposta_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::FormLogin.Properties.Resources.UrsoAzul2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(583, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 305);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::FormLogin.Properties.Resources.Vida;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(71, 61);
            this.panel3.TabIndex = 4;
            // 
            // lblVidas
            // 
            this.lblVidas.AutoSize = true;
            this.lblVidas.BackColor = System.Drawing.Color.Transparent;
            this.lblVidas.Font = new System.Drawing.Font("Papyrus", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVidas.Location = new System.Drawing.Point(86, 17);
            this.lblVidas.Name = "lblVidas";
            this.lblVidas.Size = new System.Drawing.Size(64, 51);
            this.lblVidas.TabIndex = 5;
            this.lblVidas.Text = "x 3";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = global::FormLogin.Properties.Resources.UrsoVermelho11;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(33, 79);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(271, 296);
            this.panel4.TabIndex = 6;
            // 
            // primeiraFase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FormLogin.Properties.Resources.EscadaCastelo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(859, 401);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lblVidas);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtResposta);
            this.Controls.Add(this.lbResposta);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "primeiraFase";
            this.Text = "primeiraFase";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.primeiraFase_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.primeiraFase_FormClosed);
            this.Load += new System.EventHandler(this.primeiraFase_Load);
            this.Shown += new System.EventHandler(this.primeiraFase_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.primeiraFase_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.primeiraFase_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.primeiraFase_KeyUp);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmrAnima;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAnim;
        private System.Windows.Forms.Label lbResposta;
        private System.Windows.Forms.TextBox txtResposta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblVidas;
        private System.Windows.Forms.Panel panel4;
    }
}