using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGCeboModel.Entitys
{
	public class Endereço
	{
		public String? Cep { get; set; }
		public String? Endereco { get; set; }
		public String? Complemento { get; set; }
		public String? Cidade { get; set; }
		public String? Bairo { get; set; }
		public String? Estado { get; set; }

		public Endereço(string? cep=null, string? endereco = null, string? complemento = null, string? cidade = null, string? bairo = null, string? estado = null)
		{
			Cep = cep;
			Endereco = endereco;
			Complemento = complemento;
			Cidade = cidade;
			Bairo = bairo;
			Estado = estado;
		}
	}
}
