namespace FormLogin
{
    partial class faseFinal
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
            this.lblVidas = new System.Windows.Forms.Label();
            this.txtResposta = new System.Windows.Forms.TextBox();
            this.lbResposta = new System.Windows.Forms.Label();
            this.tmrAnima = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAnim = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVidas
            // 
            this.lblVidas.AutoSize = true;
            this.lblVidas.BackColor = System.Drawing.Color.Transparent;
            this.lblVidas.Font = new System.Drawing.Font("Papyrus", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVidas.Location = new System.Drawing.Point(86, 13);
            this.lblVidas.Name = "lblVidas";
            this.lblVidas.Size = new System.Drawing.Size(64, 51);
            this.lblVidas.TabIndex = 18;
            this.lblVidas.Text = "x 3";
            // 
            // txtResposta
            // 
            this.txtResposta.Location = new System.Drawing.Point(672, 373);
            this.txtResposta.Name = "txtResposta";
            this.txtResposta.Size = new System.Drawing.Size(100, 20);
            this.txtResposta.TabIndex = 16;
            this.txtResposta.Visible = false;
            this.txtResposta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtResposta_KeyDown);
            // 
            // lbResposta
            // 
            this.lbResposta.AutoSize = true;
            this.lbResposta.BackColor = System.Drawing.Color.Transparent;
            this.lbResposta.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResposta.ForeColor = System.Drawing.Color.White;
            this.lbResposta.Location = new System.Drawing.Point(576, 372);
            this.lbResposta.Name = "lbResposta";
            this.lbResposta.Size = new System.Drawing.Size(92, 25);
            this.lbResposta.TabIndex = 15;
            this.lbResposta.Text = "Resposta:";
            this.lbResposta.Visible = false;
            // 
            // tmrAnima
            // 
            this.tmrAnima.Tick += new System.EventHandler(this.tmrAnima_Tick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::FormLogin.Properties.Resources.Vida;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(12, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(71, 61);
            this.panel3.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::FormLogin.Properties.Resources.Dialogo;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.lblAnim);
            this.panel2.Location = new System.Drawing.Point(12, 260);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(835, 111);
            this.panel2.TabIndex = 14;
            // 
            // lblAnim
            // 
            this.lblAnim.BackColor = System.Drawing.Color.Transparent;
            this.lblAnim.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnim.Location = new System.Drawing.Point(16, 10);
            this.lblAnim.Name = "lblAnim";
            this.lblAnim.Size = new System.Drawing.Size(795, 102);
            this.lblAnim.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::FormLogin.Properties.Resources.Mago2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(108, -51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 450);
            this.panel1.TabIndex = 13;
            // 
            // faseFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FormLogin.Properties.Resources._34476833_959804484193046_1634323644123447296_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(859, 401);
            this.Controls.Add(this.lblVidas);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtResposta);
            this.Controls.Add(this.lbResposta);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "faseFinal";
            this.Text = "faseFinal";
            this.Load += new System.EventHandler(this.faseFinal_Load);
            this.Shown += new System.EventHandler(this.faseFinal_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.faseFinal_KeyDown);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVidas;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtResposta;
        private System.Windows.Forms.Label lbResposta;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAnim;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer tmrAnima;
    }
}