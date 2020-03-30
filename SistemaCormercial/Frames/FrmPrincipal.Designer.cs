/*
 * Criado por SharpDevelop.
 * Usuário: User
 * Data: 24/12/2019
 * Hora: 22:42
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace SistemaCormercial.Frames
{
	partial class FrmPrincipal
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.MenuStrip mnsPrincipal;
		private System.Windows.Forms.ToolStripMenuItem mnCadastrar;
		private System.Windows.Forms.ToolStripMenuItem mniProduto;
		private System.Windows.Forms.ToolStripMenuItem mnJanela;
		private System.Windows.Forms.ToolStripMenuItem mnSobre;
		private System.Windows.Forms.ToolStripMenuItem mnSair;
		private System.Windows.Forms.Label lblUsuarioLogado;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblUsuarioLogado = new System.Windows.Forms.Label();
			this.mnsPrincipal = new System.Windows.Forms.MenuStrip();
			this.mnCadastrar = new System.Windows.Forms.ToolStripMenuItem();
			this.mniProduto = new System.Windows.Forms.ToolStripMenuItem();
			this.mnJanela = new System.Windows.Forms.ToolStripMenuItem();
			this.mnSobre = new System.Windows.Forms.ToolStripMenuItem();
			this.mnSair = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1.SuspendLayout();
			this.mnsPrincipal.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel1.Controls.Add(this.lblUsuarioLogado);
			this.panel1.Location = new System.Drawing.Point(0, 21);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(751, 379);
			this.panel1.TabIndex = 0;
			// 
			// lblUsuarioLogado
			// 
			this.lblUsuarioLogado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUsuarioLogado.ForeColor = System.Drawing.Color.LimeGreen;
			this.lblUsuarioLogado.Location = new System.Drawing.Point(377, 34);
			this.lblUsuarioLogado.Name = "lblUsuarioLogado";
			this.lblUsuarioLogado.Size = new System.Drawing.Size(300, 59);
			this.lblUsuarioLogado.TabIndex = 0;
			// 
			// mnsPrincipal
			// 
			this.mnsPrincipal.BackColor = System.Drawing.Color.Silver;
			this.mnsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.mnCadastrar,
			this.mnJanela,
			this.mnSobre,
			this.mnSair});
			this.mnsPrincipal.Location = new System.Drawing.Point(0, 0);
			this.mnsPrincipal.Name = "mnsPrincipal";
			this.mnsPrincipal.Size = new System.Drawing.Size(749, 24);
			this.mnsPrincipal.TabIndex = 1;
			this.mnsPrincipal.Text = "menuStrip1";
			// 
			// mnCadastrar
			// 
			this.mnCadastrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.mniProduto});
			this.mnCadastrar.Name = "mnCadastrar";
			this.mnCadastrar.Size = new System.Drawing.Size(69, 20);
			this.mnCadastrar.Text = "Cadastrar";
			// 
			// mniProduto
			// 
			this.mniProduto.BackColor = System.Drawing.Color.Silver;
			this.mniProduto.Name = "mniProduto";
			this.mniProduto.Size = new System.Drawing.Size(152, 22);
			this.mniProduto.Text = "Produto";
			this.mniProduto.Click += new System.EventHandler(this.MniProdutoClick);
			// 
			// mnJanela
			// 
			this.mnJanela.Name = "mnJanela";
			this.mnJanela.Size = new System.Drawing.Size(51, 20);
			this.mnJanela.Text = "Janela";
			this.mnJanela.Click += new System.EventHandler(this.MnJanelaClick);
			// 
			// mnSobre
			// 
			this.mnSobre.Name = "mnSobre";
			this.mnSobre.Size = new System.Drawing.Size(49, 20);
			this.mnSobre.Text = "Sobre";
			this.mnSobre.Click += new System.EventHandler(this.MnSobreClick);
			// 
			// mnSair
			// 
			this.mnSair.Name = "mnSair";
			this.mnSair.Size = new System.Drawing.Size(38, 20);
			this.mnSair.Text = "Sair";
			this.mnSair.Click += new System.EventHandler(this.MnSairClick);
			// 
			// FrmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(749, 400);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.mnsPrincipal);
			this.MainMenuStrip = this.mnsPrincipal;
			this.Name = "FrmPrincipal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmPrincipal";
			this.panel1.ResumeLayout(false);
			this.mnsPrincipal.ResumeLayout(false);
			this.mnsPrincipal.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
