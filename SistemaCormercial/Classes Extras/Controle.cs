/*
 * Criado por SharpDevelop.
 * Usuário: User
 * Data: 24/12/2019
 * Hora: 22:35
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;

namespace SistemaCormercial.Classes_Extras
{
	/// <summary>
	/// Description of Controle.
	/// </summary>
	public class Controle
	{
		private bool existe = false;
		private string mensagem = "";
		
		public Controle()
		{
		}
		public bool acessar(string usuario, string senha)
		{
			ComandoDeLogin comand = new ComandoDeLogin();
			existe = comand.verificaLogin(usuario, senha);
			if(!comand.getMensagemComando().Equals(""))
			{
				setMensagemControle(comand.getMensagemComando());
			}
			return getExisteControle();
		}
		public string cadastrar(string nome, string usuario, string senha, string confSenha)
		{
			ComandoDeLogin comand = new ComandoDeLogin();
			comand.cadastrar(nome, usuario,senha, confSenha);
			if (comand.getExisteComando())
			{
				setExisteControle(true);
				setMensagemControle(comand.getMensagemComando());
			}
			return getMensagemControle();
		}
		public void setExisteControle(bool existe)
		{
			this.existe = existe;
		}
		public bool getExisteControle()
		{
			return existe;
		}
		public void setMensagemControle(string mensagem)
		{
			this.mensagem = mensagem;
		}
		public string getMensagemControle()
		{
			return mensagem;
		}
	}
}
