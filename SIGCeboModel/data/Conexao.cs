using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGCeboModel.data
{
    public class Conexao
    {
		#region regiao 1 conexao
		const string _CONNECTION_STRING = @"Data Source=LAPTOP-IC7APJAJ\SQLEXPRESS;Initial Catalog=avaliacaoA1;Integrated Security=True";
		public SqlConnection Con { get; set; } = new SqlConnection();

		public Conexao()
		{
			Con.ConnectionString = _CONNECTION_STRING;
		}
		public SqlConnection conectar()
		{
			if (!(Con.State == ConnectionState.Open))
			{
				Con.ConnectionString = _CONNECTION_STRING;
				Con.Open();
			}
			return Con;
		}
		public void desconectar()
		{
			if (Con.State == ConnectionState.Open)
			{
				Con.Close();
			}
		}
		
		#endregion
	}
}
