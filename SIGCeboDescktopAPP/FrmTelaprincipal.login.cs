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
		public Usuario? UsuarioLogado{get ;set;}
		
		private void btLogin_Click(object sender, EventArgs e)
		{
			frmContext = new FrmLogin();
			frmContext.TopLevel = false;
			frmContext.AutoScroll = true;
			frmContext.Dock = DockStyle.Fill;
			
			this.panelContext.Controls.Clear();
			this.panelContext.Controls.Add(frmContext);
			frmContext.Show();
		}

	
	}
}
