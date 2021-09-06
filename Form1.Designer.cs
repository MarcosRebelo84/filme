
namespace Locadora
{
    partial class FormLocadora
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
            this.Nome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbCategoria = new System.Windows.Forms.TextBox();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.tbAno = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tb = new System.Windows.Forms.Button();
            this.tbsalvar = new System.Windows.Forms.Button();
            this.dgLocadora = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgLocadora)).BeginInit();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(26, 19);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(38, 13);
            this.Nome.TabIndex = 0;
            this.Nome.Text = "Nome:";
            this.Nome.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Categoria:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(620, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ano:";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(70, 19);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(100, 20);
            this.tbNome.TabIndex = 4;
            // 
            // tbCategoria
            // 
            this.tbCategoria.Location = new System.Drawing.Point(278, 19);
            this.tbCategoria.Name = "tbCategoria";
            this.tbCategoria.Size = new System.Drawing.Size(100, 20);
            this.tbCategoria.TabIndex = 5;
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(475, 19);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(100, 20);
            this.tbDescricao.TabIndex = 6;
            // 
            // tbAno
            // 
            this.tbAno.Location = new System.Drawing.Point(655, 22);
            this.tbAno.Name = "tbAno";
            this.tbAno.Size = new System.Drawing.Size(100, 20);
            this.tbAno.TabIndex = 7;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(75, 77);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(75, 23);
            this.tb.TabIndex = 8;
            this.tb.Text = "Limpar";
            this.tb.UseVisualStyleBackColor = true;
            this.tb.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbsalvar
            // 
            this.tbsalvar.Location = new System.Drawing.Point(179, 77);
            this.tbsalvar.Name = "tbsalvar";
            this.tbsalvar.Size = new System.Drawing.Size(75, 23);
            this.tbsalvar.TabIndex = 9;
            this.tbsalvar.Text = "Salvar";
            this.tbsalvar.UseVisualStyleBackColor = true;
            this.tbsalvar.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgLocadora
            // 
            this.dgLocadora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLocadora.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colNome,
            this.colCategoria,
            this.colDescricao,
            this.colAno});
            this.dgLocadora.Location = new System.Drawing.Point(14, 160);
            this.dgLocadora.Name = "dgLocadora";
            this.dgLocadora.Size = new System.Drawing.Size(1013, 408);
            this.dgLocadora.TabIndex = 10;
            this.dgLocadora.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.Width = 30;
            // 
            // colNome
            // 
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.Width = 170;
            // 
            // colCategoria
            // 
            this.colCategoria.HeaderText = "Categoria";
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.Width = 150;
            // 
            // colDescricao
            // 
            this.colDescricao.HeaderText = "Descrição";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.Width = 300;
            // 
            // colAno
            // 
            this.colAno.HeaderText = "Ano";
            this.colAno.Name = "colAno";
            this.colAno.Width = 50;
            // 
            // FormLocadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 601);
            this.Controls.Add(this.dgLocadora);
            this.Controls.Add(this.tbsalvar);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.tbAno);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.tbCategoria);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nome);
            this.Name = "FormLocadora";
            this.Text = "Locadora";
            ((System.ComponentModel.ISupportInitialize)(this.dgLocadora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbCategoria;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.TextBox tbAno;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button tb;
        private System.Windows.Forms.Button tbsalvar;
        private System.Windows.Forms.DataGridView dgLocadora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAno;
    }
}

