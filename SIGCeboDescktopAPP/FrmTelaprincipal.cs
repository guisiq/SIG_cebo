using SIGCeboModel.Entitys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIGCeboDescktopAPP
{
	public partial class FrmTelaprincipal : Form
	{
		public FrmTelaprincipal()
		{
			InitializeComponent();
		}
		Form frmContext;

		private void btnListarLivros_Click(object sender, EventArgs e)
		{
			frmContext = new frmListar_livro();
			frmContext.TopLevel = false;
			frmContext.AutoScroll = true;
			frmContext.Dock = DockStyle.Fill;

			this.panelContext.Controls.Clear();
			this.panelContext.Controls.Add(frmContext);
			frmContext.Show();
			
		}
	}
}
