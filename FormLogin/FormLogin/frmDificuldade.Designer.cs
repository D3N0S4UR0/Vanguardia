namespace FormLogin
{
    partial class frmDificuldade
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
            this.label1 = new System.Windows.Forms.Label();
            this.facil = new System.Windows.Forms.LinkLabel();
            this.medio = new System.Windows.Forms.LinkLabel();
            this.dificil = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Para começar a aventura, escolha a dificuldade: ";
            // 
            // facil
            // 
            this.facil.AutoSize = true;
            this.facil.BackColor = System.Drawing.Color.Transparent;
            this.facil.Font = new System.Drawing.Font("Papyrus", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facil.LinkArea = new System.Windows.Forms.LinkArea(0, 5);
            this.facil.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.facil.LinkColor = System.Drawing.Color.Black;
            this.facil.Location = new System.Drawing.Point(289, 109);
            this.facil.Name = "facil";
            this.facil.Size = new System.Drawing.Size(243, 58);
            this.facil.TabIndex = 1;
            this.facil.TabStop = true;
            this.facil.Text = "Fácil (8-9 anos)";
            this.facil.UseCompatibleTextRendering = true;
            this.facil.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFoiClicado);
            // 
            // medio
            // 
            this.medio.AutoSize = true;
            this.medio.BackColor = System.Drawing.Color.Transparent;
            this.medio.Font = new System.Drawing.Font("Papyrus", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medio.LinkArea = new System.Windows.Forms.LinkArea(0, 5);
            this.medio.LinkColor = System.Drawing.Color.Black;
            this.medio.Location = new System.Drawing.Point(268, 182);
            this.medio.Name = "medio";
            this.medio.Size = new System.Drawing.Size(256, 58);
            this.medio.TabIndex = 2;
            this.medio.TabStop = true;
            this.medio.Text = "Médio (10 anos)";
            this.medio.UseCompatibleTextRendering = true;
            this.medio.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFoiClicado);
            // 
            // dificil
            // 
            this.dificil.AutoSize = true;
            this.dificil.BackColor = System.Drawing.Color.Transparent;
            this.dificil.Font = new System.Drawing.Font("Papyrus", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dificil.LinkArea = new System.Windows.Forms.LinkArea(0, 7);
            this.dificil.LinkColor = System.Drawing.Color.Black;
            this.dificil.Location = new System.Drawing.Point(268, 273);
            this.dificil.Name = "dificil";
            this.dificil.Size = new System.Drawing.Size(300, 58);
            this.dificil.TabIndex = 3;
            this.dificil.TabStop = true;
            this.dificil.Text = "Difícil (11-12 anos)";
            this.dificil.UseCompatibleTextRendering = true;
            this.dificil.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFoiClicado);
            // 
            // frmDificuldade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FormLogin.Properties.Resources.Pergaminho2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(859, 401);
            this.Controls.Add(this.dificil);
            this.Controls.Add(this.medio);
            this.Controls.Add(this.facil);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDificuldade";
            this.Text = "frmDificuldade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel facil;
        private System.Windows.Forms.LinkLabel medio;
        private System.Windows.Forms.LinkLabel dificil;
    }
}