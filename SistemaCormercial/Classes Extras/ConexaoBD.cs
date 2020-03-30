/*
 * Criado por SharpDevelop.
 * Usuário: User
 * Data: 24/12/2019
 * Hora: 22:38
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace SistemaCormercial.Classes_Extras
{
	/// <summary>
	/// Description of ConexaoBD.
	/// </summary>
	public class ConexaoBD
	{
		//SqlConnection sql = new SqlConnection();
		MySqlConnection mysql;
		public ConexaoBD()
		{
			mysql = new MySqlConnection(@"server=localhost;database=bdlogins;uid=root;pwd='mysql1234'");
			//sql.ConnectionString = @"server=localhost;database=bdlogins;uid=root;pwd='mysql1234'";
		}
		
		public MySqlConnection conectarBD()
		{
			if (mysql.State == System.Data.ConnectionState.Closed)
			{
				mysql.Open();
			}
			return mysql;
		}
		public void desconectar()
		{
			if (mysql.State == System.Data.ConnectionState.Open)
			{
				mysql.Close();
			}
		}
	}
}
