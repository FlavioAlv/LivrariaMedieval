namespace LocadoraMedievais
{
    partial class CatalogoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogoCliente));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabelaUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baseDadosDataSetGeral = new LocadoraMedievais.BaseDadosDataSetGeral();
            this.ListboxSenha = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.tabela_UsuarioTableAdapter = new LocadoraMedievais.BaseDadosDataSetGeralTableAdapters.Tabela_UsuarioTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.btnVoltaCl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDadosDataSetGeral)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Linen;
            this.listBox1.DataSource = this.tabelaUsuarioBindingSource;
            this.listBox1.DisplayMember = "Nome";
            this.listBox1.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(53, 83);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(129, 274);
            this.listBox1.TabIndex = 0;
            this.listBox1.ValueMember = "Nome";
            // 
            // tabelaUsuarioBindingSource
            // 
            this.tabelaUsuarioBindingSource.DataMember = "Tabela_Usuario";
            this.tabelaUsuarioBindingSource.DataSource = this.baseDadosDataSetGeral;
            // 
            // baseDadosDataSetGeral
            // 
            this.baseDadosDataSetGeral.DataSetName = "BaseDadosDataSetGeral";
            this.baseDadosDataSetGeral.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ListboxSenha
            // 
            this.ListboxSenha.BackColor = System.Drawing.Color.Linen;
            this.ListboxSenha.DataSource = this.tabelaUsuarioBindingSource;
            this.ListboxSenha.DisplayMember = "Senha";
            this.ListboxSenha.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListboxSenha.FormattingEnabled = true;
            this.ListboxSenha.ItemHeight = 15;
            this.ListboxSenha.Location = new System.Drawing.Point(557, 83);
            this.ListboxSenha.MultiColumn = true;
            this.ListboxSenha.Name = "ListboxSenha";
            this.ListboxSenha.Size = new System.Drawing.Size(129, 274);
            this.ListboxSenha.TabIndex = 1;
            this.ListboxSenha.ValueMember = "Senha";
            // 
            // listBox3
            // 
            this.listBox3.BackColor = System.Drawing.Color.Linen;
            this.listBox3.DataSource = this.tabelaUsuarioBindingSource;
            this.listBox3.DisplayMember = "Telefone";
            this.listBox3.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 15;
            this.listBox3.Location = new System.Drawing.Point(179, 83);
            this.listBox3.MultiColumn = true;
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(129, 274);
            this.listBox3.TabIndex = 2;
            this.listBox3.ValueMember = "Telefone";
            // 
            // listBox4
            // 
            this.listBox4.BackColor = System.Drawing.Color.Linen;
            this.listBox4.DataSource = this.tabelaUsuarioBindingSource;
            this.listBox4.DisplayMember = "CPF";
            this.listBox4.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 15;
            this.listBox4.Location = new System.Drawing.Point(305, 83);
            this.listBox4.MultiColumn = true;
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(129, 274);
            this.listBox4.TabIndex = 3;
            this.listBox4.ValueMember = "CPF";
            // 
            // listBox5
            // 
            this.listBox5.BackColor = System.Drawing.Color.Linen;
            this.listBox5.DataSource = this.tabelaUsuarioBindingSource;
            this.listBox5.DisplayMember = "Usuario";
            this.listBox5.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox5.FormattingEnabled = true;
            this.listBox5.ItemHeight = 15;
            this.listBox5.Location = new System.Drawing.Point(431, 83);
            this.listBox5.MultiColumn = true;
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(129, 274);
            this.listBox5.TabIndex = 4;
            this.listBox5.ValueMember = "Usuario";
            // 
            // tabela_UsuarioTableAdapter
            // 
            this.tabela_UsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(340, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(456, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Usuário";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(584, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Senha";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Location = new System.Drawing.Point(639, 63);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(50, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Exibir";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(224, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(379, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "CATÁLOGO DE CLIENTES CADASTRADOS ";
            // 
            // btnVoltaCl
            // 
            this.btnVoltaCl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVoltaCl.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold);
            this.btnVoltaCl.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltaCl.Image")));
            this.btnVoltaCl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltaCl.Location = new System.Drawing.Point(588, 363);
            this.btnVoltaCl.Name = "btnVoltaCl";
            this.btnVoltaCl.Size = new System.Drawing.Size(98, 30);
            this.btnVoltaCl.TabIndex = 7;
            this.btnVoltaCl.Text = "     Voltar";
            this.btnVoltaCl.UseVisualStyleBackColor = true;
            this.btnVoltaCl.Click += new System.EventHandler(this.btnVoltarCl_Click);
            // 
            // CatalogoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(738, 421);
            this.Controls.Add(this.btnVoltaCl);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.ListboxSenha);
            this.Controls.Add(this.listBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CatalogoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo";
            this.Load += new System.EventHandler(this.Catalogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDadosDataSetGeral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox ListboxSenha;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox5;
        private BaseDadosDataSetGeral baseDadosDataSetGeral;
        private System.Windows.Forms.BindingSource tabelaUsuarioBindingSource;
        private BaseDadosDataSetGeralTableAdapters.Tabela_UsuarioTableAdapter tabela_UsuarioTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnVoltaCl;
    }
}