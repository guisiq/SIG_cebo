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
	public partial class frmListar_livro : Form
	{
		public frmListar_livro()
		{
			InitializeComponent();
			preencherTabela();
		}
		private void preencherTabela()
		{
			LivroDao livroDao = new LivroDao();
			
			var livros = livroDao.FindAll();
			livros?.ForEach(l => this.dataGridView1.Rows.Add(l.Titulo,l.Autor,l.Edicao,l.Sinopse));
		}
		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
	}
}
