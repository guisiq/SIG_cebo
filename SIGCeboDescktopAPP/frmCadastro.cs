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
	public partial class frmCadastro : Form
	{
		public List<Form> formsCadastro {get; set;} 
		int top = -1;
        int count;
		public String Titulo {get; set;} 
		public frmCadastro( )
		{
            this.formsCadastro =new List<Form>() ;
            this.formsCadastro.Add(new frmCadastroUsuarioPesoa());
            this.formsCadastro.Add(new frmCadastroUsuario());
            count = formsCadastro.Count();

            InitializeComponent();
		}
		
        private void LoadNewForm()
        {
            formsCadastro[top].TopLevel = false;
            formsCadastro[top].AutoScroll = true;
            formsCadastro[top].Dock = DockStyle.Fill;
            this.pnlContent.Controls.Clear();
            this.pnlContent.Controls.Add(formsCadastro[top]);
            formsCadastro[top].Show();
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

            top++;
            if (top >= count)
            {
                return;
            }
            else
            {
                btnBack.Enabled = true;
                btnNext.Enabled = true;
                LoadNewForm();
                if (top + 1 == count)
                {
                    //btnNext.Enabled = false;
                    btnNext.Enabled = false;
                }
            }

            if (top <= 0)
            {
                btnBack.Enabled = false;
            }
        }

        private void frmParent_Load(object sender, EventArgs e)
        {
            Next();
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
