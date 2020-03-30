/*
 * Criado por SharpDevelop.
 * Usuário: User
 * Data: 24/12/2019
 * Hora: 23:37
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace SistemaCormercial.Frames
{
	partial class FrmCadastrarUsuario
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel pnlFundoCadastroUser;
		private System.Windows.Forms.Label lblCadstrarNovoUser;
		private System.Windows.Forms.Button btnCancelarCadastro;
		private System.Windows.Forms.Button btnCadastrarUsuario;
		private System.Windows.Forms.TextBox tfCorfirmarSenha;
		private System.Windows.Forms.TextBox tfNovaSenha;
		private System.Windows.Forms.TextBox tfNovoUsuario;
		private System.Windows.Forms.TextBox tfNomeUsuario;
		private System.Windows.Forms.Label lblConfirmarSenha;
		private System.Windows.Forms.Label lblNovaSenha;
		private System.Windows.Forms.Label lblNewUsuario;
		private System.Windows.Forms.Label lblNomeUsuario;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastrarUsuario));
			this.pnlFundoCadastroUser = new System.Windows.Forms.Panel();
			this.lblCadstrarNovoUser = new System.Windows.Forms.Label();
			this.btnCancelarCadastro = new System.Windows.Forms.Button();
			this.btnCadastrarUsuario = new System.Windows.Forms.Button();
			this.tfCorfirmarSenha = new System.Windows.Forms.TextBox();
			this.tfNovaSenha = new System.Windows.Forms.TextBox();
			this.tfNovoUsuario = new System.Windows.Forms.TextBox();
			this.tfNomeUsuario = new System.Windows.Forms.TextBox();
			this.lblConfirmarSenha = new System.Windows.Forms.Label();
			this.lblNovaSenha = new System.Windows.Forms.Label();
			this.lblNewUsuario = new System.Windows.Forms.Label();
			this.lblNomeUsuario = new System.Windows.Forms.Label();
			this.pnlFundoCadastroUser.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlFundoCadastroUser
			// 
			this.pnlFundoCadastroUser.BackColor = System.Drawing.Color.Transparent;
			this.pnlFundoCadastroUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlFundoCadastroUser.BackgroundImage")));
			this.pnlFundoCadastroUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pnlFundoCadastroUser.Controls.Add(this.lblCadstrarNovoUser);
			this.pnlFundoCadastroUser.Controls.Add(this.btnCancelarCadastro);
			this.pnlFundoCadastroUser.Controls.Add(this.btnCadastrarUsuario);
			this.pnlFundoCadastroUser.Controls.Add(this.tfCorfirmarSenha);
			this.pnlFundoCadastroUser.Controls.Add(this.tfNovaSenha);
			this.pnlFundoCadastroUser.Controls.Add(this.tfNovoUsuario);
			this.pnlFundoCadastroUser.Controls.Add(this.tfNomeUsuario);
			this.pnlFundoCadastroUser.Controls.Add(this.lblConfirmarSenha);
			this.pnlFundoCadastroUser.Controls.Add(this.lblNovaSenha);
			this.pnlFundoCadastroUser.Controls.Add(this.lblNewUsuario);
			this.pnlFundoCadastroUser.Controls.Add(this.lblNomeUsuario);
			this.pnlFundoCadastroUser.Location = new System.Drawing.Point(0, 0);
			this.pnlFundoCadastroUser.Name = "pnlFundoCadastroUser";
			this.pnlFundoCadastroUser.Size = new System.Drawing.Size(357, 383);
			this.pnlFundoCadastroUser.TabIndex = 0;
			// 
			// lblCadstrarNovoUser
			// 
			this.lblCadstrarNovoUser.BackColor = System.Drawing.Color.Transparent;
			this.lblCadstrarNovoUser.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCadstrarNovoUser.ForeColor = System.Drawing.Color.White;
			this.lblCadstrarNovoUser.Location = new System.Drawing.Point(118, 18);
			this.lblCadstrarNovoUser.Name = "lblCadstrarNovoUser";
			this.lblCadstrarNovoUser.Size = new System.Drawing.Size(122, 36);
			this.lblCadstrarNovoUser.TabIndex = 20;
			this.lblCadstrarNovoUser.Text = "Cadastrar";
			// 
			// btnCancelarCadastro
			// 
			this.btnCancelarCadastro.BackColor = System.Drawing.Color.Red;
			this.btnCancelarCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelarCadastro.ForeColor = System.Drawing.Color.White;
			this.btnCancelarCadastro.Location = new System.Drawing.Point(208, 278);
			this.btnCancelarCadastro.Name = "btnCancelarCadastro";
			this.btnCancelarCadastro.Size = new System.Drawing.Size(81, 27);
			this.btnCancelarCadastro.TabIndex = 19;
			this.btnCancelarCadastro.Text = "Cancelar";
			this.btnCancelarCadastro.UseVisualStyleBackColor = false;
			this.btnCancelarCadastro.Click += new System.EventHandler(this.BtnCancelarCadastroClick);
			// 
			// btnCadastrarUsuario
			// 
			this.btnCadastrarUsuario.BackColor = System.Drawing.Color.Green;
			this.btnCadastrarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCadastrarUsuario.ForeColor = System.Drawing.Color.White;
			this.btnCadastrarUsuario.Location = new System.Drawing.Point(78, 278);
			this.btnCadastrarUsuario.Name = "btnCadastrarUsuario";
			this.btnCadastrarUsuario.Size = new System.Drawing.Size(81, 27);
			this.btnCadastrarUsuario.TabIndex = 18;
			this.btnCadastrarUsuario.Text = "Cadastrar";
			this.btnCadastrarUsuario.UseVisualStyleBackColor = false;
			this.btnCadastrarUsuario.Click += new System.EventHandler(this.BtnCadastrarUsuarioClick);
			// 
			// tfCorfirmarSenha
			// 
			this.tfCorfirmarSenha.Location = new System.Drawing.Point(152, 194);
			this.tfCorfirmarSenha.MaxLength = 14;
			this.tfCorfirmarSenha.Name = "tfCorfirmarSenha";
			this.tfCorfirmarSenha.PasswordChar = '*';
			this.tfCorfirmarSenha.Size = new System.Drawing.Size(188, 20);
			this.tfCorfirmarSenha.TabIndex = 17;
			// 
			// tfNovaSenha
			// 
			this.tfNovaSenha.Location = new System.Drawing.Point(92, 155);
			this.tfNovaSenha.MaxLength = 14;
			this.tfNovaSenha.Name = "tfNovaSenha";
			this.tfNovaSenha.PasswordChar = '*';
			this.tfNovaSenha.Size = new System.Drawing.Size(248, 20);
			this.tfNovaSenha.TabIndex = 16;
			// 
			// tfNovoUsuario
			// 
			this.tfNovoUsuario.Location = new System.Drawing.Point(92, 116);
			this.tfNovoUsuario.MaxLength = 14;
			this.tfNovoUsuario.Name = "tfNovoUsuario";
			this.tfNovoUsuario.Size = new System.Drawing.Size(248, 20);
			this.tfNovoUsuario.TabIndex = 15;
			// 
			// tfNomeUsuario
			// 
			this.tfNomeUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tfNomeUsuario.Location = new System.Drawing.Point(78, 77);
			this.tfNomeUsuario.MaxLength = 50;
			this.tfNomeUsuario.Name = "tfNomeUsuario";
			this.tfNomeUsuario.Size = new System.Drawing.Size(262, 20);
			this.tfNomeUsuario.TabIndex = 14;
			// 
			// lblConfirmarSenha
			// 
			this.lblConfirmarSenha.BackColor = System.Drawing.Color.Transparent;
			this.lblConfirmarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblConfirmarSenha.ForeColor = System.Drawing.Color.White;
			this.lblConfirmarSenha.Location = new System.Drawing.Point(16, 195);
			this.lblConfirmarSenha.Name = "lblConfirmarSenha";
			this.lblConfirmarSenha.Size = new System.Drawing.Size(130, 23);
			this.lblConfirmarSenha.TabIndex = 13;
			this.lblConfirmarSenha.Text = "Confirmar senha:";
			// 
			// lblNovaSenha
			// 
			this.lblNovaSenha.BackColor = System.Drawing.Color.Transparent;
			this.lblNovaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNovaSenha.ForeColor = System.Drawing.Color.White;
			this.lblNovaSenha.Location = new System.Drawing.Point(16, 156);
			this.lblNovaSenha.Name = "lblNovaSenha";
			this.lblNovaSenha.Size = new System.Drawing.Size(56, 23);
			this.lblNovaSenha.TabIndex = 12;
			this.lblNovaSenha.Text = "Senha:";
			// 
			// lblNewUsuario
			// 
			this.lblNewUsuario.BackColor = System.Drawing.Color.Transparent;
			this.lblNewUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNewUsuario.ForeColor = System.Drawing.Color.White;
			this.lblNewUsuario.Location = new System.Drawing.Point(16, 117);
			this.lblNewUsuario.Name = "lblNewUsuario";
			this.lblNewUsuario.Size = new System.Drawing.Size(70, 23);
			this.lblNewUsuario.TabIndex = 11;
			this.lblNewUsuario.Text = "Usuario:";
			// 
			// lblNomeUsuario
			// 
			this.lblNomeUsuario.BackColor = System.Drawing.Color.Transparent;
			this.lblNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNomeUsuario.ForeColor = System.Drawing.Color.White;
			this.lblNomeUsuario.Location = new System.Drawing.Point(16, 78);
			this.lblNomeUsuario.Name = "lblNomeUsuario";
			this.lblNomeUsuario.Size = new System.Drawing.Size(56, 23);
			this.lblNomeUsuario.TabIndex = 10;
			this.lblNomeUsuario.Text = "Nome:";
			// 
			// FrmCadastrarUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(354, 384);
			this.Controls.Add(this.pnlFundoCadastroUser);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmCadastrarUsuario";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "FrmCadastrarUsuario";
			this.pnlFundoCadastroUser.ResumeLayout(false);
			this.pnlFundoCadastroUser.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
