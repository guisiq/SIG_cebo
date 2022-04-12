using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGCeboModel.Entitys
{
	public class Pessoa 
	{
		public String Nome { get; set; }
		public Endereço? Endereco { get; set; }
		public String? Telefone { get; set; }

		
		public Pessoa(string nome, Endereço? endereco =null, string? telefone= null)
		{
			Endereco = endereco;
			Telefone = telefone;
			Nome = nome ?? throw new ArgumentNullException(nameof(nome));
		}
	}
}

