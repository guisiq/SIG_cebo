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
	//public partial class frmCadastroUsuario:Form{
	public partial class frmCadastroUsuario:CadastroFrm<Usuario>
	{
		public override Usuario retorno()
        {
			objcadastro.Login = this.tbLogin.Text;
			objcadastro.Senha = this.tbSenha.Text;
			return objcadastro;
        }
        public override bool isComplet()
        {
			if(this.tbSenha.Text != this.tbcomfirmaSenha.Text){
				MessageBox.Show("a senha e a confirmacao nao coencidem  ");
				return false ;
			}
            if(this.tbLogin.Text is null || this.tbLogin.Text == string.Empty ||this.tbSenha.Text is null || this.tbSenha.Text == string.Empty ){
				MessageBox.Show("insira os campos obrigatorios ");
				return false ;
			}else{
				return true;
			}
        }
    }
}
