using SIGCeboModel.Entitys;

namespace SIGCeboDescktopAPP
{
	partial class frmCadastroUsuarioPesoa
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		public Pessoa Pessoa;
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.labelNome = new System.Windows.Forms.Label();
			this.radBtPesoaFisica = new System.Windows.Forms.RadioButton();
			this.labeltelefone = new System.Windows.Forms.Label();
			this.radbtPessoaJuridica = new System.Windows.Forms.RadioButton();
			this.labelcpf = new System.Windows.Forms.Label();
			this.labelcnpj = new System.Windows.Forms.Label();
			this.tbNome = new System.Windows.Forms.TextBox();
			this.tbTelefone = new System.Windows.Forms.TextBox();
			this.tbCpf = new System.Windows.Forms.TextBox();
			this.tbCnpj = new System.Windows.Forms.TextBox();
			this.labelRasaoSocial = new System.Windows.Forms.Label();
			this.tbRasaosocial = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoScroll = true;
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.78238F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.21762F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 555F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Controls.Add(this.labelNome, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.radBtPesoaFisica, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.labeltelefone, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.radbtPessoaJuridica, 2, 3);
			this.tableLayoutPanel1.Controls.Add(this.tbNome, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.tbTelefone, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.tbCpf, 2, 4);
			this.tableLayoutPanel1.Controls.Add(this.labelcpf, 1, 4);
			//this.tableLayoutPanel1.Controls.Add(this.labelcnpj, 1, 5);
			//this.tableLayoutPanel1.Controls.Add(this.tbCnpj, 2, 5);
			//this.tableLayoutPanel1.Controls.Add(this.labelRasaoSocial, 1, 6);
			//this.tableLayoutPanel1.Controls.Add(this.tbRasaosocial, 2, 6);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 8;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.9119F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0881F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(837, 450);
			this.tableLayoutPanel1.TabIndex = 0;
			this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
			// 
			// labelNome
			// 
			this.labelNome.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.labelNome.AutoSize = true;
			this.labelNome.Location = new System.Drawing.Point(217, 121);
			this.labelNome.Name = "labelNome";
			this.labelNome.Size = new System.Drawing.Size(41, 15);
			this.labelNome.TabIndex = 0;
			this.labelNome.Text = "nome:";
			this.labelNome.Click += new System.EventHandler(this.label1_Click);
			// 
			// radBtPesoaFisica
			// 
			this.radBtPesoaFisica.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.radBtPesoaFisica.AutoSize = true;
			this.radBtPesoaFisica.Location = new System.Drawing.Point(170, 238);
			this.radBtPesoaFisica.Name = "radBtPesoaFisica";
			this.radBtPesoaFisica.Size = new System.Drawing.Size(88, 64);
			this.radBtPesoaFisica.TabIndex = 4;
			this.radBtPesoaFisica.TabStop = true;
			this.radBtPesoaFisica.Text = "Pesoa Fisica";
			radBtPesoaFisica.Checked = true;
			this.radBtPesoaFisica.UseVisualStyleBackColor = true;
			this.radBtPesoaFisica.CheckedChanged += new System.EventHandler(this.radBtPesoaFisica_CheckedChanged);
			// 
			// labeltelefone
			// 
			this.labeltelefone.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.labeltelefone.AutoSize = true;
			this.labeltelefone.Location = new System.Drawing.Point(205, 190);
			this.labeltelefone.Name = "labeltelefone";
			this.labeltelefone.Size = new System.Drawing.Size(53, 15);
			this.labeltelefone.TabIndex = 7;
			this.labeltelefone.Text = "telefone:";
			// 
			// radbtPessoaJuridica
			// 
			this.radbtPessoaJuridica.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.radbtPessoaJuridica.AutoSize = true;
			this.radbtPessoaJuridica.Location = new System.Drawing.Point(264, 238);
			this.radbtPessoaJuridica.Name = "radbtPessoaJuridica";
			this.radbtPessoaJuridica.Size = new System.Drawing.Size(549, 64);
			this.radbtPessoaJuridica.TabIndex = 8;
			this.radbtPessoaJuridica.TabStop = true;
			this.radbtPessoaJuridica.Text = "Pesoa juridica";
			this.radbtPessoaJuridica.UseVisualStyleBackColor = true;
			this.radbtPessoaJuridica.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// labelcpf
			// 
			this.labelcpf.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.labelcpf.AutoSize = true;
			this.labelcpf.Location = new System.Drawing.Point(231, 320);
			this.labelcpf.Name = "labelcpf";
			this.labelcpf.Size = new System.Drawing.Size(27, 15);
			this.labelcpf.TabIndex = 9;
			this.labelcpf.Text = "cpf:";
			// 
			// labelcnpj
			// 
			this.labelcnpj.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.labelcnpj.AutoSize = true;
			this.labelcnpj.Location = new System.Drawing.Point(225, 372);
			this.labelcnpj.Name = "labelcnpj";
			this.labelcnpj.Size = new System.Drawing.Size(33, 15);
			this.labelcnpj.TabIndex = 10;
			this.labelcnpj.Text = "cnpj:";
			// 
			// tbNome
			// 
			this.tbNome.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tbNome.Location = new System.Drawing.Point(264, 117);
			this.tbNome.Name = "tbNome";
			this.tbNome.Size = new System.Drawing.Size(195, 23);
			this.tbNome.TabIndex = 14;
			// 
			// tbTelefone
			// 
			this.tbTelefone.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tbTelefone.Location = new System.Drawing.Point(264, 186);
			this.tbTelefone.Name = "tbTelefone";
			this.tbTelefone.Size = new System.Drawing.Size(195, 23);
			this.tbTelefone.TabIndex = 15;
			// 
			// tbCpf
			// 
			this.tbCpf.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tbCpf.Location = new System.Drawing.Point(264, 316);
			this.tbCpf.Name = "tbCpf";
			this.tbCpf.Size = new System.Drawing.Size(195, 23);
			this.tbCpf.TabIndex = 16;
			// 
			// tbCnpj
			// 
			this.tbCnpj.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tbCnpj.Location = new System.Drawing.Point(264, 368);
			this.tbCnpj.Name = "tbCnpj";
			this.tbCnpj.Size = new System.Drawing.Size(195, 23);
			this.tbCnpj.TabIndex = 17;
			// 
			// labelRasaoSocial
			// 
			this.labelRasaoSocial.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.labelRasaoSocial.AutoSize = true;
			this.labelRasaoSocial.Location = new System.Drawing.Point(183, 411);
			this.labelRasaoSocial.Name = "labelRasaoSocial";
			this.labelRasaoSocial.Size = new System.Drawing.Size(75, 15);
			this.labelRasaoSocial.TabIndex = 18;
			this.labelRasaoSocial.Text = "Rasao Social:";
			// 
			// tbRasaosocial
			// 
			this.tbRasaosocial.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tbRasaosocial.Location = new System.Drawing.Point(264, 412);
			this.tbRasaosocial.Name = "tbRasaosocial";
			this.tbRasaosocial.Size = new System.Drawing.Size(195, 23);
			this.tbRasaosocial.TabIndex = 19;
			// 
			// frmCadastroUsuarioPesoa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(837, 450);
			this.Controls.Add(this.tableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmCadastroUsuarioPesoa";
			this.Text = "frmCadastroUsuarioPesoa";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private TableLayoutPanel tableLayoutPanel1;
		private Label labelNome;
		private Label labeltelefone;
		private Label labelcpf;
		private Label labelcnpj;
		private Label labelRasaoSocial;
		private TextBox tbNome;
		private TextBox tbTelefone;
		private TextBox tbCpf;
		private TextBox tbCnpj;
		private TextBox tbRasaosocial;
		private RadioButton radBtPesoaFisica;
		private RadioButton radbtPessoaJuridica;
	}
}