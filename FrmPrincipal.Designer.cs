
namespace PDV
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuPrincinpal = new System.Windows.Forms.MenuStrip();
            this.MenuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFuncionários = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUsuários = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCargos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFluxoDeCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuLançarVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEntradasSa = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDespesas = new System.Windows.Forms.ToolStripMenuItem();
            this.reToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProdutosRel = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMovimentos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEntradasSaídasRel = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDespesasRel = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.img04 = new System.Windows.Forms.PictureBox();
            this.img03 = new System.Windows.Forms.PictureBox();
            this.img02 = new System.Windows.Forms.PictureBox();
            this.img01 = new System.Windows.Forms.PictureBox();
            this.MenuPrincinpal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img01)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPrincinpal
            // 
            this.MenuPrincinpal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadastro,
            this.MenuProduto,
            this.movimentaçõesToolStripMenuItem,
            this.reToolStripMenuItem,
            this.MenuSair});
            this.MenuPrincinpal.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincinpal.Name = "MenuPrincinpal";
            this.MenuPrincinpal.Size = new System.Drawing.Size(800, 24);
            this.MenuPrincinpal.TabIndex = 0;
            this.MenuPrincinpal.Text = "menuStrip1";
            // 
            // MenuCadastro
            // 
            this.MenuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFuncionários,
            this.MenuClientes,
            this.MenuUsuários,
            this.MenuCargos,
            this.MenuFornecedor});
            this.MenuCadastro.Name = "MenuCadastro";
            this.MenuCadastro.Size = new System.Drawing.Size(71, 20);
            this.MenuCadastro.Text = "Cadastros";
            // 
            // MenuFuncionários
            // 
            this.MenuFuncionários.Name = "MenuFuncionários";
            this.MenuFuncionários.Size = new System.Drawing.Size(142, 22);
            this.MenuFuncionários.Text = "Funcionários";
            this.MenuFuncionários.Click += new System.EventHandler(this.MenuFuncionários_Click);
            // 
            // MenuClientes
            // 
            this.MenuClientes.Name = "MenuClientes";
            this.MenuClientes.Size = new System.Drawing.Size(142, 22);
            this.MenuClientes.Text = "Clientes";
            // 
            // MenuUsuários
            // 
            this.MenuUsuários.Name = "MenuUsuários";
            this.MenuUsuários.Size = new System.Drawing.Size(142, 22);
            this.MenuUsuários.Text = "Usuários";
            // 
            // MenuCargos
            // 
            this.MenuCargos.Name = "MenuCargos";
            this.MenuCargos.Size = new System.Drawing.Size(142, 22);
            this.MenuCargos.Text = "Cargos";
            this.MenuCargos.Click += new System.EventHandler(this.MenuCargos_Click);
            // 
            // MenuFornecedor
            // 
            this.MenuFornecedor.Name = "MenuFornecedor";
            this.MenuFornecedor.Size = new System.Drawing.Size(142, 22);
            this.MenuFornecedor.Text = "Fornecedor";
            // 
            // MenuProduto
            // 
            this.MenuProduto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuProdutos,
            this.MenuEstoque});
            this.MenuProduto.Name = "MenuProduto";
            this.MenuProduto.Size = new System.Drawing.Size(67, 20);
            this.MenuProduto.Text = "Produtos";
            // 
            // MenuProdutos
            // 
            this.MenuProdutos.Name = "MenuProdutos";
            this.MenuProdutos.Size = new System.Drawing.Size(122, 22);
            this.MenuProdutos.Text = "Produtos";
            // 
            // MenuEstoque
            // 
            this.MenuEstoque.Name = "MenuEstoque";
            this.MenuEstoque.Size = new System.Drawing.Size(122, 22);
            this.MenuEstoque.Text = "Estoque";
            // 
            // movimentaçõesToolStripMenuItem
            // 
            this.movimentaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFluxoDeCaixa,
            this.MenuLançarVenda,
            this.MenuEntradasSa,
            this.MenuDespesas});
            this.movimentaçõesToolStripMenuItem.Name = "movimentaçõesToolStripMenuItem";
            this.movimentaçõesToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.movimentaçõesToolStripMenuItem.Text = "Movimentações";
            // 
            // MenuFluxoDeCaixa
            // 
            this.MenuFluxoDeCaixa.Name = "MenuFluxoDeCaixa";
            this.MenuFluxoDeCaixa.Size = new System.Drawing.Size(158, 22);
            this.MenuFluxoDeCaixa.Text = "Fluxo de caixa";
            // 
            // MenuLançarVenda
            // 
            this.MenuLançarVenda.Name = "MenuLançarVenda";
            this.MenuLançarVenda.Size = new System.Drawing.Size(158, 22);
            this.MenuLançarVenda.Text = "Lançar Venda";
            // 
            // MenuEntradasSa
            // 
            this.MenuEntradasSa.Name = "MenuEntradasSa";
            this.MenuEntradasSa.Size = new System.Drawing.Size(158, 22);
            this.MenuEntradasSa.Text = "Entradas / Saída";
            // 
            // MenuDespesas
            // 
            this.MenuDespesas.Name = "MenuDespesas";
            this.MenuDespesas.Size = new System.Drawing.Size(158, 22);
            this.MenuDespesas.Text = "Despesas";
            // 
            // reToolStripMenuItem
            // 
            this.reToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuProdutosRel,
            this.MenuVendas,
            this.MenuMovimentos,
            this.MenuEntradasSaídasRel,
            this.MenuDespesasRel});
            this.reToolStripMenuItem.Name = "reToolStripMenuItem";
            this.reToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.reToolStripMenuItem.Text = "Relatório";
            // 
            // MenuProdutosRel
            // 
            this.MenuProdutosRel.Name = "MenuProdutosRel";
            this.MenuProdutosRel.Size = new System.Drawing.Size(163, 22);
            this.MenuProdutosRel.Text = "Produtos";
            // 
            // MenuVendas
            // 
            this.MenuVendas.Name = "MenuVendas";
            this.MenuVendas.Size = new System.Drawing.Size(163, 22);
            this.MenuVendas.Text = "Vendas";
            // 
            // MenuMovimentos
            // 
            this.MenuMovimentos.Name = "MenuMovimentos";
            this.MenuMovimentos.Size = new System.Drawing.Size(163, 22);
            this.MenuMovimentos.Text = "Movimentos";
            // 
            // MenuEntradasSaídasRel
            // 
            this.MenuEntradasSaídasRel.Name = "MenuEntradasSaídasRel";
            this.MenuEntradasSaídasRel.Size = new System.Drawing.Size(163, 22);
            this.MenuEntradasSaídasRel.Text = "Entradas / Saídas";
            // 
            // MenuDespesasRel
            // 
            this.MenuDespesasRel.Name = "MenuDespesasRel";
            this.MenuDespesasRel.Size = new System.Drawing.Size(163, 22);
            this.MenuDespesasRel.Text = "Despesas";
            // 
            // MenuSair
            // 
            this.MenuSair.Name = "MenuSair";
            this.MenuSair.Size = new System.Drawing.Size(38, 20);
            this.MenuSair.Text = "Sair";
            this.MenuSair.Click += new System.EventHandler(this.MenuSair_Click);
            // 
            // img04
            // 
            this.img04.Image = global::PDV.Properties.Resources.sair;
            this.img04.Location = new System.Drawing.Point(481, 249);
            this.img04.Name = "img04";
            this.img04.Size = new System.Drawing.Size(224, 164);
            this.img04.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img04.TabIndex = 4;
            this.img04.TabStop = false;
            // 
            // img03
            // 
            this.img03.Image = global::PDV.Properties.Resources.movimentacao;
            this.img03.Location = new System.Drawing.Point(126, 249);
            this.img03.Name = "img03";
            this.img03.Size = new System.Drawing.Size(227, 164);
            this.img03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img03.TabIndex = 3;
            this.img03.TabStop = false;
            // 
            // img02
            // 
            this.img02.Image = global::PDV.Properties.Resources.produto;
            this.img02.Location = new System.Drawing.Point(481, 46);
            this.img02.Name = "img02";
            this.img02.Size = new System.Drawing.Size(224, 172);
            this.img02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img02.TabIndex = 2;
            this.img02.TabStop = false;
            // 
            // img01
            // 
            this.img01.Image = global::PDV.Properties.Resources.cadastro;
            this.img01.Location = new System.Drawing.Point(139, 46);
            this.img01.Name = "img01";
            this.img01.Size = new System.Drawing.Size(214, 172);
            this.img01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img01.TabIndex = 1;
            this.img01.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.img04);
            this.Controls.Add(this.img03);
            this.Controls.Add(this.img02);
            this.Controls.Add(this.img01);
            this.Controls.Add(this.MenuPrincinpal);
            this.MainMenuStrip = this.MenuPrincinpal;
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            
            this.MenuPrincinpal.ResumeLayout(false);
            this.MenuPrincinpal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img01)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuPrincinpal;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastro;
        private System.Windows.Forms.ToolStripMenuItem MenuProduto;
        private System.Windows.Forms.ToolStripMenuItem movimentaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuSair;
        private System.Windows.Forms.PictureBox img01;
        private System.Windows.Forms.PictureBox img02;
        private System.Windows.Forms.PictureBox img03;
        private System.Windows.Forms.PictureBox img04;
        private System.Windows.Forms.ToolStripMenuItem MenuFuncionários;
        private System.Windows.Forms.ToolStripMenuItem MenuClientes;
        private System.Windows.Forms.ToolStripMenuItem MenuUsuários;
        private System.Windows.Forms.ToolStripMenuItem MenuCargos;
        private System.Windows.Forms.ToolStripMenuItem MenuFornecedor;
        private System.Windows.Forms.ToolStripMenuItem MenuProdutos;
        private System.Windows.Forms.ToolStripMenuItem MenuEstoque;
        private System.Windows.Forms.ToolStripMenuItem MenuFluxoDeCaixa;
        private System.Windows.Forms.ToolStripMenuItem MenuLançarVenda;
        private System.Windows.Forms.ToolStripMenuItem MenuEntradasSa;
        private System.Windows.Forms.ToolStripMenuItem MenuDespesas;
        private System.Windows.Forms.ToolStripMenuItem MenuProdutosRel;
        private System.Windows.Forms.ToolStripMenuItem MenuVendas;
        private System.Windows.Forms.ToolStripMenuItem MenuMovimentos;
        private System.Windows.Forms.ToolStripMenuItem MenuEntradasSaídasRel;
        private System.Windows.Forms.ToolStripMenuItem MenuDespesasRel;
    }
}

