using SIGCeboModel.Entitys;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGCeboModel.data
{
	public class UsuarioDao
	{
		
		public bool Encontrado { get; private set; }
		private Conexao _Conexao = new Conexao();

        public void VerificarLogin(object login, object senha)
        {
            throw new NotImplementedException();
        }

        public bool Save(Usuario uso)
		{
			SqlTransaction sqlTran = _Conexao.Con.BeginTransaction();
			var query = _Conexao.conectar().CreateCommand();
			query.Transaction = sqlTran;
			bool retorno;
			try
			{
				query.CommandText = $"INSERT INTO dbo.usuario1"
												+ "(id"
												+ ", senha"
												+ ", login"
												+ ", tipo_usuario"
												+ ", nome"
												+ ", telefone"
												+ ", is_pesoa_fisica"
												+ ", cpf"
												+ ", cnpj"
												+ ", razao_social"
												+ ", pontos"
												+ ", cep"
												+ ", estado"
												+ ", cidade"
												+ ", bairo"
												+ ", endereco"
												+ ", complemento)"
											+ "VALUES"
												+ "(@id"
												+ ", @senha"
												+ ", @login"
												+ ", @tipo_usuario"
												+ ", @nome"
												+ ", @telefone"
												+ ", @is_pesoa_fisica"
												+ ", @cpf"
												+ ", @cnpj"
												+ ", @razao_social"
												+ ", @pontos"
												+ ", @cep"
												+ ", @estado"
												+ ", @cidade"
												+ ", @bairo"
												+ ", @endereco"
												+ ", @complemento);";

				query.Parameters.Add("@login", System.Data.SqlDbType.Text).Value = uso.Login;
				query.Parameters.Add("@senha", System.Data.SqlDbType.Text).Value = uso.Senha;
				query.Parameters.Add("@tipo_usuario",System.Data.SqlDbType.Int).Value = (decimal?)uso.TipoUsuario;
			
				query.Parameters.Add("@nome", System.Data.SqlDbType.Text).Value = uso.Pessoa.Nome;
				query.Parameters.Add("@telefone", System.Data.SqlDbType.Text).Value = uso.Pessoa.Telefone;
			
				if (uso.Pessoa is PessoaFisica)
				{
					query.Parameters.Add("@is_pesoa_fisica", System.Data.SqlDbType.Bit).Value = true;
					query.Parameters.Add("@cpf", System.Data.SqlDbType.Text).Value = ((PessoaFisica)uso.Pessoa).CPF;
					query.Parameters.Add("@razaoSocial", System.Data.SqlDbType.Text).Value = null;
					query.Parameters.Add("@cnpj", System.Data.SqlDbType.Text).Value = null;

				}
				else if (uso.Pessoa is PessoaJuridica)
				{
					query.Parameters.Add("@is_pesoa_fisica", System.Data.SqlDbType.Bit).Value = false;
					query.Parameters.Add("@razaoSocial", System.Data.SqlDbType.Text).Value = ((PessoaJuridica)uso.Pessoa).RazaoSocial;
					query.Parameters.Add("@cnpj", System.Data.SqlDbType.Text).Value = ((PessoaJuridica)uso.Pessoa).Cnpj;
					query.Parameters.Add("@cpf", System.Data.SqlDbType.Text).Value = null;
				}
				if (uso.Pessoa.Endereco is null)
				{
					uso.Pessoa.Endereco = new Endereço();
				}
				query.Parameters.Add("@cep", System.Data.SqlDbType.Text).Value = uso.Pessoa.Endereco.Cep;
				query.Parameters.Add("@cidade", System.Data.SqlDbType.Text).Value = uso.Pessoa.Endereco.Cidade;
				query.Parameters.Add("@estado", System.Data.SqlDbType.Text).Value = uso.Pessoa.Endereco.Estado;
				query.Parameters.Add("@endereco", System.Data.SqlDbType.Text).Value = uso.Pessoa.Endereco.Endereco;
				query.Parameters.Add("@bairo", System.Data.SqlDbType.Text).Value = uso.Pessoa.Endereco.Bairo;
				query.Parameters.Add("@complemento", System.Data.SqlDbType.Text).Value = uso.Pessoa.Endereco.Complemento;

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
		public List<Usuario>? FindAll()
		{
			var query = _Conexao.conectar().CreateCommand();
			var usuarios = new List<Usuario>();
			try
			{
				query.CommandText = "SELECT[id]"
					  + ",[senha]"
					  + ",[login]"
					  + ",[tipo_usuario]"
					  + ",[nome]"
					  + ",[telefone]"
					  + ",[is_pesoa_fisica]"
					  + ",[cpf]"
					  + ",[cnpj]"
					  + ",[razao_social]"
					  + ",[pontos]"
					  + ",[cep]"
					  + ",[estado]"
					  + ",[cidade]"
					  + ",[bairo]"
					  + ",[endereco]"
					  + ",[complemento]"
				+ "FROM[dbo].[usuario1]";
				var result = query.ExecuteReader();
				
				while (result.Read())
				{
					Pessoa pessoa;
					if (result.GetBoolean(result.GetOrdinal("is_pesoa_fisica")) == true) 
					{
						pessoa = new PessoaFisica(
							cPF: result.GetString(result.GetOrdinal("cpf")),
							nome: result.GetString(result.GetOrdinal("nome")),
							endereco: new Endereço(
								 cep: result.GetString(result.GetOrdinal("cep")),
								 endereco: result.GetString(result.GetOrdinal("endereco")),
								 complemento: result.GetString(result.GetOrdinal("complemento")),
								 cidade: result.GetString(result.GetOrdinal("cidade")),
								 bairo: result.GetString(result.GetOrdinal("bairo")),
								 estado: result.GetString(result.GetOrdinal("estado"))
								 ),
							 telefone: result.GetString(result.GetOrdinal("telefone"))
							 );
					}
					else
					{
						pessoa = new PessoaJuridica(

							razaoSocial: result.GetString(result.GetOrdinal("razaoSocial")),
							cnpj: result.GetString(result.GetOrdinal("cnpj")),
							nome: result.GetString(result.GetOrdinal("nome")),
							endereco: new Endereço(
								 cep: result.GetString(result.GetOrdinal("cep")),
								 endereco: result.GetString(result.GetOrdinal("endereco")),
								 complemento: result.GetString(result.GetOrdinal("complemento")),
								 cidade: result.GetString(result.GetOrdinal("cidade")),
								 bairo: result.GetString(result.GetOrdinal("bairo")),
								 estado: result.GetString(result.GetOrdinal("estado"))
								 ),
							 telefone: result.GetString(result.GetOrdinal("telefone"))
							 );

					}
					var usu = new Usuario(
						login: result.GetString(result.GetOrdinal("login")),
						pessoa: pessoa,	
						senha: result.GetString(result.GetOrdinal("senha")),
						pontos: result.GetInt32(2),
						tipoUsuario: (TipoUsuario)result.GetInt32(result.GetOrdinal("tipoUsuario"))
						);
					usuarios.Add(usu);

				}
			}
			catch (Exception )
			{
				
				return null;
			}
			finally { 
				_Conexao.desconectar();
			}
			return usuarios;

		}
		public Usuario? FindById(long id)
		{
			var query = _Conexao.conectar().CreateCommand();
			Usuario? usuario= null;
			try
			{
				query.CommandText = "SELECT[id]"
					  + ",[senha]"
					  + ",[login]"
					  + ",[tipo_usuario]"
					  + ",[nome]"
					  + ",[telefone]"
					  + ",[is_pesoa_fisica]"
					  + ",[cpf]"
					  + ",[cnpj]"
					  + ",[razao_social]"
					  + ",[pontos]"
					  + ",[cep]"
					  + ",[estado]"
					  + ",[cidade]"
					  + ",[bairo]"
					  + ",[endereco]"
					  + ",[complemento]"
				+ "FROM[dbo].[usuario1]"
				+"where id = @id";
				query.Parameters.Add("@id",System.Data.SqlDbType.BigInt).Value = id;	
				var result = query.ExecuteReader();
				
				if (result.Read())
				{
					Pessoa pessoa;
					if (result.GetBoolean(result.GetOrdinal("is_pesoa_fisica")) == true) 
					{
						pessoa = new PessoaFisica(
							cPF: result.GetString(result.GetOrdinal("cpf")),
							nome: result.GetString(result.GetOrdinal("nome")),
							endereco: new Endereço(
								 cep: result.GetString(result.GetOrdinal("cep")),
								 endereco: result.GetString(result.GetOrdinal("endereco")),
								 complemento: result.GetString(result.GetOrdinal("complemento")),
								 cidade: result.GetString(result.GetOrdinal("cidade")),
								 bairo: result.GetString(result.GetOrdinal("bairo")),
								 estado: result.GetString(result.GetOrdinal("estado"))
								 ),
							 telefone: result.GetString(result.GetOrdinal("telefone"))
							 );
					}
					else
					{
						pessoa = new PessoaJuridica(

							razaoSocial: result.GetString(result.GetOrdinal("razaoSocial")),
							cnpj: result.GetString(result.GetOrdinal("cnpj")),
							nome: result.GetString(result.GetOrdinal("nome")),
							endereco: new Endereço(
								 cep: result.GetString(result.GetOrdinal("cep")),
								 endereco: result.GetString(result.GetOrdinal("endereco")),
								 complemento: result.GetString(result.GetOrdinal("complemento")),
								 cidade: result.GetString(result.GetOrdinal("cidade")),
								 bairo: result.GetString(result.GetOrdinal("bairo")),
								 estado: result.GetString(result.GetOrdinal("estado"))
								 ),
							 telefone: result.GetString(result.GetOrdinal("telefone"))
							 );

					}
					usuario = new Usuario(
						login: result.GetString(result.GetOrdinal("login")),
						pessoa: pessoa,	
						senha: result.GetString(result.GetOrdinal("senha")),
						pontos: result.GetInt32(2),
						tipoUsuario: (TipoUsuario)result.GetInt32(result.GetOrdinal("tipoUsuario"))
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
			return usuario;

		}
		public Usuario? VerificarLogin(string login , string senha )
		{
			var query = _Conexao.conectar().CreateCommand();
			Usuario? usuario = null;
			try
			{
				query.CommandText = "SELECT[id]"
					  + ",[senha]"
					  + ",[login]"
					  + ",[tipo_usuario]"
					  + ",[nome]"
					  + ",[telefone]"
					  + ",[is_pesoa_fisica]"
					  + ",[cpf]"
					  + ",[cnpj]"
					  + ",[razao_social]"
					  + ",[pontos]"
					  + ",[cep]"
					  + ",[estado]"
					  + ",[cidade]"
					  + ",[bairo]"
					  + ",[endereco]"
					  + ",[complemento]"
				+ "FROM[dbo].[usuario1]"
				+" WHERE login = @login AND"
				+" senha = @senha";
				query.Parameters.Add("@senha",System.Data.SqlDbType.VarChar ).Value = senha;	
				query.Parameters.Add("@login",System.Data.SqlDbType.VarChar ).Value = login;	
				var result = query.ExecuteReader();
				
				if (result.Read())
				{
					Pessoa pessoa;
					if (result.GetBoolean(result.GetOrdinal("is_pesoa_fisica")) == true) 
					{
						pessoa = new PessoaFisica(
							cPF: result.GetString(result.GetOrdinal("cpf")),
							nome: result.GetString(result.GetOrdinal("nome")),
							endereco: new Endereço(
								 cep: result.GetString(result.GetOrdinal("cep")),
								 endereco: result.GetString(result.GetOrdinal("endereco")),
								 complemento: result.GetString(result.GetOrdinal("complemento")),
								 cidade: result.GetString(result.GetOrdinal("cidade")),
								 bairo: result.GetString(result.GetOrdinal("bairo")),
								 estado: result.GetString(result.GetOrdinal("estado"))
								 ),
							 telefone: result.GetString(result.GetOrdinal("telefone"))
							 );
					}
					else
					{
						pessoa = new PessoaJuridica(

							razaoSocial: result.GetString(result.GetOrdinal("razaoSocial")),
							cnpj: result.GetString(result.GetOrdinal("cnpj")),
							nome: result.GetString(result.GetOrdinal("nome")),
							endereco: new Endereço(
								 cep: result.GetString(result.GetOrdinal("cep")),
								 endereco: result.GetString(result.GetOrdinal("endereco")),
								 complemento: result.GetString(result.GetOrdinal("complemento")),
								 cidade: result.GetString(result.GetOrdinal("cidade")),
								 bairo: result.GetString(result.GetOrdinal("bairo")),
								 estado: result.GetString(result.GetOrdinal("estado"))
								 ),
							 telefone: result.GetString(result.GetOrdinal("telefone"))
							 );

					}
					usuario = new Usuario(
						login: result.GetString(result.GetOrdinal("login")),
						pessoa: pessoa,	
						senha: result.GetString(result.GetOrdinal("senha")),
						pontos: result.GetInt32(2),
						tipoUsuario: (TipoUsuario)result.GetInt32(result.GetOrdinal("tipoUsuario"))
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
			return usuario;

		}
		
	}
}
