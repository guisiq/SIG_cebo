namespace SIGCeboDescktopAPP
{
	partial class FrmLogin: Form
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.LabelUsuario = new System.Windows.Forms.Label();
			this.LabelSenha = new System.Windows.Forms.Label();
			this.textBoxUsuario = new System.Windows.Forms.TextBox();
			this.textBoxSenha = new System.Windows.Forms.TextBox();
			this.btnLogar = new System.Windows.Forms.Button();
			this.btnCadastrar = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.42616F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.57384F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.Controls.Add(this.LabelUsuario, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.LabelSenha, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.textBoxUsuario, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.textBoxSenha, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.btnLogar, 2, 3);
			this.tableLayoutPanel1.Controls.Add(this.btnCadastrar, 2, 4);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 6;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.8009F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.1991F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 115F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// LabelUsuario
			// 
			this.LabelUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LabelUsuario.AutoSize = true;
			this.LabelUsuario.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelUsuario.Location = new System.Drawing.Point(203, 128);
			this.LabelUsuario.Name = "LabelUsuario";
			this.LabelUsuario.Size = new System.Drawing.Size(213, 72);
			this.LabelUsuario.TabIndex = 0;
			this.LabelUsuario.Text = "Usuario:";
			this.LabelUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LabelSenha
			// 
			this.LabelSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LabelSenha.AutoSize = true;
			this.LabelSenha.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelSenha.Location = new System.Drawing.Point(203, 200);
			this.LabelSenha.Name = "LabelSenha";
			this.LabelSenha.Size = new System.Drawing.Size(213, 59);
			this.LabelSenha.TabIndex = 1;
			this.LabelSenha.Text = "Senha:";
			this.LabelSenha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxUsuario
			// 
			this.textBoxUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.textBoxUsuario.Location = new System.Drawing.Point(422, 131);
			this.textBoxUsuario.Name = "textBoxUsuario";
			this.textBoxUsuario.Size = new System.Drawing.Size(174, 23);
			this.textBoxUsuario.TabIndex = 2;
			// 
			// textBoxSenha
			// 
			this.textBoxSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.textBoxSenha.Location = new System.Drawing.Point(422, 203);
			this.textBoxSenha.Name = "textBoxSenha";
			this.textBoxSenha.Size = new System.Drawing.Size(174, 23);
			this.textBoxSenha.TabIndex = 3;
			// 
			// btnLogar
			// 
			this.btnLogar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.btnLogar.Location = new System.Drawing.Point(471, 262);
			this.btnLogar.Name = "btnLogar";
			this.btnLogar.Size = new System.Drawing.Size(75, 31);
			this.btnLogar.TabIndex = 4;
			this.btnLogar.Text = "logar";
			this.btnLogar.UseVisualStyleBackColor = true;
			this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
			// 
			// btnCadastrar
			// 
			this.btnCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.btnCadastrar.Location = new System.Drawing.Point(471, 299);
			this.btnCadastrar.Name = "btnCadastrar";
			this.btnCadastrar.Size = new System.Drawing.Size(75, 32);
			this.btnCadastrar.TabIndex = 5;
			this.btnCadastrar.Text = "Cadastrar";
			this.btnCadastrar.UseVisualStyleBackColor = true;
			this.btnCadastrar.Click += new System.EventHandler(Program.FrmTelaprincipal.btCadastro_Click);
			// 
			// FrmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.ControlBox = false;
			this.Controls.Add(this.tableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.HelpButton = true;
			this.Name = "FrmLogin";
			this.Text = "FrmLogin";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private TableLayoutPanel tableLayoutPanel1;
		private Label LabelUsuario;
		private Label LabelSenha;
		private TextBox textBoxUsuario;
		private TextBox textBoxSenha;
		private Button btnLogar;
		private Button btnCadastrar;
	}
}