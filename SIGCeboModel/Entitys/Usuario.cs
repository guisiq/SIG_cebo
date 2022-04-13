using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGCeboModel.Entitys
{
	public class Usuario
	{
		
		public long Id { get ; set; }
		public DateTime dataCadastro { get ; set ; }
		
		public string Login { get; set; }
		public string Senha { get; set; }
		public int Pontos { get; set; } = 0;
		
		public TipoUsuario TipoUsuario { get; set; }

		public Pessoa Pessoa { get; set; }
		public List<LivroEstoque>? HistoricoVendas { get; set; }
		public List<LivroEstoque>? HistoricoCompras { get; set; }

		public Usuario(int pontos ,string login, string senha, TipoUsuario tipoUsuario, Pessoa pessoa, List<LivroEstoque>? historicoVendas = null, List<LivroEstoque>? historicoCompras = null)
		{
			Pontos = pontos;
			Login = login;
			Senha = senha;
			TipoUsuario = tipoUsuario ;
			Pessoa = pessoa;
			HistoricoVendas = historicoVendas;
			HistoricoCompras = historicoCompras;
		}
		public Usuario() : base()
		{
			this.Pessoa = new Pessoa("");
			this.Pontos = 0;
			this.Login = "";
			this.Senha = "";


		}
	}
}
