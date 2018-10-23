namespace FormLogin
{
    partial class frmTeste
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
            this.tmTexto = new System.Windows.Forms.Timer(this.components);
            this.lblAnim = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tmTexto
            // 
            this.tmTexto.Tick += new System.EventHandler(this.tmTexto_Tick);
            // 
            // lblAnim
            // 
            this.lblAnim.AllowDrop = true;
            this.lblAnim.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnim.BackColor = System.Drawing.Color.Transparent;
            this.lblAnim.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblAnim.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnim.Location = new System.Drawing.Point(77, 44);
            this.lblAnim.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAnim.Name = "lblAnim";
            this.lblAnim.Size = new System.Drawing.Size(702, 317);
            this.lblAnim.TabIndex = 0;
            // 
            // frmTeste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::FormLogin.Properties.Resources.Pergaminho2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(859, 401);
            this.Controls.Add(this.lblAnim);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmTeste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "frmTeste";
            this.Load += new System.EventHandler(this.frmTeste_Load);
            this.Shown += new System.EventHandler(this.frmTeste_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTeste_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmTeste_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmTexto;
        private System.Windows.Forms.Label lblAnim;
    }
}