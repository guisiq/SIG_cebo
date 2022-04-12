using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGCeboModel.Entitys
{
	public class LivroEstoque
	{
		public Pessoa Pessoa { get; set; }
		public StatusConservacao StatusConservacao { get; set; }
		public StatusEsstoque StatusEsstoque { get; set; }

		public LivroEstoque(Pessoa pessoa, StatusConservacao statusConservacao, StatusEsstoque statusEsstoque)
		{
			Pessoa = pessoa;
			StatusConservacao = statusConservacao;
			StatusEsstoque = statusEsstoque;
		}
	}
}
