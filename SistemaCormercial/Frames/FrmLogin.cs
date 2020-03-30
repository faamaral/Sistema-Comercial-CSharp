/*
 * Criado por SharpDevelop.
 * Usuário: User
 * Data: 24/12/2019
 * Hora: 22:06
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using SistemaCormercial.Classes_Extras;
using SistemaCormercial.Frames;

namespace SistemaCormercial
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class FrmLogin : Form
	{
		Thread th;
		Controle contr = new Controle();
		public string str = "";
		public FrmLogin()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		private void iniciaTela()
		{
			Application.Run(new FrmPrincipal());
		}
		void TfSenhaKeyDown(object sender, KeyEventArgs e)
		{
			if (tfUsuario.Text.Length < 0)
			{
				MessageBox.Show("Informe o Usuario!!!");
				tfSenha.Clear();
				tfUsuario.Focus();
				
			}
			else
			{
				if(e.KeyCode == Keys.Enter)
				{
					contr.acessar(tfUsuario.Text, tfSenha.Text);
					if(contr.getMensagemControle().Equals(""))
					{
					   	if(contr.getExisteControle())
					   	{
					   		str = tfUsuario.Text;
					   		this.Close();
					   		th = new Thread(iniciaTela);
					   		th.SetApartmentState(ApartmentState.STA);
					   		th.Start();
					   	}
					   	else
					   	{
					   		MessageBox.Show("Usuario Invalido!! \nOu senha incorreta");
					   	}
					}
					else
					{
						MessageBox.Show(contr.getMensagemControle());
					}
					
				}
			}
		}
		void BtnLogarClick(object sender, EventArgs e)
		{
			if (tfUsuario.Text.Equals("") || tfSenha.Text.Equals(""))
			{
				MessageBox.Show("Todos os campos devem estar preenchidos!!!");
				tfUsuario.Focus();
			}
			else
			{
				contr.acessar(tfUsuario.Text, tfSenha.Text);
				if(contr.getMensagemControle().Equals(""))
				{
					if(contr.getExisteControle())
					{
						str = tfUsuario.Text;
						this.Close();
						th = new Thread(iniciaTela);
						th.SetApartmentState(ApartmentState.STA);
						th.Start();
					}
					else
					{
						MessageBox.Show("Usuario Invalido!! \nOu senha incorreta");
					}
				}
				else
				{
					MessageBox.Show(contr.getMensagemControle());
				}
			}
		}
		void BtnCancelarClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void TfUsuarioTextChanged(object sender, EventArgs e)
		{
	
		}
		void BtnCadastrarUsuarioClick(object sender, EventArgs e)
		{
			FrmCadastrarUsuario cad = new FrmCadastrarUsuario();
			cad.ShowDialog();
		}
		private void iniciaCadUsuario()
		{
			Application.Run(new FrmCadastrarUsuario());
		}
	}
}
