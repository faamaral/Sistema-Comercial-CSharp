/*
 * Criado por SharpDevelop.
 * Usuário: User
 * Data: 03/01/2020
 * Hora: 15:02
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace SistemaCormercial.Frames
{
	partial class frmCadastrarProduto
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox tfPreco;
		private System.Windows.Forms.TextBox tfQtnEstoque;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox tfCodigoProduto;
		private System.Windows.Forms.Label lblPreco;
		private System.Windows.Forms.Label lblQtnEstoque;
		private System.Windows.Forms.Label lblDecricaoProduto;
		private System.Windows.Forms.Label lblCodigoProduto;
		private System.Windows.Forms.Panel panel2;
		
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.tfPreco = new System.Windows.Forms.TextBox();
			this.tfQtnEstoque = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.tfCodigoProduto = new System.Windows.Forms.TextBox();
			this.lblPreco = new System.Windows.Forms.Label();
			this.lblQtnEstoque = new System.Windows.Forms.Label();
			this.lblDecricaoProduto = new System.Windows.Forms.Label();
			this.lblCodigoProduto = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(654, 386);
			this.panel1.TabIndex = 0;
			// 
			// panel3
			// 
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel3.Controls.Add(this.tfPreco);
			this.panel3.Controls.Add(this.tfQtnEstoque);
			this.panel3.Controls.Add(this.textBox1);
			this.panel3.Controls.Add(this.tfCodigoProduto);
			this.panel3.Controls.Add(this.lblPreco);
			this.panel3.Controls.Add(this.lblQtnEstoque);
			this.panel3.Controls.Add(this.lblDecricaoProduto);
			this.panel3.Controls.Add(this.lblCodigoProduto);
			this.panel3.Location = new System.Drawing.Point(15, 173);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(625, 199);
			this.panel3.TabIndex = 1;
			// 
			// tfPreco
			// 
			this.tfPreco.Location = new System.Drawing.Point(74, 80);
			this.tfPreco.MaxLength = 7;
			this.tfPreco.Name = "tfPreco";
			this.tfPreco.Size = new System.Drawing.Size(163, 20);
			this.tfPreco.TabIndex = 7;
			// 
			// tfQtnEstoque
			// 
			this.tfQtnEstoque.Location = new System.Drawing.Point(159, 57);
			this.tfQtnEstoque.MaxLength = 7;
			this.tfQtnEstoque.Name = "tfQtnEstoque";
			this.tfQtnEstoque.Size = new System.Drawing.Size(78, 20);
			this.tfQtnEstoque.TabIndex = 6;
			this.tfQtnEstoque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TfQtnEstoqueKeyPress);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(105, 34);
			this.textBox1.MaxLength = 200;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(414, 20);
			this.textBox1.TabIndex = 5;
			// 
			// tfCodigoProduto
			// 
			this.tfCodigoProduto.Location = new System.Drawing.Point(90, 11);
			this.tfCodigoProduto.MaxLength = 7;
			this.tfCodigoProduto.Name = "tfCodigoProduto";
			this.tfCodigoProduto.Size = new System.Drawing.Size(147, 20);
			this.tfCodigoProduto.TabIndex = 4;
			this.tfCodigoProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TfCodigoProdutoKeyPress);
			// 
			// lblPreco
			// 
			this.lblPreco.BackColor = System.Drawing.Color.Transparent;
			this.lblPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPreco.ForeColor = System.Drawing.Color.White;
			this.lblPreco.Location = new System.Drawing.Point(12, 78);
			this.lblPreco.Name = "lblPreco";
			this.lblPreco.Size = new System.Drawing.Size(100, 23);
			this.lblPreco.TabIndex = 3;
			this.lblPreco.Text = "Preço:";
			// 
			// lblQtnEstoque
			// 
			this.lblQtnEstoque.BackColor = System.Drawing.Color.Transparent;
			this.lblQtnEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblQtnEstoque.ForeColor = System.Drawing.Color.White;
			this.lblQtnEstoque.Location = new System.Drawing.Point(12, 55);
			this.lblQtnEstoque.Name = "lblQtnEstoque";
			this.lblQtnEstoque.Size = new System.Drawing.Size(157, 23);
			this.lblQtnEstoque.TabIndex = 2;
			this.lblQtnEstoque.Text = "Qnt. em Estoque:";
			// 
			// lblDecricaoProduto
			// 
			this.lblDecricaoProduto.BackColor = System.Drawing.Color.Transparent;
			this.lblDecricaoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDecricaoProduto.ForeColor = System.Drawing.Color.White;
			this.lblDecricaoProduto.Location = new System.Drawing.Point(12, 32);
			this.lblDecricaoProduto.Name = "lblDecricaoProduto";
			this.lblDecricaoProduto.Size = new System.Drawing.Size(100, 23);
			this.lblDecricaoProduto.TabIndex = 1;
			this.lblDecricaoProduto.Text = "Descrição:";
			// 
			// lblCodigoProduto
			// 
			this.lblCodigoProduto.BackColor = System.Drawing.Color.Transparent;
			this.lblCodigoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCodigoProduto.ForeColor = System.Drawing.Color.White;
			this.lblCodigoProduto.Location = new System.Drawing.Point(12, 9);
			this.lblCodigoProduto.Name = "lblCodigoProduto";
			this.lblCodigoProduto.Size = new System.Drawing.Size(100, 23);
			this.lblCodigoProduto.TabIndex = 0;
			this.lblCodigoProduto.Text = "Codigo:";
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Location = new System.Drawing.Point(15, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(625, 145);
			this.panel2.TabIndex = 0;
			// 
			// frmCadastrarProduto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(649, 384);
			this.Controls.Add(this.panel1);
			this.MaximizeBox = false;
			this.Name = "frmCadastrarProduto";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "frmCadastrarProduto";
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
