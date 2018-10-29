namespace LocadoraMedievais
{
    partial class CatalogoLocacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogoLocacao));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabelaLocacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baseDadosDataSetGeral = new LocadoraMedievais.BaseDadosDataSetGeral();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.tabela_LocacaoTableAdapter = new LocadoraMedievais.BaseDadosDataSetGeralTableAdapters.Tabela_LocacaoTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnVoltarCat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaLocacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDadosDataSetGeral)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Linen;
            this.listBox1.DataSource = this.tabelaLocacaoBindingSource;
            this.listBox1.DisplayMember = "Nome_Usuario";
            this.listBox1.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(52, 89);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 199);
            this.listBox1.TabIndex = 0;
            this.listBox1.ValueMember = "Nome_Usuario";
            // 
            // tabelaLocacaoBindingSource
            // 
            this.tabelaLocacaoBindingSource.DataMember = "Tabela_Locacao";
            this.tabelaLocacaoBindingSource.DataSource = this.baseDadosDataSetGeral;
            // 
            // baseDadosDataSetGeral
            // 
            this.baseDadosDataSetGeral.DataSetName = "BaseDadosDataSetGeral";
            this.baseDadosDataSetGeral.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.Linen;
            this.listBox2.DataSource = this.tabelaLocacaoBindingSource;
            this.listBox2.DisplayMember = "Nome_Livro";
            this.listBox2.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold);
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(171, 89);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 199);
            this.listBox2.TabIndex = 1;
            this.listBox2.ValueMember = "Nome_Livro";
            // 
            // listBox3
            // 
            this.listBox3.BackColor = System.Drawing.Color.Linen;
            this.listBox3.DataSource = this.tabelaLocacaoBindingSource;
            this.listBox3.DisplayMember = "Autor_Livro";
            this.listBox3.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold);
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 15;
            this.listBox3.Location = new System.Drawing.Point(290, 89);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(120, 199);
            this.listBox3.TabIndex = 2;
            this.listBox3.ValueMember = "Autor_Livro";
            // 
            // listBox4
            // 
            this.listBox4.BackColor = System.Drawing.Color.Linen;
            this.listBox4.DataSource = this.tabelaLocacaoBindingSource;
            this.listBox4.DisplayMember = "Quantidade";
            this.listBox4.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold);
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 15;
            this.listBox4.Location = new System.Drawing.Point(409, 89);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(120, 199);
            this.listBox4.TabIndex = 3;
            this.listBox4.ValueMember = "Quantidade";
            // 
            // listBox5
            // 
            this.listBox5.BackColor = System.Drawing.Color.Linen;
            this.listBox5.DataSource = this.tabelaLocacaoBindingSource;
            this.listBox5.DisplayMember = "Classificacao";
            this.listBox5.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold);
            this.listBox5.FormattingEnabled = true;
            this.listBox5.ItemHeight = 15;
            this.listBox5.Location = new System.Drawing.Point(528, 89);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(120, 199);
            this.listBox5.TabIndex = 4;
            this.listBox5.ValueMember = "Classificacao";
            // 
            // tabela_LocacaoTableAdapter
            // 
            this.tabela_LocacaoTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(55, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(198, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Livro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(320, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Autor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(431, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quantidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(533, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Classificação";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(198, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(318, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "CATÁLOGO DE LIVROS ALUGADOS";
            // 
            // btnVoltarCat
            // 
            this.btnVoltarCat.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold);
            this.btnVoltarCat.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltarCat.Image")));
            this.btnVoltarCat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltarCat.Location = new System.Drawing.Point(550, 306);
            this.btnVoltarCat.Name = "btnVoltarCat";
            this.btnVoltarCat.Size = new System.Drawing.Size(98, 30);
            this.btnVoltarCat.TabIndex = 6;
            this.btnVoltarCat.Text = "    Voltar";
            this.btnVoltarCat.UseVisualStyleBackColor = true;
            this.btnVoltarCat.Click += new System.EventHandler(this.btnVoltarCat_Click);
            // 
            // CatalogoLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(702, 359);
            this.Controls.Add(this.btnVoltarCat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CatalogoLocacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CatalogoLocacao";
            this.Load += new System.EventHandler(this.CatalogoLocacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaLocacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDadosDataSetGeral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox5;
        private BaseDadosDataSetGeral baseDadosDataSetGeral;
        private System.Windows.Forms.BindingSource tabelaLocacaoBindingSource;
        private BaseDadosDataSetGeralTableAdapters.Tabela_LocacaoTableAdapter tabela_LocacaoTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnVoltarCat;
    }
}