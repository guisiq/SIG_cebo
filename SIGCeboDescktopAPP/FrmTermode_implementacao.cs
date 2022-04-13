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
	//public partial class FrmTermodeUso :Form{
	public partial class FrmTermodeUso : CadastroFrm<Usuario>
	{
		public override Usuario retorno()
		{
			return objcadastro;
			
		}
		 public override bool isComplet()
        {
            if(!this.rdbutonTermo.Checked){
				MessageBox.Show("voce precisa aceitar o termo para continuar ");
				return false ;
			}else{
				return true;
			}
        }
		
	}
}
