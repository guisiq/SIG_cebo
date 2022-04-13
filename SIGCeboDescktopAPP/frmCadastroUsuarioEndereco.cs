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
	public partial class frmCadastroUsuarioEndereco 
	{
		public frmCadastroUsuarioEndereco()
		{
			InitializeComponent();
		}
		private async void button1_Click(object sender, EventArgs e)
		{
			using(var ws = new Coreios.AtendeClienteClient())
			{
				try
				{
					//var result = ws.consultaCEPAsync(tbCep.Text).Result.@return;
					var response = ws.consultaCEPAsync(tbCep.Text);
					//var response1 = ws.consultaCEP(tbCep.Text);

					if (response == null)	
						return;
					var result = response.Result.@return;
					
					
					tbEndereco.Text = result.end.ToString();
					tbComplementom.Text = result.complemento2.ToString();
					tbCidade.Text = result.cidade.ToString();
					tbBairo.Text = result.bairro.ToString();
					tbEstado.Text= result.uf.ToString();
				}
				catch (Exception ex)
				{
					MessageBox.Show("erro:"+ex.Message);
					MessageBox.Show(ex.Message,"erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
					throw;
				}
			}
		}

		private void frmCadastroUsuarioEndereco_Load(object sender, EventArgs e)
		{

		}
	}
}
