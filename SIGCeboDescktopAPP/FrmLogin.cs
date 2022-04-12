using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIGCeboModel.data;

namespace SIGCeboDescktopAPP
{
	public partial class FrmLogin : Form
	{
		public FrmLogin()
		{
			InitializeComponent();
		}

		

		private void btnLogar_Click(object sender, EventArgs e)
		{
			var usoDao = new UsuarioDao();
			Program.FrmTelaprincipal.UsuarioLogado = usoDao.VerificarLogin(login: this.textBoxUsuario.Text, senha: this.textBoxSenha.Text);
			MessageBox.Show("e pra ter dado certo .");
			MessageBox.Show(Program.FrmTelaprincipal.UsuarioLogado?.Senha);
		}
	}
}
