using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGCeboModel.data
{
	public abstract class Dao<T>
	{
		protected Conexao _Conexao = new Conexao();
		public abstract bool Save(T t);
		public abstract List<T>? FindAll();
		public abstract T? FindById(long id);

	}
}
