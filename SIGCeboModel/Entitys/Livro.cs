using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGCeboModel.Entitys
{
	public class Livro 
	{
		public String Autor { get; set; }
		public String Titulo { get; set; }
		public String? Sinopse { get; set; }

		public int Edicao { get; set; }

		public long Id { get; set; }
		public DateTime? dataCadastro { get ; set; }

		public Livro(string autor, string titulo, string sinopse, int edicao, long id, DateTime? dataCadastro= null)
		{
			Autor = autor;
			Titulo = titulo;
			Sinopse = sinopse;
			Edicao = edicao;
			Id = id;
			this.dataCadastro = dataCadastro;
		}
	}
}
