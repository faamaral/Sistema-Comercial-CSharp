/*
 * Criado por SharpDevelop.
 * Usuário: User
 * Data: 24/12/2019
 * Hora: 22:37
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;

namespace SistemaCormercial.Classes_Extras
{
	/// <summary>
	/// Description of ComandoDeLogin.
	/// </summary>
	public class ComandoDeLogin
	{
		private bool existeComando = false;
		private string mensagem = "";
		MySqlCommand mysqlComand = new MySqlCommand();
		ConexaoBD con = new ConexaoBD();
		MySqlDataReader dr;
		public ComandoDeLogin()
		{
			
		}
		public bool verificaLogin(string user, string senha)
		{
			mysqlComand.CommandText = "select * from logins where usuario = @user and senha = @senha";
			mysqlComand.Parameters.AddWithValue("@user", user);
			mysqlComand.Parameters.AddWithValue("@senha", senha);
			try
			{
				mysqlComand.Connection = con.conectarBD();
				dr = mysqlComand.ExecuteReader();
				if (dr.HasRows)
				{
					setExisteComando(true);
				}
				con.desconectar();
				dr.Close();
				
			}
			catch (SqlException)
			{
				
				setMensagemComando("Erro com o Banco de dados!!");
			}
			return getExisteComando();
		}
		public string cadastrar(string nome, string usuario, string senha, string confSenha)
		{
			setExisteComando(false);
			if(senha.Equals(confSenha))
			{
				mysqlComand.CommandText = "insert into logins values (@nome, @usuario, @senha);";
				mysqlComand.Parameters.AddWithValue("@nome",nome);
				mysqlComand.Parameters.AddWithValue("@usuario", usuario);
				mysqlComand.Parameters.AddWithValue("@senha",senha);
				
				try
				{
					mysqlComand.Connection = con.conectarBD();
					mysqlComand.ExecuteNonQuery();
					con.desconectar();
					setMensagemComando("Usuario cadastrado com sucesso!!!");
					setExisteComando(true);
				}
				catch (MySqlException)
				{
					setMensagemComando("Erro com o banco de dados!!!");
				}
			}
			else
			{
				setMensagemComando("Senhas não correspondem!!!!");
			}
			
			return getMensagemComando();
		}
		public void setExisteComando(bool existe)
		{
			this.existeComando = existe;
		}
		public bool getExisteComando()
		{
			return existeComando;
		}
		public void setMensagemComando(string msg)
		{
			mensagem = msg;
		}
		public string getMensagemComando()
		{
			return mensagem;
		}
	}
}
