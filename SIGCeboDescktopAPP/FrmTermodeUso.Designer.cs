namespace SIGCeboDescktopAPP
{
    partial class FrmTermodeUso
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTermodeUso));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.rdbutonTermo = new System.Windows.Forms.RadioButton();
			this.rbtNegar = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(232, 58);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(328, 192);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Termo de uso";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(3, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(306, 153);
			this.label1.TabIndex = 0;
			this.label1.Text = resources.GetString("label1.Text");
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// rdbutonTermo
			// 
			this.rdbutonTermo.AutoSize = true;
			this.rdbutonTermo.Location = new System.Drawing.Point(258, 272);
			this.rdbutonTermo.Name = "rdbutonTermo";
			this.rdbutonTermo.Size = new System.Drawing.Size(97, 19);
			this.rdbutonTermo.TabIndex = 1;
			this.rdbutonTermo.TabStop = true;
			this.rdbutonTermo.Text = "Aceitar termo";
			this.rdbutonTermo.UseVisualStyleBackColor = true;
			// 
			// rbtNegar
			// 
			this.rbtNegar.AutoSize = true;
			this.rbtNegar.Location = new System.Drawing.Point(258, 306);
			this.rbtNegar.Name = "rbtNegar";
			this.rbtNegar.Size = new System.Drawing.Size(92, 19);
			this.rbtNegar.TabIndex = 2;
			this.rbtNegar.TabStop = true;
			this.rbtNegar.Text = "Negar termo";
			this.rbtNegar.UseVisualStyleBackColor = true;
			// 
			// FrmTermodeUso
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.rbtNegar);
			this.Controls.Add(this.rdbutonTermo);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmTermodeUso";
			this.Text = "FrmTermodeUso";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private GroupBox groupBox1;
		private Label label1;
		private RadioButton rdbutonTermo;
		private RadioButton rbtNegar;
	}
}