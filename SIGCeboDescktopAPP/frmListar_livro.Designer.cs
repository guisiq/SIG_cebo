namespace SIGCeboDescktopAPP
{
	partial class frmListar_livro
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Edicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sinopse = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Estoque = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Alterar = new System.Windows.Forms.DataGridViewButtonColumn();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titulo,
            this.Autor,
            this.Edicao,
            this.Sinopse,
            this.Estoque,
            this.Alterar});
			this.dataGridView1.Location = new System.Drawing.Point(12, 256);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 25;
			this.dataGridView1.Size = new System.Drawing.Size(715, 171);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// Titulo
			// 
			this.Titulo.HeaderText = "Titulo";
			this.Titulo.Name = "Titulo";
			this.Titulo.ReadOnly = true;
			// 
			// Autor
			// 
			this.Autor.HeaderText = "Autor";
			this.Autor.Name = "Autor";
			this.Autor.ReadOnly = true;
			// 
			// Edicao
			// 
			this.Edicao.HeaderText = "Edicao";
			this.Edicao.Name = "Edicao";
			this.Edicao.ReadOnly = true;
			// 
			// Sinopse
			// 
			this.Sinopse.HeaderText = "Sinopse";
			this.Sinopse.Name = "Sinopse";
			this.Sinopse.ReadOnly = true;
			// 
			// Estoque
			// 
			this.Estoque.HeaderText = "Estoque";
			this.Estoque.Name = "Estoque";
			this.Estoque.ReadOnly = true;
			// 
			// Alterar
			// 
			this.Alterar.HeaderText = "Alterar";
			this.Alterar.Name = "Alterar";
			this.Alterar.ReadOnly = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(192, 90);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "label1";
			// 
			// frmListar_livro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmListar_livro";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DataGridView dataGridView1;
		private DataGridViewTextBoxColumn Titulo;
		private DataGridViewTextBoxColumn Autor;
		private DataGridViewTextBoxColumn Edicao;
		private DataGridViewTextBoxColumn Sinopse;
		private DataGridViewButtonColumn Estoque;
		private DataGridViewButtonColumn Alterar;
		private Label label1;
	}
}