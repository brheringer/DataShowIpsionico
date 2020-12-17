using System;
using System.Collections;

namespace DataShowIpsionico
{
	/// <summary>
	/// Entidade que encapsula todos os dados necessários para a construção
	/// de uma apresentação (slide show) ipsiônica.
	/// </summary>
	public class ApresentacaoIpsionica
	{
		/// <summary>
		/// Caminho do arquivo PPT com os slides da palestra.
		/// </summary>
		public string arquivoPalestra;
		/// <summary>
		/// Lista de caminhos dos arquivos com as letras das músicas.
		/// TODO ainda tenho que decidir se vai ser PPT, TXT ou ambos.
		/// Provavelmente, vou tentar fazer para ambos.
		/// </summary>
		public ArrayList musicasPrimeiraParte = new ArrayList();
		/// <summary>
		/// Lista de caminhos dos arquivos com as letras das músicas 
		/// da segunda parte do louvor.
		/// </summary>
		public ArrayList musicasSegundaParte = new ArrayList();
		/// <summary>
		/// 
		/// </summary>
		public Fonte fonteMusica = null;
		/// <summary>
		/// 
		/// </summary>
		public Fonte fontePalestra = null;
		/// <summary>
		/// Caminho do arquivo de imagem que será fundo dos slides de músicas.
		/// </summary>
		public string fundoMusicas = "";
		/// <summary>
		/// Caminho do arquivo de imagem que será fundo dos slides da palestra.
		/// </summary>
		public string fundoPalestra = "";
		/// <summary>
		/// Caminho do arquivo de imagem de aviso de dispensa das crianças.
		/// </summary>
		public string imagemCriancas = "";
		/// <summary>
		/// Caminho do arquivo de imagem que será o primeiro slide.
		/// </summary>
		public string imagemInicial = "";
		/// <summary>
		/// Caminho do arquivo de imagem do tema.
		/// </summary>
		public string imagemTema = "";
		/// <summary>
		/// Indica se deve criar slides vazios entre as músicas.
		/// </summary>
		public bool slidesVaziosEntreMusicas = true;

		public bool MudarCorFontePalestra 
		{
			get { return fontePalestra.cor.cor > 0; }
		}

		
		public bool MudarFontePalestra 
		{
			get { return ! fontePalestra.nome.Equals(""); }
		}

		
		//TODO: fontes (nome, cor, tamanho, efeito) (musicas, palestras, master)

		public ApresentacaoIpsionica()
		{
		}
	}

	public class Fonte 
	{
		public Cor cor = new Cor(255,255,255);
		public Cor corSombra = new Cor(0, 0, 0);
		public bool italico = false;
		public bool negrito = false;
		public bool sombreado = false;
		public bool sublinhado = false;
		public float tamanho = 48;
		public string nome = "Arial"; //"" para não mudar a fonte da palestra

		public Fonte() {}

		public Fonte(System.Drawing.Font fonte, System.Drawing.Color cor, 
			System.Drawing.Color corSombra) : this(fonte, cor)
		{
			this.corSombra = new Cor(corSombra.R, corSombra.G, corSombra.B);
			this.sombreado = true;
		}
		
		public Fonte(System.Drawing.Font fonte, System.Drawing.Color cor) 
		{
			if( fonte != null ) 
			{
				this.cor = new Cor(cor.R, cor.G, cor.B);
				this.italico = fonte.Italic;
				this.negrito = fonte.Bold;
				this.sublinhado = fonte.Underline;
				this.tamanho = fonte.Size;
				this.nome = fonte.Name;
			}
		}
	}

	public class Cor 
	{
		public int cor = 0;
		public Cor(int r, int g, int b) 
		{
			cor = (b << 16) + (g << 8) + r;
		}
	}
}
