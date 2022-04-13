namespace SIGCeboDescktopAPP
{
	partial class frmCadastro<T>
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
			this.pnlContent = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.btCancelar = new System.Windows.Forms.Button();
			this.panel2.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlContent
			// 
			this.pnlContent.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlContent.Location = new System.Drawing.Point(0, 0);
			this.pnlContent.Name = "pnlContent";
			this.pnlContent.Size = new System.Drawing.Size(800, 450);
			this.pnlContent.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.tableLayoutPanel1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 406);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(800, 44);
			this.panel2.TabIndex = 1;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
			this.tableLayoutPanel1.Controls.Add(this.btCancelar, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnNext, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnBack, 1, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(491, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(309, 44);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// btnBack
			// 
			this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.btnBack.Location = new System.Drawing.Point(106, 10);
			this.btnBack.Margin = new System.Windows.Forms.Padding(10);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(76, 24);
			this.btnBack.TabIndex = 1;
			this.btnBack.Text = "voltar";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnNext
			// 
			this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.btnNext.Location = new System.Drawing.Point(209, 10);
			this.btnNext.Margin = new System.Windows.Forms.Padding(10);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(82, 24);
			this.btnNext.TabIndex = 0;
			this.btnNext.Text = "avancar";
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btCancelar
			// 
			this.btCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btCancelar.AutoSize = true;
			this.btCancelar.Location = new System.Drawing.Point(10, 10);
			this.btCancelar.Margin = new System.Windows.Forms.Padding(10);
			this.btCancelar.Name = "btCancelar";
			this.btCancelar.Size = new System.Drawing.Size(76, 24);
			this.btCancelar.TabIndex = 2;
			this.btCancelar.Text = "cancelar";
			this.btCancelar.UseVisualStyleBackColor = true;
			this.btCancelar.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// frmCadastro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.pnlContent);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmCadastro";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text = "frmCadastro";
			this.Load += new System.EventHandler(this.frmParent_Load);
			this.panel2.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Panel pnlContent;
		private Panel panel2;
		private TableLayoutPanel tableLayoutPanel1;
		private Button btnNext;
		private Button btnBack;
		private Button btCancelar;
	}
}