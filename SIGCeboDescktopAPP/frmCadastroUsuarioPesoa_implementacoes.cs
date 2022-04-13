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
	//public partial class frmCadastroUsuarioPesoa : Form{
	public partial class frmCadastroUsuarioPesoa : CadastroFrm<Usuario>
	{
		public override Usuario retorno()
		{
			if (this.radBtPesoaFisica.Checked){ 
				objcadastro.Pessoa = new PessoaFisica(this.tbCpf.Text,this.tbNome.Text,telefone :tbTelefone.Text);
				return objcadastro;
			}else{
				objcadastro.Pessoa = new PessoaJuridica(this.tbRasaosocial.Text,this.tbCpf.Text,this.tbNome.Text,telefone:this.tbTelefone.Text);
				return objcadastro;
			}
		}
		
	}
}
