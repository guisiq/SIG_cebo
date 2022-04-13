using SIGCeboModel.Entitys;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGCeboModel.data
{
    public class LivroDao : Dao<Livro>
    {
        public override List<Livro>? FindAll()
        {
            var query = _Conexao.conectar().CreateCommand();
			var livros = new List<Livro>();
			try
			{
				query.CommandText = "SELECT [Autor]"+
										",[Titulo]"+
										",[Sinopse]"+
										",[edicao]"+
										",[id]"+
									"FROM [dbo].[livro];";
				var result = query.ExecuteReader();
				
				while (result.Read())
				{
					Livro livro = new Livro(
						result.GetString(0),
						result.GetString(1),
						result.GetString(2),
						result.GetInt32(3),
						result.GetInt64(4)
					);
					livros.Add(livro);
				}
			}
			catch (Exception )
			{
				return null;
			}
			finally { 
				_Conexao.desconectar();
			}
			return livros;
        }

        public override Livro? FindById(long id)
        {
            var query = _Conexao.conectar().CreateCommand();
			Livro? livro = null ;
			try
			{
				query.CommandText = "SELECT [Autor]"+
										",[Titulo]"+
										",[Sinopse]"+
										",[edicao]"+
										",[id]"+
									"FROM [dbo].[livro]"+
									"where id = @id;";
				var result = query.ExecuteReader();
				query.Parameters.Add("@id",System.Data.SqlDbType.BigInt).Value = id;
								
				if(result.Read())
				{
					livro = new Livro(
						result.GetString(0),
						result.GetString(1),
						result.GetString(2),
						result.GetInt32(3),
						result.GetInt64(4)
					);
					
				}
			}
			catch (Exception)
			{
				return null;
			}
			finally { 
				_Conexao.desconectar();
			}
			return livro;
        }

        public override bool Save(Livro t)
        {
           	SqlTransaction sqlTran = _Conexao.Con.BeginTransaction();
			var query = _Conexao.conectar().CreateCommand();
			query.Transaction = sqlTran;
			bool retorno;
			try
			{
				query.CommandText = $"INSERT INTO [dbo].[livro]"+
										"([Autor]"+
										",[Titulo]"+
										",[Sinopse]"+
										",[edicao]"+
										",[id])"+
									"VALUES"+
										"(@Autor"+
										",@Titulo"+
										",@Sinopse"+
										",@edicao"+
										",@id;";

				query.Parameters.Add("@Autor", System.Data.SqlDbType.VarChar).Value = t.Autor;
				query.Parameters.Add("@Titulo", System.Data.SqlDbType.VarChar).Value = t.Titulo;
				query.Parameters.Add("@Sinopse",System.Data.SqlDbType.VarChar).Value = t.Sinopse;
				query.Parameters.Add("@edicao", System.Data.SqlDbType.Int).Value = t.Edicao;
				query.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = t.Id;

				var result = query.ExecuteNonQuery();
				sqlTran.Commit();
				retorno = true;
			}
			catch (Exception ex)
			{
				try
				{
					// Attempt to roll back the transaction.
					sqlTran.Rollback();
				}
				catch (Exception exRollback)
				{
					Console.WriteLine(exRollback.Message);
				}
				Console.WriteLine(ex.Message);
				retorno = false;
			}
			finally {
				_Conexao.desconectar();
			}
			return retorno;	
        }
    }
}
