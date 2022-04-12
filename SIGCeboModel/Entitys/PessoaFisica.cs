using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGCeboModel.Entitys
{
	public class PessoaFisica:Pessoa
	{
		public String CPF { get; private set; }

		public PessoaFisica(string cPF, string nome, Endereço? endereco = null, string? telefone = null) :base( nome, endereco,telefone)
		{
			CPF = cPF;
		}
	}
}
