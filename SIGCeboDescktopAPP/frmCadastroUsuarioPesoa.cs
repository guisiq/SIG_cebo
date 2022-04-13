using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIGCeboModel.Entitys;

namespace SIGCeboDescktopAPP
{
	public partial class frmCadastroUsuarioPesoa 
	{
		public frmCadastroUsuarioPesoa()
		{
			InitializeComponent();
		}
        private void label1_Click(object sender, EventArgs e)
		{

		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			if (radbtPessoaJuridica.Checked)
			{
				this.tableLayoutPanel1.Controls.Add(this.tbCnpj, 2, 4);
				this.tableLayoutPanel1.Controls.Add(this.labelcnpj, 1, 4);
				
				this.tableLayoutPanel1.Controls.Add(this.tbRasaosocial, 2, 5);
				this.tableLayoutPanel1.Controls.Add(this.labelRasaoSocial, 1, 5);
				
				this.tableLayoutPanel1.Controls.Remove(this.tbCpf);
				this.tableLayoutPanel1.Controls.Remove(this.labelcpf);
			}

		}

		private void radBtPesoaFisica_CheckedChanged(object sender, EventArgs e)
		{
			if (radBtPesoaFisica.Checked)
			{
				this.tableLayoutPanel1.Controls.Add(this.tbCpf, 2, 4);
				this.tableLayoutPanel1.Controls.Add(this.labelcpf, 1, 4);
				this.tableLayoutPanel1.Controls.Remove(this.tbCnpj);
				this.tableLayoutPanel1.Controls.Remove(this.labelcnpj);
			}

		}

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
