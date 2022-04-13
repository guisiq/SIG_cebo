using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGCeboModel.Entitys
{
	public class LivroEstoque
	{
		public Usuario UsuarioVenda { get; set; }
		public Usuario UsuarioCompra { get; set; }
		public StatusConservacao StatusConservacao { get; set; }
		public Livro Livro { get; set; }
		public StatusEsstoque StatusEsstoque { get; set; }

		public LivroEstoque(Usuario usuarioCompra, StatusConservacao statusConservacao, StatusEsstoque statusEsstoque)
		{
			UsuarioCompra = usuarioCompra;
			StatusConservacao = statusConservacao;
			StatusEsstoque = statusEsstoque;
		}
	}
}
