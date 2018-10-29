namespace LocadoraMedievais
{
    partial class FrmAviso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAviso));
            this.lblAviso = new System.Windows.Forms.Label();
            this.pctUser = new System.Windows.Forms.PictureBox();
            this.pctValidated = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnProsseguir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctValidated)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.BackColor = System.Drawing.Color.Transparent;
            this.lblAviso.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblAviso.Location = new System.Drawing.Point(129, 46);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(41, 15);
            this.lblAviso.TabIndex = 0;
            this.lblAviso.Text = "label1";
            // 
            // pctUser
            // 
            this.pctUser.BackColor = System.Drawing.Color.Transparent;
            this.pctUser.Image = ((System.Drawing.Image)(resources.GetObject("pctUser.Image")));
            this.pctUser.Location = new System.Drawing.Point(25, 22);
            this.pctUser.Name = "pctUser";
            this.pctUser.Size = new System.Drawing.Size(101, 99);
            this.pctUser.TabIndex = 1;
            this.pctUser.TabStop = false;
            // 
            // pctValidated
            // 
            this.pctValidated.BackColor = System.Drawing.Color.Transparent;
            this.pctValidated.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pctValidated.Image = ((System.Drawing.Image)(resources.GetObject("pctValidated.Image")));
            this.pctValidated.Location = new System.Drawing.Point(28, 22);
            this.pctValidated.Name = "pctValidated";
            this.pctValidated.Size = new System.Drawing.Size(98, 98);
            this.pctValidated.TabIndex = 3;
            this.pctValidated.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(244, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = " Voltar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnProsseguir
            // 
            this.btnProsseguir.BackColor = System.Drawing.Color.Transparent;
            this.btnProsseguir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnProsseguir.Image = ((System.Drawing.Image)(resources.GetObject("btnProsseguir.Image")));
            this.btnProsseguir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProsseguir.Location = new System.Drawing.Point(132, 90);
            this.btnProsseguir.Name = "btnProsseguir";
            this.btnProsseguir.Size = new System.Drawing.Size(103, 30);
            this.btnProsseguir.TabIndex = 5;
            this.btnProsseguir.Text = "     Prosseguir";
            this.btnProsseguir.UseVisualStyleBackColor = false;
            this.btnProsseguir.Click += new System.EventHandler(this.btnProsseguir_Click);
            // 
            // FrmAviso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(399, 137);
            this.Controls.Add(this.btnProsseguir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pctValidated);
            this.Controls.Add(this.pctUser);
            this.Controls.Add(this.lblAviso);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAviso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAviso";
            ((System.ComponentModel.ISupportInitialize)(this.pctUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctValidated)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblAviso;
        public System.Windows.Forms.PictureBox pctUser;
        public System.Windows.Forms.PictureBox pctValidated;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btnProsseguir;
    }
}