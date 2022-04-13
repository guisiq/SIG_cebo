using SIGCeboModel.Entitys;

namespace SIGCeboDescktopAPP
{
	partial class frmCadastroUsuario
	
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
			this.labelLogin = new System.Windows.Forms.Label();
			this.labelSenha = new System.Windows.Forms.Label();
			this.tbLogin = new System.Windows.Forms.TextBox();
			this.tbSenha = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tbcomfirmaSenha = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 291F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.labelLogin, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.labelSenha, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.tbLogin, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.tbSenha, 2, 3);
			this.tableLayoutPanel1.Controls.Add(this.label1, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.tbcomfirmaSenha, 2, 4);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 1);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 6;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 103F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 169F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(798, 449);
			this.tableLayoutPanel1.TabIndex = 0;
			this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
			// 
			// labelLogin
			// 
			this.labelLogin.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.labelLogin.AutoSize = true;
			this.labelLogin.Location = new System.Drawing.Point(275, 162);
			this.labelLogin.Name = "labelLogin";
			this.labelLogin.Size = new System.Drawing.Size(37, 15);
			this.labelLogin.TabIndex = 1;
			this.labelLogin.Text = "login:";
			// 
			// labelSenha
			// 
			this.labelSenha.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.labelSenha.AutoSize = true;
			this.labelSenha.Location = new System.Drawing.Point(271, 204);
			this.labelSenha.Name = "labelSenha";
			this.labelSenha.Size = new System.Drawing.Size(41, 15);
			this.labelSenha.TabIndex = 2;
			
			this.labelSenha.Text = "senha:";
			// 
			// tbLogin
			// 
			this.tbLogin.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tbLogin.Location = new System.Drawing.Point(318, 158);
			this.tbLogin.Name = "tbLogin";
			this.tbLogin.Size = new System.Drawing.Size(178, 23);
			this.tbLogin.TabIndex = 4;
			// 
			// tbSenha
			// 
			this.tbSenha.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tbSenha.Location = new System.Drawing.Point(318, 200);
			this.tbSenha.Name = "tbSenha";
			this.tbSenha.PasswordChar = '*';
			this.tbSenha.Size = new System.Drawing.Size(178, 23);
			this.tbSenha.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(204, 248);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(108, 15);
			this.label1.TabIndex = 6;
			this.label1.Text = "Comfirma a Senha:";
			// 
			// tbcomfirmaSenha
			// 
			this.tbcomfirmaSenha.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tbcomfirmaSenha.Location = new System.Drawing.Point(318, 244);
			this.tbcomfirmaSenha.Name = "tbcomfirmaSenha";
			this.tbcomfirmaSenha.PasswordChar = '*';
			this.tbcomfirmaSenha.Size = new System.Drawing.Size(178, 23);
			this.tbcomfirmaSenha.TabIndex = 7;
			// 
			// frmCadastroUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmCadastroUsuario";
			this.Text = "frmCadastroUsuario";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TableLayoutPanel tableLayoutPanel1;
		private Label labelLogin;
		private Label labelSenha;
		private TextBox tbLogin;
		private TextBox tbSenha;
		private Label label1;
		private TextBox tbcomfirmaSenha;
	}
}