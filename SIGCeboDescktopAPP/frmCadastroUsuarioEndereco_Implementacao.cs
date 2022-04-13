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
//	public partial class frmCadastroUsuarioEndereco :Form{
	
	public partial class frmCadastroUsuarioEndereco :CadastroFrm<Usuario>
	{
		public override Usuario retorno()
        {
			if (objcadastro.Pessoa.Endereco is null)
			{
				objcadastro.Pessoa.Endereco = new Endereço();
			}
			objcadastro.Pessoa.Endereco.Cep = this.tbCep.Text??"";
			objcadastro.Pessoa.Endereco.Estado= this.tbEstado.Text??"";
			objcadastro.Pessoa.Endereco.Cidade = this.tbCidade.Text??"";
			objcadastro.Pessoa.Endereco.Bairo = this.tbBairo.Text??"";
			objcadastro.Pessoa.Endereco.Endereco = this.tbEndereco.Text??"";
			objcadastro.Pessoa.Endereco.Complemento = this.tbComplementom.Text??"";

			return objcadastro;
        }
		 public override bool isComplet()
        {
            return true;
        }
    }
}
