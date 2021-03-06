using SIGCeboModel.data;
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
	public partial class frmCadastro<T> : Form
	{
		public List<CadastroFrm<T>> FormsCadastro {get; set;} 
		//public List<Func<dynamic,dynamic>> acoesFormulario{get; set;}
        //dynamic retorno;
		int top = 0;
        int count;
        
        public T usoCadastro;
        Dao<T> Dao;
        public Form telaPosFinal;

		public String Titulo {get; set;} 
		
        public frmCadastro(List<CadastroFrm<T>> formsCadastro,Dao<T> dao)
		{
			this.FormsCadastro =formsCadastro; 
            Dao =dao;
            // new List<CadastroFrm<Usuario>>
			// {
			// 	new frmCadastroUsuarioPesoa(),
			// 	new frmCadastroUsuario()
			// };

			//this.acoesFormulario =new List<Func<dynamic, dynamic>>() ;
			count = formsCadastro.Count();

            InitializeComponent();
		}
		
        private void LoadNewForm()
        {
            FormsCadastro[top]?.Hide();
            FormsCadastro[top].TopLevel = false;
            FormsCadastro[top].AutoScroll = true;
            FormsCadastro[top].Dock = DockStyle.Fill;
            FormsCadastro[top].objcadastro = usoCadastro;
            this.pnlContent.Controls.Clear();
            this.pnlContent.Controls.Add(FormsCadastro[top]);
            FormsCadastro[top].Show();
        }

        private void Back()
        {
            top--;

            if (top <= -1)
            {
                return;
            }
            else
            {
                btnBack.Enabled = true;
                btnNext.Text ="Avançar";
                btnNext.Enabled = true;
                LoadNewForm();
                if (top - 1 <= -1)
                {
                    btnBack.Enabled = false;
                }
            }
            if (top >= count)
            {
                
                btnNext.Enabled = false;
            }
        }
        
        private void Next()
        {
            if (FormsCadastro[top].isComplet())
            {
                usoCadastro = FormsCadastro[top].retorno();
                top++;
                if (top >= count)
                {
                    finalizar();
                    return;
                }
                else
                {
                    btnBack.Enabled = true;
                    btnNext.Enabled = true;
                    LoadNewForm();
                    if (top + 1 == count)
                    {
                        btnNext.Text ="Salvar";
                        //btnNext.Enabled = false;
                    }
                }

                if (top <= 0)
                {
                    btnBack.Enabled = false;
                }
            }
        }
        private void finalizar (){
            Dao.Save(usoCadastro);
            this.Close();
        }

        private void frmParent_Load(object sender, EventArgs e)
        {
            LoadNewForm();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Next();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

	
	}
}
