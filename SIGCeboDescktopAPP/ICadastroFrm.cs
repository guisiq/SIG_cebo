using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGCeboDescktopAPP
{
	public  abstract class CadastroFrm<T> :Form
	{
		public T objcadastro ;
		public abstract T retorno( );
		public abstract bool isComplet( );
	}
}
