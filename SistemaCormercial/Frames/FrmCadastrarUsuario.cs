/*
 * Criado por SharpDevelop.
 * Usuário: User
 * Data: 24/12/2019
 * Hora: 23:37
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using SistemaCormercial.Classes_Extras;

namespace SistemaCormercial.Frames
{
	/// <summary>
	/// Description of FrmCadastrarUsuario.
	/// </summary>
	public partial class FrmCadastrarUsuario : Form
	{
		public FrmCadastrarUsuario()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnCadastrarUsuarioClick(object sender, EventArgs e)
		{
			if(tfNomeUsuario.Text.Equals("") || tfNovoUsuario.Text.Equals("") || tfNovaSenha.Text.Equals("")
			   || tfCorfirmarSenha.Text.Equals(""))
			{
				MessageBox.Show("Algum campo está vazio!!!\nPreencha-o por favor!!!!");
			}
			else
			{
				Controle con = new Controle();
				string mensagem = con.cadastrar(tfNomeUsuario.Text, tfNovoUsuario.Text, tfNovaSenha.Text, tfCorfirmarSenha.Text);
				if (con.getExisteControle())
				{
					MessageBox.Show(mensagem);
					this.Close();
				}
				else
				{
					MessageBox.Show(mensagem);
				}
			}
		}
		void BtnCancelarCadastroClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
