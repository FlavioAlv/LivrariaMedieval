namespace LocadoraMedievais
{
    partial class CatalogoLivro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogoLivro));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cadLivroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baseDadosDataSetGeral = new LocadoraMedievais.BaseDadosDataSetGeral();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.cad_LivroTableAdapter = new LocadoraMedievais.BaseDadosDataSetGeralTableAdapters.Cad_LivroTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnVoltarLiv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cadLivroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDadosDataSetGeral)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Linen;
            this.listBox1.DataSource = this.cadLivroBindingSource;
            this.listBox1.DisplayMember = "Titulo";
            this.listBox1.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(44, 89);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(163, 259);
            this.listBox1.TabIndex = 0;
            this.listBox1.ValueMember = "Titulo";
            // 
            // cadLivroBindingSource
            // 
            this.cadLivroBindingSource.DataMember = "Cad_Livro";
            this.cadLivroBindingSource.DataSource = this.baseDadosDataSetGeral;
            // 
            // baseDadosDataSetGeral
            // 
            this.baseDadosDataSetGeral.DataSetName = "BaseDadosDataSetGeral";
            this.baseDadosDataSetGeral.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.Linen;
            this.listBox2.DataSource = this.cadLivroBindingSource;
            this.listBox2.DisplayMember = "Autor";
            this.listBox2.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold);
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(206, 89);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 259);
            this.listBox2.TabIndex = 1;
            this.listBox2.ValueMember = "Autor";
            // 
            // listBox3
            // 
            this.listBox3.BackColor = System.Drawing.Color.Linen;
            this.listBox3.DataSource = this.cadLivroBindingSource;
            this.listBox3.DisplayMember = "Editora";
            this.listBox3.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold);
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 15;
            this.listBox3.Location = new System.Drawing.Point(325, 89);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(120, 259);
            this.listBox3.TabIndex = 2;
            this.listBox3.ValueMember = "Editora";
            // 
            // listBox4
            // 
            this.listBox4.BackColor = System.Drawing.Color.Linen;
            this.listBox4.DataSource = this.cadLivroBindingSource;
            this.listBox4.DisplayMember = "Classe";
            this.listBox4.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold);
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 15;
            this.listBox4.Location = new System.Drawing.Point(444, 89);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(120, 259);
            this.listBox4.TabIndex = 3;
            this.listBox4.ValueMember = "Classe";
            // 
            // cad_LivroTableAdapter
            // 
            this.cad_LivroTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(93, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Titulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(236, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Autor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(349, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Editora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(451, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Classificação";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(166, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(357, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "CATÁLOGO DE LIVROS CADASTRADOS ";
            // 
            // btnVoltarLiv
            // 
            this.btnVoltarLiv.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold);
            this.btnVoltarLiv.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltarLiv.Image")));
            this.btnVoltarLiv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltarLiv.Location = new System.Drawing.Point(466, 354);
            this.btnVoltarLiv.Name = "btnVoltarLiv";
            this.btnVoltarLiv.Size = new System.Drawing.Size(98, 30);
            this.btnVoltarLiv.TabIndex = 5;
            this.btnVoltarLiv.Text = "    Voltar";
            this.btnVoltarLiv.UseVisualStyleBackColor = true;
            this.btnVoltarLiv.Click += new System.EventHandler(this.btnVoltarLiv_Click);
            // 
            // CatalogoLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(615, 408);
            this.Controls.Add(this.btnVoltarLiv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CatalogoLivro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CatalogoLivro";
            this.Load += new System.EventHandler(this.CatalogoLivro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cadLivroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDadosDataSetGeral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private BaseDadosDataSetGeral baseDadosDataSetGeral;
        private System.Windows.Forms.BindingSource cadLivroBindingSource;
        private BaseDadosDataSetGeralTableAdapters.Cad_LivroTableAdapter cad_LivroTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnVoltarLiv;
    }
}