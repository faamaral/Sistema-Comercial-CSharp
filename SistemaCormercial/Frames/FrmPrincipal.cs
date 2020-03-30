/*
 * Criado por SharpDevelop.
 * Usuário: User
 * Data: 24/12/2019
 * Hora: 22:42
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace SistemaCormercial.Frames
{
	/// <summary>
	/// Description of FrmPrincipal.
	/// </summary>
	public partial class FrmPrincipal : Form
	{
		FrmLogin Login = new FrmLogin();
		Thread th;
		public string userLogado = "";
		public FrmPrincipal()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			lblUsuarioLogado.Text = "Bem Vindo"+ Login.str +" !!";
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MnJanelaClick(object sender, EventArgs e)
		{
//			ContextMenu.MenuItems.Clear();
//			foreach(Form frm in Application.OpenForms)
//			{
//				ContextMenu.MenuItems.Add(new MenuItem(frm.Name));
//			}
			
		}
		void MnSobreClick(object sender, EventArgs e)
		{
			th = new Thread(iniciaFormSobre);
			th.SetApartmentState(ApartmentState.STA);
			th.Start();
		}
		
		private void iniciaFormSobre()
		{
			Application.Run(new frmSobre());
		}
		void MnSairClick(object sender, EventArgs e)
		{
			Application.ExitThread();
		}
		void MniProdutoClick(object sender, EventArgs e)
		{
			th = new Thread(iniciaFormProduto);
			th.SetApartmentState(ApartmentState.STA);
			th.Start();
		}

		private void iniciaFormProduto()
		{
			Application.Run(new frmCadastrarProduto());
		}
	}
}
