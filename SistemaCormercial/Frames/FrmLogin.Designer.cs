/*
 * Criado por SharpDevelop.
 * Usuário: User
 * Data: 24/12/2019
 * Hora: 22:06
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace SistemaCormercial
{
	partial class FrmLogin
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel pnlFundoLogin;
		private System.Windows.Forms.Button btnCadastrarUsuario;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnLogar;
		private System.Windows.Forms.Label lblSenha;
		private System.Windows.Forms.Label lblUsuario;
		private System.Windows.Forms.TextBox tfSenha;
		private System.Windows.Forms.TextBox tfUsuario;
		private System.Windows.Forms.Label label1;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
			this.pnlFundoLogin = new System.Windows.Forms.Panel();
			this.btnCadastrarUsuario = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnLogar = new System.Windows.Forms.Button();
			this.lblSenha = new System.Windows.Forms.Label();
			this.lblUsuario = new System.Windows.Forms.Label();
			this.tfSenha = new System.Windows.Forms.TextBox();
			this.tfUsuario = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pnlFundoLogin.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlFundoLogin
			// 
			this.pnlFundoLogin.BackColor = System.Drawing.Color.MediumTurquoise;
			this.pnlFundoLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlFundoLogin.BackgroundImage")));
			this.pnlFundoLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pnlFundoLogin.Controls.Add(this.btnCadastrarUsuario);
			this.pnlFundoLogin.Controls.Add(this.btnCancelar);
			this.pnlFundoLogin.Controls.Add(this.btnLogar);
			this.pnlFundoLogin.Controls.Add(this.lblSenha);
			this.pnlFundoLogin.Controls.Add(this.lblUsuario);
			this.pnlFundoLogin.Controls.Add(this.tfSenha);
			this.pnlFundoLogin.Controls.Add(this.tfUsuario);
			this.pnlFundoLogin.Controls.Add(this.label1);
			this.pnlFundoLogin.Location = new System.Drawing.Point(0, 0);
			this.pnlFundoLogin.Name = "pnlFundoLogin";
			this.pnlFundoLogin.Size = new System.Drawing.Size(467, 391);
			this.pnlFundoLogin.TabIndex = 0;
			// 
			// btnCadastrarUsuario
			// 
			this.btnCadastrarUsuario.BackColor = System.Drawing.Color.DarkBlue;
			this.btnCadastrarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCadastrarUsuario.ForeColor = System.Drawing.Color.Cyan;
			this.btnCadastrarUsuario.Location = new System.Drawing.Point(168, 294);
			this.btnCadastrarUsuario.Name = "btnCadastrarUsuario";
			this.btnCadastrarUsuario.Size = new System.Drawing.Size(265, 52);
			this.btnCadastrarUsuario.TabIndex = 7;
			this.btnCadastrarUsuario.Text = "Cadastre - se";
			this.btnCadastrarUsuario.UseVisualStyleBackColor = false;
			this.btnCadastrarUsuario.Click += new System.EventHandler(this.BtnCadastrarUsuarioClick);
			// 
			// btnCancelar
			// 
			this.btnCancelar.BackColor = System.Drawing.Color.Red;
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.ForeColor = System.Drawing.Color.White;
			this.btnCancelar.Location = new System.Drawing.Point(324, 196);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(109, 30);
			this.btnCancelar.TabIndex = 6;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = false;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// btnLogar
			// 
			this.btnLogar.BackColor = System.Drawing.Color.Lime;
			this.btnLogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogar.Location = new System.Drawing.Point(168, 196);
			this.btnLogar.Name = "btnLogar";
			this.btnLogar.Size = new System.Drawing.Size(109, 30);
			this.btnLogar.TabIndex = 5;
			this.btnLogar.Text = "Entrar";
			this.btnLogar.UseVisualStyleBackColor = false;
			this.btnLogar.Click += new System.EventHandler(this.BtnLogarClick);
			// 
			// lblSenha
			// 
			this.lblSenha.BackColor = System.Drawing.Color.Transparent;
			this.lblSenha.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSenha.ForeColor = System.Drawing.Color.Turquoise;
			this.lblSenha.Location = new System.Drawing.Point(33, 136);
			this.lblSenha.Name = "lblSenha";
			this.lblSenha.Size = new System.Drawing.Size(100, 23);
			this.lblSenha.TabIndex = 4;
			this.lblSenha.Text = "Senha:";
			// 
			// lblUsuario
			// 
			this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
			this.lblUsuario.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUsuario.ForeColor = System.Drawing.Color.Turquoise;
			this.lblUsuario.Location = new System.Drawing.Point(33, 82);
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(100, 23);
			this.lblUsuario.TabIndex = 3;
			this.lblUsuario.Text = "Usuario:";
			// 
			// tfSenha
			// 
			this.tfSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tfSenha.Location = new System.Drawing.Point(168, 139);
			this.tfSenha.MaxLength = 14;
			this.tfSenha.Name = "tfSenha";
			this.tfSenha.PasswordChar = '*';
			this.tfSenha.Size = new System.Drawing.Size(265, 20);
			this.tfSenha.TabIndex = 2;
			this.tfSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TfSenhaKeyDown);
			// 
			// tfUsuario
			// 
			this.tfUsuario.Location = new System.Drawing.Point(168, 79);
			this.tfUsuario.MaxLength = 14;
			this.tfUsuario.Name = "tfUsuario";
			this.tfUsuario.Size = new System.Drawing.Size(265, 20);
			this.tfUsuario.TabIndex = 1;
			this.tfUsuario.TextChanged += new System.EventHandler(this.TfUsuarioTextChanged);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Coral;
			this.label1.Location = new System.Drawing.Point(182, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 40);
			this.label1.TabIndex = 0;
			this.label1.Text = "Entrar";
			// 
			// FrmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(467, 386);
			this.Controls.Add(this.pnlFundoLogin);
			this.MaximizeBox = false;
			this.Name = "FrmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SistemaCormercial";
			this.pnlFundoLogin.ResumeLayout(false);
			this.pnlFundoLogin.PerformLayout();
			this.ResumeLayout(false);

		}
//			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
//			this.Text = "SistemaCormercial";
//			this.pnlFundoLogin.ResumeLayout(false);
//			this.pnlFundoLogin.PerformLayout();
//			this.ResumeLayout(false);

		}
	}
