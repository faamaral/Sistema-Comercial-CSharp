/*
 * Criado por SharpDevelop.
 * Usuário: User
 * Data: 03/01/2020
 * Hora: 15:02
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaCormercial.Frames
{
	/// <summary>
	/// Description of frmCadastrarProduto.
	/// </summary>
	public partial class frmCadastrarProduto : Form
	{
		public frmCadastrarProduto()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void TfCodigoProdutoKeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
			{
				e.Handled = true;
			}
		}
		void TfQtnEstoqueKeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
			{
				e.Handled = true;
			}
		}
	}
}
