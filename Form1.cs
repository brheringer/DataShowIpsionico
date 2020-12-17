using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DataShowIpsionico
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox grupoPalestra;
		private System.Windows.Forms.GroupBox grupoMusicas;
		private System.Windows.Forms.TextBox caixaFundoPalestra;
		private System.Windows.Forms.Button botaoFundoPalestra;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox caixaArquivoPalestra;
		private System.Windows.Forms.Button botaoArquivoPalestra;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox caixaFundoMusicas;
		private System.Windows.Forms.Button botaoFundoMusicas;
		private System.Windows.Forms.ListView listaMusicasPrimeiraParte;
		private System.Windows.Forms.Button botaoMusicas1;
		private System.Windows.Forms.Button botaoMusicas2;
		private System.Windows.Forms.Button botaoExcluirMusica1;
		private System.Windows.Forms.Button botaoExcluirMusicas2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox caixaFontePalestra;
		private System.Windows.Forms.Button botaoFontePalestra;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox caixaFonteMusicas;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button BotaoImagemAbertura;
		private System.Windows.Forms.Button botaoImagemCriancas;
		private System.Windows.Forms.TextBox caixaImagemAbertura;
		private System.Windows.Forms.TextBox caixaImagemCriancas;
		private System.Windows.Forms.Button botaoFonteMusicas;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView listaMusicasSegundaParte;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox caixaArquivoModelo;
		private System.Windows.Forms.Button botaoArquivoModelo;
		private System.Windows.Forms.Button botaoCimaLista1;
		private System.Windows.Forms.Button botaoBaixoLista1;
		private System.Windows.Forms.Button botaoBaixoLista2;
		private System.Windows.Forms.Button botaoCimaLista2;
		private System.Windows.Forms.CheckBox slidesEntreMusicas;
		private System.Windows.Forms.Button botaoCorSombra;
		private System.Windows.Forms.CheckBox checkSombreamento;
		private System.Windows.Forms.Button botaoCorPalestra;
		private System.Windows.Forms.Button botaoCorMusicas;
		private System.Windows.Forms.Label lblMusicasSegundaParte;
		private System.Windows.Forms.Label lblMusicasPrimeiraParte;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button botaoImagemInicial;
		private System.Windows.Forms.TextBox caixaImagemInicial;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuAbrirProjeto;
		private System.Windows.Forms.MenuItem menuSalvarProjeto;
		private System.Windows.Forms.MenuItem menuSalvarProjetoComo;
		private System.Windows.Forms.MenuItem menuSair;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuSobre;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			CarregarEstado(ARQUIVO_XML);
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.button1 = new System.Windows.Forms.Button();
			this.grupoPalestra = new System.Windows.Forms.GroupBox();
			this.botaoCorPalestra = new System.Windows.Forms.Button();
			this.caixaFontePalestra = new System.Windows.Forms.TextBox();
			this.botaoFontePalestra = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.botaoArquivoPalestra = new System.Windows.Forms.Button();
			this.caixaArquivoPalestra = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.caixaFundoPalestra = new System.Windows.Forms.TextBox();
			this.botaoFundoPalestra = new System.Windows.Forms.Button();
			this.grupoMusicas = new System.Windows.Forms.GroupBox();
			this.botaoCorMusicas = new System.Windows.Forms.Button();
			this.slidesEntreMusicas = new System.Windows.Forms.CheckBox();
			this.botaoBaixoLista2 = new System.Windows.Forms.Button();
			this.botaoCimaLista2 = new System.Windows.Forms.Button();
			this.botaoBaixoLista1 = new System.Windows.Forms.Button();
			this.botaoCimaLista1 = new System.Windows.Forms.Button();
			this.listaMusicasSegundaParte = new System.Windows.Forms.ListView();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.caixaFonteMusicas = new System.Windows.Forms.TextBox();
			this.botaoFonteMusicas = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.botaoExcluirMusicas2 = new System.Windows.Forms.Button();
			this.botaoExcluirMusica1 = new System.Windows.Forms.Button();
			this.botaoMusicas2 = new System.Windows.Forms.Button();
			this.botaoMusicas1 = new System.Windows.Forms.Button();
			this.lblMusicasSegundaParte = new System.Windows.Forms.Label();
			this.listaMusicasPrimeiraParte = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.lblMusicasPrimeiraParte = new System.Windows.Forms.Label();
			this.botaoFundoMusicas = new System.Windows.Forms.Button();
			this.caixaFundoMusicas = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.checkSombreamento = new System.Windows.Forms.CheckBox();
			this.botaoCorSombra = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.caixaImagemInicial = new System.Windows.Forms.TextBox();
			this.botaoImagemInicial = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.caixaImagemCriancas = new System.Windows.Forms.TextBox();
			this.caixaImagemAbertura = new System.Windows.Forms.TextBox();
			this.botaoImagemCriancas = new System.Windows.Forms.Button();
			this.BotaoImagemAbertura = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.caixaArquivoModelo = new System.Windows.Forms.TextBox();
			this.botaoArquivoModelo = new System.Windows.Forms.Button();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuAbrirProjeto = new System.Windows.Forms.MenuItem();
			this.menuSalvarProjeto = new System.Windows.Forms.MenuItem();
			this.menuSalvarProjetoComo = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuSair = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuSobre = new System.Windows.Forms.MenuItem();
			this.grupoPalestra.SuspendLayout();
			this.grupoMusicas.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(16, 504);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(488, 23);
			this.button1.TabIndex = 27;
			this.button1.Text = "Montar Slides";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// grupoPalestra
			// 
			this.grupoPalestra.Controls.Add(this.botaoCorPalestra);
			this.grupoPalestra.Controls.Add(this.caixaFontePalestra);
			this.grupoPalestra.Controls.Add(this.botaoFontePalestra);
			this.grupoPalestra.Controls.Add(this.label6);
			this.grupoPalestra.Controls.Add(this.botaoArquivoPalestra);
			this.grupoPalestra.Controls.Add(this.caixaArquivoPalestra);
			this.grupoPalestra.Controls.Add(this.label2);
			this.grupoPalestra.Controls.Add(this.label1);
			this.grupoPalestra.Controls.Add(this.caixaFundoPalestra);
			this.grupoPalestra.Controls.Add(this.botaoFundoPalestra);
			this.grupoPalestra.Location = new System.Drawing.Point(8, 104);
			this.grupoPalestra.Name = "grupoPalestra";
			this.grupoPalestra.Size = new System.Drawing.Size(504, 96);
			this.grupoPalestra.TabIndex = 1;
			this.grupoPalestra.TabStop = false;
			this.grupoPalestra.Text = "Palestra";
			// 
			// botaoCorPalestra
			// 
			this.botaoCorPalestra.BackColor = System.Drawing.Color.Black;
			this.botaoCorPalestra.ForeColor = System.Drawing.Color.White;
			this.botaoCorPalestra.Location = new System.Drawing.Point(144, 64);
			this.botaoCorPalestra.Name = "botaoCorPalestra";
			this.botaoCorPalestra.Size = new System.Drawing.Size(32, 20);
			this.botaoCorPalestra.TabIndex = 28;
			this.botaoCorPalestra.Text = "cor";
			this.botaoCorPalestra.Click += new System.EventHandler(this.botaoCorPalestra_Click);
			// 
			// caixaFontePalestra
			// 
			this.caixaFontePalestra.Location = new System.Drawing.Point(176, 64);
			this.caixaFontePalestra.Name = "caixaFontePalestra";
			this.caixaFontePalestra.Size = new System.Drawing.Size(320, 20);
			this.caixaFontePalestra.TabIndex = 10;
			this.caixaFontePalestra.TabStop = false;
			this.caixaFontePalestra.Text = "";
			// 
			// botaoFontePalestra
			// 
			this.botaoFontePalestra.Image = ((System.Drawing.Image)(resources.GetObject("botaoFontePalestra.Image")));
			this.botaoFontePalestra.Location = new System.Drawing.Point(112, 64);
			this.botaoFontePalestra.Name = "botaoFontePalestra";
			this.botaoFontePalestra.Size = new System.Drawing.Size(32, 24);
			this.botaoFontePalestra.TabIndex = 9;
			this.botaoFontePalestra.Click += new System.EventHandler(this.botaoFontePalestra_Click);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 64);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(112, 20);
			this.label6.TabIndex = 6;
			this.label6.Text = "Fonte da Palestra:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// botaoArquivoPalestra
			// 
			this.botaoArquivoPalestra.Image = ((System.Drawing.Image)(resources.GetObject("botaoArquivoPalestra.Image")));
			this.botaoArquivoPalestra.Location = new System.Drawing.Point(112, 40);
			this.botaoArquivoPalestra.Name = "botaoArquivoPalestra";
			this.botaoArquivoPalestra.Size = new System.Drawing.Size(32, 20);
			this.botaoArquivoPalestra.TabIndex = 7;
			this.botaoArquivoPalestra.Click += new System.EventHandler(this.botaoArquivoPalestra_Click);
			// 
			// caixaArquivoPalestra
			// 
			this.caixaArquivoPalestra.Location = new System.Drawing.Point(144, 40);
			this.caixaArquivoPalestra.Name = "caixaArquivoPalestra";
			this.caixaArquivoPalestra.Size = new System.Drawing.Size(352, 20);
			this.caixaArquivoPalestra.TabIndex = 8;
			this.caixaArquivoPalestra.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Arquivo da Palestra:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Fundo da Palestra:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// caixaFundoPalestra
			// 
			this.caixaFundoPalestra.Location = new System.Drawing.Point(144, 16);
			this.caixaFundoPalestra.Name = "caixaFundoPalestra";
			this.caixaFundoPalestra.Size = new System.Drawing.Size(352, 20);
			this.caixaFundoPalestra.TabIndex = 6;
			this.caixaFundoPalestra.Text = "";
			// 
			// botaoFundoPalestra
			// 
			this.botaoFundoPalestra.Image = ((System.Drawing.Image)(resources.GetObject("botaoFundoPalestra.Image")));
			this.botaoFundoPalestra.Location = new System.Drawing.Point(112, 16);
			this.botaoFundoPalestra.Name = "botaoFundoPalestra";
			this.botaoFundoPalestra.Size = new System.Drawing.Size(32, 20);
			this.botaoFundoPalestra.TabIndex = 5;
			this.botaoFundoPalestra.Click += new System.EventHandler(this.botaoFundoPalestra_Click);
			// 
			// grupoMusicas
			// 
			this.grupoMusicas.Controls.Add(this.botaoCorMusicas);
			this.grupoMusicas.Controls.Add(this.slidesEntreMusicas);
			this.grupoMusicas.Controls.Add(this.botaoBaixoLista2);
			this.grupoMusicas.Controls.Add(this.botaoCimaLista2);
			this.grupoMusicas.Controls.Add(this.botaoBaixoLista1);
			this.grupoMusicas.Controls.Add(this.botaoCimaLista1);
			this.grupoMusicas.Controls.Add(this.listaMusicasSegundaParte);
			this.grupoMusicas.Controls.Add(this.caixaFonteMusicas);
			this.grupoMusicas.Controls.Add(this.botaoFonteMusicas);
			this.grupoMusicas.Controls.Add(this.label7);
			this.grupoMusicas.Controls.Add(this.botaoExcluirMusicas2);
			this.grupoMusicas.Controls.Add(this.botaoExcluirMusica1);
			this.grupoMusicas.Controls.Add(this.botaoMusicas2);
			this.grupoMusicas.Controls.Add(this.botaoMusicas1);
			this.grupoMusicas.Controls.Add(this.lblMusicasSegundaParte);
			this.grupoMusicas.Controls.Add(this.listaMusicasPrimeiraParte);
			this.grupoMusicas.Controls.Add(this.lblMusicasPrimeiraParte);
			this.grupoMusicas.Controls.Add(this.botaoFundoMusicas);
			this.grupoMusicas.Controls.Add(this.caixaFundoMusicas);
			this.grupoMusicas.Controls.Add(this.label3);
			this.grupoMusicas.Location = new System.Drawing.Point(8, 208);
			this.grupoMusicas.Name = "grupoMusicas";
			this.grupoMusicas.Size = new System.Drawing.Size(504, 224);
			this.grupoMusicas.TabIndex = 2;
			this.grupoMusicas.TabStop = false;
			this.grupoMusicas.Text = "Louvor";
			// 
			// botaoCorMusicas
			// 
			this.botaoCorMusicas.BackColor = System.Drawing.Color.Black;
			this.botaoCorMusicas.ForeColor = System.Drawing.Color.White;
			this.botaoCorMusicas.Location = new System.Drawing.Point(144, 168);
			this.botaoCorMusicas.Name = "botaoCorMusicas";
			this.botaoCorMusicas.Size = new System.Drawing.Size(32, 20);
			this.botaoCorMusicas.TabIndex = 28;
			this.botaoCorMusicas.Text = "cor";
			this.botaoCorMusicas.Click += new System.EventHandler(this.botaoCorMusicas_Click);
			// 
			// slidesEntreMusicas
			// 
			this.slidesEntreMusicas.Checked = true;
			this.slidesEntreMusicas.CheckState = System.Windows.Forms.CheckState.Checked;
			this.slidesEntreMusicas.Location = new System.Drawing.Point(8, 192);
			this.slidesEntreMusicas.Name = "slidesEntreMusicas";
			this.slidesEntreMusicas.Size = new System.Drawing.Size(216, 24);
			this.slidesEntreMusicas.TabIndex = 25;
			this.slidesEntreMusicas.Text = "Gerar slides vazios entre as músicas";
			// 
			// botaoBaixoLista2
			// 
			this.botaoBaixoLista2.Image = ((System.Drawing.Image)(resources.GetObject("botaoBaixoLista2.Image")));
			this.botaoBaixoLista2.Location = new System.Drawing.Point(256, 136);
			this.botaoBaixoLista2.Name = "botaoBaixoLista2";
			this.botaoBaixoLista2.Size = new System.Drawing.Size(24, 24);
			this.botaoBaixoLista2.TabIndex = 21;
			this.botaoBaixoLista2.Click += new System.EventHandler(this.botaoBaixoLista2_Click);
			// 
			// botaoCimaLista2
			// 
			this.botaoCimaLista2.Image = ((System.Drawing.Image)(resources.GetObject("botaoCimaLista2.Image")));
			this.botaoCimaLista2.Location = new System.Drawing.Point(256, 112);
			this.botaoCimaLista2.Name = "botaoCimaLista2";
			this.botaoCimaLista2.Size = new System.Drawing.Size(24, 24);
			this.botaoCimaLista2.TabIndex = 20;
			this.botaoCimaLista2.Click += new System.EventHandler(this.botaoCimaLista2_Click);
			// 
			// botaoBaixoLista1
			// 
			this.botaoBaixoLista1.Image = ((System.Drawing.Image)(resources.GetObject("botaoBaixoLista1.Image")));
			this.botaoBaixoLista1.Location = new System.Drawing.Point(8, 136);
			this.botaoBaixoLista1.Name = "botaoBaixoLista1";
			this.botaoBaixoLista1.Size = new System.Drawing.Size(24, 24);
			this.botaoBaixoLista1.TabIndex = 16;
			this.botaoBaixoLista1.Click += new System.EventHandler(this.botaoBaixoLista1_Click);
			// 
			// botaoCimaLista1
			// 
			this.botaoCimaLista1.Image = ((System.Drawing.Image)(resources.GetObject("botaoCimaLista1.Image")));
			this.botaoCimaLista1.Location = new System.Drawing.Point(8, 112);
			this.botaoCimaLista1.Name = "botaoCimaLista1";
			this.botaoCimaLista1.Size = new System.Drawing.Size(24, 24);
			this.botaoCimaLista1.TabIndex = 15;
			this.botaoCimaLista1.Click += new System.EventHandler(this.botaoCimaLista1_Click);
			// 
			// listaMusicasSegundaParte
			// 
			this.listaMusicasSegundaParte.AllowDrop = true;
			this.listaMusicasSegundaParte.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																									   this.columnHeader2});
			this.listaMusicasSegundaParte.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.listaMusicasSegundaParte.HideSelection = false;
			this.listaMusicasSegundaParte.Location = new System.Drawing.Point(280, 64);
			this.listaMusicasSegundaParte.Name = "listaMusicasSegundaParte";
			this.listaMusicasSegundaParte.Size = new System.Drawing.Size(216, 97);
			this.listaMusicasSegundaParte.TabIndex = 22;
			this.listaMusicasSegundaParte.View = System.Windows.Forms.View.Details;
			this.listaMusicasSegundaParte.DragDrop += new System.Windows.Forms.DragEventHandler(this.listaMusicasSegundaParte_DragDrop);
			this.listaMusicasSegundaParte.DragEnter += new System.Windows.Forms.DragEventHandler(this.listaMusicasSegundaParte_DragEnter);
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Arquivo";
			this.columnHeader2.Width = 512;
			// 
			// caixaFonteMusicas
			// 
			this.caixaFonteMusicas.Location = new System.Drawing.Point(176, 168);
			this.caixaFonteMusicas.Name = "caixaFonteMusicas";
			this.caixaFonteMusicas.Size = new System.Drawing.Size(320, 20);
			this.caixaFonteMusicas.TabIndex = 24;
			this.caixaFonteMusicas.TabStop = false;
			this.caixaFonteMusicas.Text = "";
			// 
			// botaoFonteMusicas
			// 
			this.botaoFonteMusicas.Image = ((System.Drawing.Image)(resources.GetObject("botaoFonteMusicas.Image")));
			this.botaoFonteMusicas.Location = new System.Drawing.Point(112, 168);
			this.botaoFonteMusicas.Name = "botaoFonteMusicas";
			this.botaoFonteMusicas.Size = new System.Drawing.Size(32, 24);
			this.botaoFonteMusicas.TabIndex = 23;
			this.botaoFonteMusicas.Click += new System.EventHandler(this.botaoFonteMusicas_Click);
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(8, 168);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(112, 20);
			this.label7.TabIndex = 16;
			this.label7.Text = "Fonte das Músicas:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// botaoExcluirMusicas2
			// 
			this.botaoExcluirMusicas2.Image = ((System.Drawing.Image)(resources.GetObject("botaoExcluirMusicas2.Image")));
			this.botaoExcluirMusicas2.Location = new System.Drawing.Point(256, 88);
			this.botaoExcluirMusicas2.Name = "botaoExcluirMusicas2";
			this.botaoExcluirMusicas2.Size = new System.Drawing.Size(24, 24);
			this.botaoExcluirMusicas2.TabIndex = 19;
			this.botaoExcluirMusicas2.Click += new System.EventHandler(this.botaoExcluirMusicas2_Click);
			// 
			// botaoExcluirMusica1
			// 
			this.botaoExcluirMusica1.Image = ((System.Drawing.Image)(resources.GetObject("botaoExcluirMusica1.Image")));
			this.botaoExcluirMusica1.Location = new System.Drawing.Point(8, 88);
			this.botaoExcluirMusica1.Name = "botaoExcluirMusica1";
			this.botaoExcluirMusica1.Size = new System.Drawing.Size(24, 24);
			this.botaoExcluirMusica1.TabIndex = 14;
			this.botaoExcluirMusica1.Click += new System.EventHandler(this.botaoExcluirMusica1_Click);
			// 
			// botaoMusicas2
			// 
			this.botaoMusicas2.Image = ((System.Drawing.Image)(resources.GetObject("botaoMusicas2.Image")));
			this.botaoMusicas2.Location = new System.Drawing.Point(256, 64);
			this.botaoMusicas2.Name = "botaoMusicas2";
			this.botaoMusicas2.Size = new System.Drawing.Size(24, 24);
			this.botaoMusicas2.TabIndex = 18;
			this.botaoMusicas2.Click += new System.EventHandler(this.botaoMusicas2_Click);
			// 
			// botaoMusicas1
			// 
			this.botaoMusicas1.Image = ((System.Drawing.Image)(resources.GetObject("botaoMusicas1.Image")));
			this.botaoMusicas1.Location = new System.Drawing.Point(8, 64);
			this.botaoMusicas1.Name = "botaoMusicas1";
			this.botaoMusicas1.Size = new System.Drawing.Size(24, 24);
			this.botaoMusicas1.TabIndex = 13;
			this.botaoMusicas1.Click += new System.EventHandler(this.botaoMusicas1_Click);
			// 
			// lblMusicasSegundaParte
			// 
			this.lblMusicasSegundaParte.Location = new System.Drawing.Point(256, 40);
			this.lblMusicasSegundaParte.Name = "lblMusicasSegundaParte";
			this.lblMusicasSegundaParte.Size = new System.Drawing.Size(112, 20);
			this.lblMusicasSegundaParte.TabIndex = 10;
			this.lblMusicasSegundaParte.Text = "Músicas 2a parte:";
			this.lblMusicasSegundaParte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// listaMusicasPrimeiraParte
			// 
			this.listaMusicasPrimeiraParte.AllowDrop = true;
			this.listaMusicasPrimeiraParte.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																										this.columnHeader1});
			this.listaMusicasPrimeiraParte.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.listaMusicasPrimeiraParte.HideSelection = false;
			this.listaMusicasPrimeiraParte.Location = new System.Drawing.Point(32, 64);
			this.listaMusicasPrimeiraParte.Name = "listaMusicasPrimeiraParte";
			this.listaMusicasPrimeiraParte.Size = new System.Drawing.Size(216, 97);
			this.listaMusicasPrimeiraParte.TabIndex = 17;
			this.listaMusicasPrimeiraParte.View = System.Windows.Forms.View.Details;
			this.listaMusicasPrimeiraParte.DragDrop += new System.Windows.Forms.DragEventHandler(this.listaMusicasPrimeiraParte_DragDrop);
			this.listaMusicasPrimeiraParte.DragEnter += new System.Windows.Forms.DragEventHandler(this.listaMusicasPrimeiraParte_DragEnter);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Arquivo";
			this.columnHeader1.Width = 512;
			// 
			// lblMusicasPrimeiraParte
			// 
			this.lblMusicasPrimeiraParte.Location = new System.Drawing.Point(8, 40);
			this.lblMusicasPrimeiraParte.Name = "lblMusicasPrimeiraParte";
			this.lblMusicasPrimeiraParte.Size = new System.Drawing.Size(112, 20);
			this.lblMusicasPrimeiraParte.TabIndex = 7;
			this.lblMusicasPrimeiraParte.Text = "Músicas 1a parte:";
			this.lblMusicasPrimeiraParte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// botaoFundoMusicas
			// 
			this.botaoFundoMusicas.Image = ((System.Drawing.Image)(resources.GetObject("botaoFundoMusicas.Image")));
			this.botaoFundoMusicas.Location = new System.Drawing.Point(112, 16);
			this.botaoFundoMusicas.Name = "botaoFundoMusicas";
			this.botaoFundoMusicas.Size = new System.Drawing.Size(32, 20);
			this.botaoFundoMusicas.TabIndex = 11;
			this.botaoFundoMusicas.Click += new System.EventHandler(this.botaoFundoMusicas_Click);
			// 
			// caixaFundoMusicas
			// 
			this.caixaFundoMusicas.Location = new System.Drawing.Point(144, 16);
			this.caixaFundoMusicas.Name = "caixaFundoMusicas";
			this.caixaFundoMusicas.Size = new System.Drawing.Size(352, 20);
			this.caixaFundoMusicas.TabIndex = 12;
			this.caixaFundoMusicas.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(112, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "Fundo das Músicas:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// checkSombreamento
			// 
			this.checkSombreamento.Location = new System.Drawing.Point(16, 440);
			this.checkSombreamento.Name = "checkSombreamento";
			this.checkSombreamento.TabIndex = 28;
			this.checkSombreamento.Text = "Sombreamento";
			// 
			// botaoCorSombra
			// 
			this.botaoCorSombra.BackColor = System.Drawing.Color.Black;
			this.botaoCorSombra.ForeColor = System.Drawing.Color.White;
			this.botaoCorSombra.Location = new System.Drawing.Point(120, 440);
			this.botaoCorSombra.Name = "botaoCorSombra";
			this.botaoCorSombra.Size = new System.Drawing.Size(32, 20);
			this.botaoCorSombra.TabIndex = 27;
			this.botaoCorSombra.Text = "cor";
			this.botaoCorSombra.Click += new System.EventHandler(this.botaoCorSombra_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.caixaImagemInicial);
			this.groupBox1.Controls.Add(this.botaoImagemInicial);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.caixaImagemCriancas);
			this.groupBox1.Controls.Add(this.caixaImagemAbertura);
			this.groupBox1.Controls.Add(this.botaoImagemCriancas);
			this.groupBox1.Controls.Add(this.BotaoImagemAbertura);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Location = new System.Drawing.Point(8, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(504, 96);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			// 
			// caixaImagemInicial
			// 
			this.caixaImagemInicial.Location = new System.Drawing.Point(144, 16);
			this.caixaImagemInicial.Name = "caixaImagemInicial";
			this.caixaImagemInicial.Size = new System.Drawing.Size(352, 20);
			this.caixaImagemInicial.TabIndex = 7;
			this.caixaImagemInicial.Text = "";
			// 
			// botaoImagemInicial
			// 
			this.botaoImagemInicial.Image = ((System.Drawing.Image)(resources.GetObject("botaoImagemInicial.Image")));
			this.botaoImagemInicial.Location = new System.Drawing.Point(112, 16);
			this.botaoImagemInicial.Name = "botaoImagemInicial";
			this.botaoImagemInicial.Size = new System.Drawing.Size(32, 20);
			this.botaoImagemInicial.TabIndex = 6;
			this.botaoImagemInicial.Click += new System.EventHandler(this.botaoImagemInicial_Click);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(96, 20);
			this.label4.TabIndex = 5;
			this.label4.Text = "Imagem Inicial:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// caixaImagemCriancas
			// 
			this.caixaImagemCriancas.Location = new System.Drawing.Point(144, 64);
			this.caixaImagemCriancas.Name = "caixaImagemCriancas";
			this.caixaImagemCriancas.Size = new System.Drawing.Size(352, 20);
			this.caixaImagemCriancas.TabIndex = 4;
			this.caixaImagemCriancas.Text = "";
			// 
			// caixaImagemAbertura
			// 
			this.caixaImagemAbertura.Location = new System.Drawing.Point(144, 40);
			this.caixaImagemAbertura.Name = "caixaImagemAbertura";
			this.caixaImagemAbertura.Size = new System.Drawing.Size(352, 20);
			this.caixaImagemAbertura.TabIndex = 2;
			this.caixaImagemAbertura.Text = "";
			// 
			// botaoImagemCriancas
			// 
			this.botaoImagemCriancas.Image = ((System.Drawing.Image)(resources.GetObject("botaoImagemCriancas.Image")));
			this.botaoImagemCriancas.Location = new System.Drawing.Point(112, 64);
			this.botaoImagemCriancas.Name = "botaoImagemCriancas";
			this.botaoImagemCriancas.Size = new System.Drawing.Size(32, 20);
			this.botaoImagemCriancas.TabIndex = 3;
			this.botaoImagemCriancas.Click += new System.EventHandler(this.botaoImagemCriancas_Click);
			// 
			// BotaoImagemAbertura
			// 
			this.BotaoImagemAbertura.Image = ((System.Drawing.Image)(resources.GetObject("BotaoImagemAbertura.Image")));
			this.BotaoImagemAbertura.Location = new System.Drawing.Point(112, 40);
			this.BotaoImagemAbertura.Name = "BotaoImagemAbertura";
			this.BotaoImagemAbertura.Size = new System.Drawing.Size(32, 20);
			this.BotaoImagemAbertura.TabIndex = 1;
			this.BotaoImagemAbertura.Click += new System.EventHandler(this.BotaoImagemAbertura_Click);
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(8, 64);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(120, 20);
			this.label9.TabIndex = 4;
			this.label9.Text = "Imagem Crianças:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(8, 40);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(96, 20);
			this.label8.TabIndex = 3;
			this.label8.Text = "Imagem Tema:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(16, 472);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(112, 20);
			this.label10.TabIndex = 22;
			this.label10.Text = "PPT modelo:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// caixaArquivoModelo
			// 
			this.caixaArquivoModelo.Enabled = false;
			this.caixaArquivoModelo.Location = new System.Drawing.Point(152, 472);
			this.caixaArquivoModelo.Name = "caixaArquivoModelo";
			this.caixaArquivoModelo.Size = new System.Drawing.Size(352, 20);
			this.caixaArquivoModelo.TabIndex = 26;
			this.caixaArquivoModelo.Text = "";
			// 
			// botaoArquivoModelo
			// 
			this.botaoArquivoModelo.Image = ((System.Drawing.Image)(resources.GetObject("botaoArquivoModelo.Image")));
			this.botaoArquivoModelo.Location = new System.Drawing.Point(120, 472);
			this.botaoArquivoModelo.Name = "botaoArquivoModelo";
			this.botaoArquivoModelo.Size = new System.Drawing.Size(32, 20);
			this.botaoArquivoModelo.TabIndex = 25;
			this.botaoArquivoModelo.Click += new System.EventHandler(this.botaoArquivoModelo_Click);
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1,
																					  this.menuItem2});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuAbrirProjeto,
																					  this.menuSalvarProjeto,
																					  this.menuSalvarProjetoComo,
																					  this.menuItem5,
																					  this.menuSair});
			this.menuItem1.Text = "Arquivo";
			// 
			// menuAbrirProjeto
			// 
			this.menuAbrirProjeto.Index = 0;
			this.menuAbrirProjeto.Text = "Abrir projeto...";
			this.menuAbrirProjeto.Click += new System.EventHandler(this.menuAbrirProjeto_Click);
			// 
			// menuSalvarProjeto
			// 
			this.menuSalvarProjeto.Index = 1;
			this.menuSalvarProjeto.Text = "Salvar projeto";
			this.menuSalvarProjeto.Click += new System.EventHandler(this.menuSalvarProjeto_Click);
			// 
			// menuSalvarProjetoComo
			// 
			this.menuSalvarProjetoComo.Index = 2;
			this.menuSalvarProjetoComo.Text = "Salvar projeto como...";
			this.menuSalvarProjetoComo.Click += new System.EventHandler(this.menuSalvarProjetoComo_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 3;
			this.menuItem5.Text = "-";
			// 
			// menuSair
			// 
			this.menuSair.Index = 4;
			this.menuSair.Text = "Sair";
			this.menuSair.Click += new System.EventHandler(this.menuSair_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 1;
			this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuSobre});
			this.menuItem2.Text = "Ajuda";
			// 
			// menuSobre
			// 
			this.menuSobre.Index = 0;
			this.menuSobre.Text = "Sobre...";
			// 
			// Form1
			// 
			this.AllowDrop = true;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(520, 533);
			this.Controls.Add(this.botaoArquivoModelo);
			this.Controls.Add(this.caixaArquivoModelo);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.grupoMusicas);
			this.Controls.Add(this.grupoPalestra);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.botaoCorSombra);
			this.Controls.Add(this.checkSombreamento);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "Construtor de Slides";
			this.grupoPalestra.ResumeLayout(false);
			this.grupoMusicas.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}


		#region Atributos
		private Font fonteMusicas = null;
		//private Color corFonteMusicas = Color.White;
		private Font fontePalestra = null;
		//private Color corFontePalestra = Color.White;
		private string ARQUIVO_XML = System.IO.Path.Combine(Application.StartupPath, @"DataShowIpsionico.xml");
		private string projetoAberto = null;
		#endregion

		#region Eventos
		private void button1_Click(object sender, System.EventArgs e)
		{
			try 
			{
				ApresentacaoIpsionica dados = PrepararDados();
				SalvarEstado(ARQUIVO_XML, dados);
				ControlePowerPoint cpp = new ControlePowerPoint(dados, caixaArquivoModelo.Text);
				cpp.MontarApresentacao();
			} 
			catch(Exception ex) 
			{
				MessageBox.Show(this, ex.Message);
			}
		}

		private void botaoArquivoModelo_Click(object sender, System.EventArgs e)
		{
			string filtro = "Apresentações do Power Point|*.ppt";
			string[] arquivosEscolhidos = EscolherArquivos(filtro, false);
			if( (arquivosEscolhidos != null) && (arquivosEscolhidos.Length > 0) )
				caixaArquivoModelo.Text = arquivosEscolhidos[0];
		}

		private void botaoArquivoPalestra_Click(object sender, System.EventArgs e)
		{
			string filtro = "Apresentações do Power Point|*.ppt";
			string[] arquivosEscolhidos = EscolherArquivos(filtro, false);
			if( (arquivosEscolhidos != null) && (arquivosEscolhidos.Length > 0) )
				caixaArquivoPalestra.Text = arquivosEscolhidos[0];
		}

		private void botaoBaixoLista1_Click(object sender, System.EventArgs e)
		{
			MoverMusicasSelecionadas(listaMusicasPrimeiraParte, false);
		}
		private void botaoBaixoLista2_Click(object sender, System.EventArgs e)
		{
			MoverMusicasSelecionadas(listaMusicasSegundaParte, false);
		}
		private void botaoCimaLista1_Click(object sender, System.EventArgs e)
		{
			MoverMusicasSelecionadas(listaMusicasPrimeiraParte, true);
		}
		private void botaoCimaLista2_Click(object sender, System.EventArgs e)
		{
			MoverMusicasSelecionadas(listaMusicasSegundaParte, true);
		}
		private void botaoCorMusicas_Click(object sender, System.EventArgs e)
		{
			object cor = EscolherCor();
			if( cor != null ) 
			{
				MostrarCorBotao(botaoCorMusicas, (Color)cor);
				caixaFonteMusicas.ForeColor = (Color)cor;
			}
		}
		private void botaoCorPalestra_Click(object sender, System.EventArgs e)
		{
			object cor = EscolherCor();
			if( cor != null ) 
			{
				MostrarCorBotao(botaoCorPalestra, (Color)cor);
				caixaFontePalestra.ForeColor = (Color)cor;
			}
		}
		private void botaoCorSombra_Click(object sender, System.EventArgs e)
		{
			object cor = EscolherCor();
			if( cor != null )
				MostrarCorBotao(botaoCorSombra, (Color)cor);
		}
		private void botaoExcluirMusica1_Click(object sender, System.EventArgs e)
		{
			ExcluirMusicas(listaMusicasPrimeiraParte);
		}
		private void botaoExcluirMusicas2_Click(object sender, System.EventArgs e)
		{
			ExcluirMusicas(listaMusicasSegundaParte);
		}
		private void botaoFonteMusicas_Click(object sender, System.EventArgs e)
		{
			System.Drawing.Color cor = new Color();
			EscolherFonte(ref fonteMusicas);
			if( fonteMusicas != null ) 
			{
				caixaFonteMusicas.Text = fonteMusicas.Name + " " + fonteMusicas.Size;
			}
		}

		private void botaoFontePalestra_Click(object sender, System.EventArgs e)
		{
			System.Drawing.Color cor = new Color();
			EscolherFonte(ref fontePalestra);
			if( fontePalestra != null ) 
			{
				caixaFontePalestra.Text = fontePalestra.Name + " " + fontePalestra.Size;
			}
		}

		private void botaoFundoMusicas_Click(object sender, System.EventArgs e)
		{
			string filtro = "Imagens JPEG|*.jpg";
			string[] arquivosEscolhidos = EscolherArquivos(filtro, false);
			if( (arquivosEscolhidos != null) && (arquivosEscolhidos.Length > 0) )
				caixaFundoMusicas.Text = arquivosEscolhidos[0];
		}

		private void botaoFundoPalestra_Click(object sender, System.EventArgs e)
		{
			string filtro = "Imagens JPEG|*.jpg";
			string[] arquivosEscolhidos = EscolherArquivos(filtro, false);
			if( (arquivosEscolhidos != null) && (arquivosEscolhidos.Length > 0) )
				caixaFundoPalestra.Text = arquivosEscolhidos[0];
		}

		private void BotaoImagemAbertura_Click(object sender, System.EventArgs e)
		{
			string filtro = "Imagens JPEG|*.jpg";
			string[] arquivosEscolhidos = EscolherArquivos(filtro, false);
			if( (arquivosEscolhidos != null) && (arquivosEscolhidos.Length > 0) )
				caixaImagemAbertura.Text = arquivosEscolhidos[0];
		}

		private void botaoImagemCriancas_Click(object sender, System.EventArgs e)
		{
			string filtro = "Imagens JPEG|*.jpg";
			string[] arquivosEscolhidos = EscolherArquivos(filtro, false);
			if( (arquivosEscolhidos != null) && (arquivosEscolhidos.Length > 0) )
				caixaImagemCriancas.Text = arquivosEscolhidos[0];
		}
		private void botaoImagemInicial_Click(object sender, System.EventArgs e) {
			string filtro = "Imagens JPEG|*.jpg";
			string[] arquivosEscolhidos = EscolherArquivos(filtro, false);
			if( (arquivosEscolhidos != null) && (arquivosEscolhidos.Length > 0) )
				caixaImagemInicial.Text = arquivosEscolhidos[0];		
		}

		private void botaoMusicas1_Click(object sender, System.EventArgs e)
		{
			SelecionarMusicas(listaMusicasPrimeiraParte);
		}
		private void botaoMusicas2_Click(object sender, System.EventArgs e)
		{
			SelecionarMusicas(listaMusicasSegundaParte);
		}
		private void listaMusicasPrimeiraParte_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
		{
			if( e.Data.GetDataPresent("FileDrop") || e.Data.GetDataPresent("FileName") ) 
				e.Effect = e.AllowedEffect & DragDropEffects.Copy;
			else
				e.Effect = DragDropEffects.None;
		}

		private void listaMusicasPrimeiraParte_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
			ListView listaMusicas = (ListView)sender;
			object[] arquivos = (object[]) e.Data.GetData("FileDrop");
			foreach( string arquivo in arquivos )
				listaMusicas.Items.Add(arquivo);
		}

		private void listaMusicasSegundaParte_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
		{
			listaMusicasPrimeiraParte_DragEnter(sender, e);
		}

		private void listaMusicasSegundaParte_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
			listaMusicasPrimeiraParte_DragDrop(sender, e);		
		}

		private void menuAbrirProjeto_Click(object sender, System.EventArgs e) {
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "Projeto|*.ch";
			DialogResult r = ofd.ShowDialog(this);
			if( r == DialogResult.OK ) {
				CarregarEstado(ofd.FileName);
				this.projetoAberto = ofd.FileName;
			}
		}
		private void menuSair_Click(object sender, System.EventArgs e) {
			Application.Exit();
		}

		private void menuSalvarProjeto_Click(object sender, System.EventArgs e) {
			if( this.projetoAberto == null || this.projetoAberto == string.Empty ) {
				menuSalvarProjetoComo_Click(sender, e);
			}
			else {
				SalvarEstado(this.projetoAberto, PrepararDados());
			}
		}

		private void menuSalvarProjetoComo_Click(object sender, System.EventArgs e) {
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "Projeto|*.xml";
			DialogResult r = sfd.ShowDialog(this);
			if( r == DialogResult.OK ) {
				SalvarEstado(sfd.FileName, PrepararDados());
			}		
		}

		#endregion

		private void CarregarEstado(string caminhoArquivo) 
		{
			try {
				Projeto prj = new Projeto(caminhoArquivo, new ApresentacaoIpsionica());
				prj.Carregar();
			}
			catch(Exception ex) 
			{
				MessageBox.Show(this, 
					"Ocorreu um erro ao tentar carregar o arquivo de configuração, " +
					"mas isso não impede a utilização do programa. O seguinte erro ocorreu: " 
					+ ex.Message);
			}


//			System.IO.StreamReader reader = null;
//			try 
//			{
//				if( ! System.IO.File.Exists(caminhoArquivo) ) return;
//				reader = new System.IO.StreamReader(caminhoArquivo);
//				string linha = reader.ReadLine();
//				while( linha != null ) 
//				{
//					string[] tokens = linha.Split('?');
//					if( tokens.Length > 1 ) 
//					{
//						if( tokens[0].Equals(caixaArquivoModelo.Name) ) 
//							caixaArquivoModelo.Text = tokens[1];
//						else if( tokens[0].Equals(caixaImagemAbertura.Name) ) 
//							caixaImagemAbertura.Text = tokens[1];
//						else if( tokens[0].Equals(caixaImagemCriancas.Name) ) 
//							caixaImagemCriancas.Text = tokens[1];
//						else if( tokens[0].Equals(caixaImagemInicial.Name) ) 
//							caixaImagemInicial.Text = tokens[1];
//							//else if( tokens[0].Equals(caixaFontePalestra.Name) ) 
//							//caixaFontePalestra.Text = tokens[1];
//						else if( tokens[0].Equals(caixaFundoPalestra.Name) ) 
//							caixaFundoPalestra.Text = tokens[1];
//						else if( tokens[0].Equals(caixaArquivoPalestra.Name) ) 
//							caixaArquivoPalestra.Text = tokens[1];
//						else if( tokens[0].Equals(caixaFundoMusicas.Name) ) 
//							caixaFundoMusicas.Text = tokens[1];
//						else if( tokens[0].Equals(listaMusicasPrimeiraParte.Name) ) 
//							listaMusicasPrimeiraParte.Items.Add(tokens[1]);
//						else if( tokens[0].Equals(listaMusicasSegundaParte.Name) ) 
//							listaMusicasSegundaParte.Items.Add(tokens[1]);
//						//else if( tokens[0].Equals(caixaFonteMusicas.Name) ) 
//							//caixaFonteMusicas.Text = tokens[1];
//					}
//					linha = reader.ReadLine();
//				}
//			}
//			catch(Exception ex) 
//			{
//				MessageBox.Show(this, 
//					"Ocorreu um erro ao tentar carregar o arquivo de configuração, " +
//					"mas isso não impede a utilização do programa. O seguinte erro ocorreu: " 
//					+ ex.Message);
//			}
//			finally 
//			{
//				if( reader != null )
//					reader.Close();
//			}
		}

		private string[] EscolherArquivos(string filtro, bool multi) 
		{
			string[] arquivosEscolhidos = null;
			
			OpenFileDialog openFile = new OpenFileDialog();
			openFile.Filter = filtro;
			openFile.Multiselect = multi;
			
			DialogResult r = openFile.ShowDialog();
			
			if( r == DialogResult.OK ) 
			{
				arquivosEscolhidos = openFile.FileNames;
			}
			
			return arquivosEscolhidos;
		}

		private object EscolherCor() 
		{
			ColorDialog cd = new ColorDialog();
			DialogResult r = cd.ShowDialog(this);
			if( r == DialogResult.OK ) 
			{
				return cd.Color;
			}		
			return null;
		}
		private void EscolherFonte(ref Font fonte) 
		{
			FontDialog fontDialog = new FontDialog();
			fontDialog.Font = fonte;
			//fontDialog.Color = cor;
			fontDialog.ShowColor = false;
			DialogResult r = fontDialog.ShowDialog();
			if( r == DialogResult.OK ) 
			{
				//cor = fontDialog.Color;
				fonte = fontDialog.Font;
			}
		}

		private void ExcluirMusicas(ListView listaMusicas) 
		{
			foreach( ListViewItem item in listaMusicas.SelectedItems )
				listaMusicas.Items.Remove(item);
		}

		private void MoverMusicasSelecionadas(ListView lista, bool paraCima) 
		{
			foreach( ListViewItem item in lista.SelectedItems ) 
			{
				int i = paraCima ? 
					(item.Index > 0 ? item.Index - 1 : 0) :
					(item.Index < lista.Items.Count - 1 ? item.Index + 1 : lista.Items.Count - 1);
				lista.Items.Remove(item);
				lista.Items.Insert(i, item);
			}
		}
		private void MostrarCorBotao(Button botao, Color c) 
		{
			botao.BackColor = c;
			botao.ForeColor = System.Drawing.Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B);
		}
		private ApresentacaoIpsionica PrepararDados() {
			ApresentacaoIpsionica dados = new ApresentacaoIpsionica();
			dados.arquivoPalestra = caixaArquivoPalestra.Text;
			dados.fundoMusicas = caixaFundoMusicas.Text;
			dados.fundoPalestra = caixaFundoPalestra.Text;
			dados.imagemCriancas = caixaImagemCriancas.Text;
			dados.imagemInicial = caixaImagemInicial.Text;
			dados.imagemTema = caixaImagemAbertura.Text;
			foreach( ListViewItem item in listaMusicasPrimeiraParte.Items )
				dados.musicasPrimeiraParte.Add( new Musica(item.Text) );
			foreach( ListViewItem item in listaMusicasSegundaParte.Items )
				dados.musicasSegundaParte.Add( new Musica(item.Text) );
			if( checkSombreamento.Checked ) {
				dados.fonteMusica = new Fonte(fonteMusicas, caixaFonteMusicas.ForeColor, botaoCorSombra.BackColor);
				dados.fontePalestra = new Fonte(fontePalestra, caixaFontePalestra.ForeColor, botaoCorSombra.BackColor);
			}
			else {
				dados.fonteMusica = new Fonte(fonteMusicas, caixaFonteMusicas.ForeColor);
				dados.fontePalestra = new Fonte(fontePalestra, caixaFontePalestra.ForeColor);
			}
			dados.slidesVaziosEntreMusicas = slidesEntreMusicas.Checked;
			return dados;
		}

		private void SelecionarMusicas(ListView listaMusicas) 
		{
			SelecionadorArquivos.SelecionadorArquivos selecionador = 
				new SelecionadorArquivos.SelecionadorArquivos(
				new ListView[] {listaMusicasPrimeiraParte, listaMusicasSegundaParte},
				new string[] {lblMusicasPrimeiraParte.Text, lblMusicasSegundaParte.Text} );
			selecionador.Show();
//			string filtro = "Arquivos Texto|*.txt";
//			string[] arquivos = EscolherArquivos(filtro, true);
//			if( (arquivos != null) && (arquivos.Length > 0) ) 
//			{
//				foreach( string arq in arquivos ) 
//				{
//					listaMusicas.Items.Add(arq);
//				}
//			}
		}

		private void SalvarEstado(string caminhoArquivo, ApresentacaoIpsionica dados) 
		{
			try {
				Projeto prj = new Projeto(caminhoArquivo, dados);
				prj.Salvar();
			}
			catch(Exception ex) {
				MessageBox.Show(this, 
					"Ocorreu um erro ao tentar salvar o arquivo de configuração, " +
					"mas isso não impede a utilização do programa. O seguinte erro ocorreu: " 
					+ ex.Message);
			}

//			try 
//			{
//				writer = new System.IO.StreamWriter(caminhoArquivo, false);
//				writer.WriteLine(caixaArquivoModelo.Name + "?" + caixaArquivoModelo.Text);
//				writer.WriteLine(caixaImagemAbertura.Name + "?" + caixaImagemAbertura.Text);
//				writer.WriteLine(caixaImagemCriancas.Name + "?" + caixaImagemCriancas.Text);
//				writer.WriteLine(caixaImagemInicial.Name + "?" + caixaImagemInicial.Text);
//				writer.WriteLine(caixaArquivoPalestra.Name + "?" + caixaArquivoPalestra.Text);
//				writer.WriteLine(caixaFundoPalestra.Name + "?" + caixaFundoPalestra.Text);
//				writer.WriteLine(caixaFundoMusicas.Name + "?" + caixaFundoMusicas.Text);
//				foreach( ListViewItem item in listaMusicasPrimeiraParte.Items )
//					writer.WriteLine(listaMusicasPrimeiraParte.Name + "?" + item.Text);
//				foreach( ListViewItem item in listaMusicasSegundaParte.Items )
//					writer.WriteLine(listaMusicasSegundaParte.Name + "?" + item.Text);
//				//writer.WriteLine(caixaFontePalestra.Name + "?" + caixaFontePalestra.Text);
//				//writer.WriteLine(caixaFonteMusicas.Name + "?" + caixaFonteMusicas.Text);
//			} 
//			catch(Exception ex) 
//			{
//				MessageBox.Show(this, 
//					"Ocorreu um erro ao tentar salvar o arquivo de configuração, " +
//					"mas isso não impede a utilização do programa. O seguinte erro ocorreu: " 
//					+ ex.Message);
//				System.IO.StreamWriter writer = null;
//			}
//			finally 
//			{
//				if( writer != null )
//					writer.Close();
//			}
		}

	}
}
