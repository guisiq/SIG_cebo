using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGCeboModel.Entitys
{
    public class PessoaJuridica: Pessoa
    {
        public String RazaoSocial { get; set; }
        public String Cnpj { get; set; }

		public PessoaJuridica(string razaoSocial, string cnpj, string nome, Endereço? endereco = null, string? telefone = null) : base(nome, endereco, telefone)
		{
			RazaoSocial = razaoSocial;
			Cnpj = cnpj;
		}
	}
}
