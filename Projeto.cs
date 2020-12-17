using System;
using System.Xml;

namespace DataShowIpsionico
{
	/// <summary>
	/// Representa um projeto do programa, ou seja, configurações salvas.
	/// </summary>
	public class Projeto
	{
		#region constantes tag xml
		private const string TAG_RAIZ = "ConstrutorSlides";
		private const string TAG_PROJETO = "Projeto";
		private const string TAG_ARQUIVO_MODELO = "ArquivoModelo";
		private const string TAG_IMAGEM_INICIAL = "ImagemInicial";
		private const string TAG_IMAGEM_CRIANCAS = "ImagemCriancas";
		private const string TAG_IMAGEM_TEMA = "ImagemTema";
		private const string TAG_ARQUIVO_PALESTRA = "ArquivoPalestra";
		private const string TAG_FUNDO_PALESTRA = "FundoPalestra";
		private const string TAG_MUSICAS_1 = "MusicasPrimeiraParte";
		private const string TAG_ARQUIVO_MUSICA = "ArquivoMusica";
		private const string TAG_MUSICAS_2 = "MusicasSegundaParte";
		private const string TAG_FONTE_PALESTRA = "FontePalestra";
		private const string TAG_FONTE_MUSICAS = "FonteMusicas";
		private const string TAG_SLIDE_VAZIOS = "SlidesVaziosEntreMusicas";

		private const string TAG_FONTE_NOME = "NomeFonte";
		private const string TAG_FONTE_COR = "CorFonte";
		private const string TAG_FONTE_COR_SOMBRA = "CorSombra";
		private const string TAG_FONTE_ITALICO = "Italico";
		private const string TAG_FONTE_NEGRITO = "Negrito";
		private const string TAG_FONTE_SOMBREADO = "Sombreado";
		private const string TAG_FONTE_SUBLINHADO = "Sublinhado";
		private const string TAG_FONTE_TAMANHO = "TamanhoFonte";
		#endregion

		/// <summary>
		/// Obtém o nome do arquivo que corresponde ao projeto no disco.
		/// </summary>
		public string NomeArquivo {
			get {
				return this._nomeArquivo;
			}
		}
		private string _nomeArquivo = null;

		/// <summary>
		/// Dados do projeto.
		/// </summary>
		public ApresentacaoIpsionica Dados {
			get {
				return _dados;
			}
		}
		private ApresentacaoIpsionica _dados = null;

		public Projeto(string nomeArquivo, ApresentacaoIpsionica dados) 
		{
			if( nomeArquivo == null )
				throw new ArgumentNullException("Nome do arquivo do projeto não foi definido.");
			
			if( dados == null )
				throw new ArgumentNullException("Os dados do projeto não foram definidos.");

			this._nomeArquivo = nomeArquivo;
			this._dados = dados;
		}

		
		private XmlDocument GerarXML() {
			if( _dados == null )
				throw new ArgumentNullException("Os dados do projeto não foram definidos.");

			XmlDocument xml = new XmlDocument();

			XmlElement elementoRaiz = xml.CreateElement(TAG_RAIZ);
			xml.AppendChild(elementoRaiz);

			XmlElement elementoProjeto = xml.CreateElement(TAG_PROJETO);
			elementoRaiz.AppendChild(elementoProjeto);

			XmlElement elementoArquivoModelo = xml.CreateElement(TAG_ARQUIVO_MODELO);
			//TODO elementoArquivoModelo.InnerText = Dados.
			elementoProjeto.AppendChild(elementoArquivoModelo);

			XmlElement elementoImagemInicial = xml.CreateElement(TAG_IMAGEM_INICIAL);
			elementoImagemInicial.InnerText = this.Dados.imagemInicial;
			elementoProjeto.AppendChild(elementoImagemInicial);

			XmlElement elementoImagemCriancas = xml.CreateElement(TAG_IMAGEM_CRIANCAS);
			elementoImagemCriancas.InnerText = this.Dados.imagemCriancas;
			elementoProjeto.AppendChild(elementoImagemCriancas);

			XmlElement elementoImagemTema = xml.CreateElement(TAG_IMAGEM_TEMA);
			elementoImagemTema.InnerText = this.Dados.imagemTema;
			elementoProjeto.AppendChild(elementoImagemTema);

			XmlElement elementoArquivoPalestra = xml.CreateElement(TAG_ARQUIVO_PALESTRA);
			elementoArquivoPalestra.InnerText = this.Dados.arquivoPalestra;
			elementoProjeto.AppendChild(elementoArquivoPalestra);

			XmlElement elementoFundoPalestra = xml.CreateElement(TAG_FUNDO_PALESTRA);
			elementoFundoPalestra.InnerText = this.Dados.fundoPalestra;
			elementoProjeto.AppendChild(elementoFundoPalestra);

			XmlElement elementoFundoMusicas = xml.CreateElement(TAG_FONTE_MUSICAS);
			elementoFundoMusicas.InnerText = this.Dados.fundoMusicas;
			elementoProjeto.AppendChild(elementoFundoMusicas);

			XmlElement elementoMusicas1 = xml.CreateElement(TAG_MUSICAS_1);
			elementoProjeto.AppendChild(elementoMusicas1);

			foreach( string arq in this.Dados.musicasPrimeiraParte ) {
				XmlElement elementoArquivoMusica = xml.CreateElement(TAG_ARQUIVO_MUSICA);
				elementoArquivoMusica.InnerText = arq;
				elementoMusicas1.AppendChild(elementoArquivoMusica);
			}

			XmlElement elementoMusicas2 = xml.CreateElement(TAG_MUSICAS_2);
			elementoProjeto.AppendChild(elementoMusicas2);

			foreach( string arq in this.Dados.musicasSegundaParte ) {
				XmlElement elementoArquivoMusica = xml.CreateElement(TAG_ARQUIVO_MUSICA);
				elementoArquivoMusica.InnerText = arq;
				elementoMusicas2.AppendChild(elementoArquivoMusica);
			}

			XmlElement elementoFontePalestra = xml.CreateElement(TAG_FONTE_PALESTRA);
			elementoProjeto.AppendChild(elementoFontePalestra);

			GerarElementoFonte(xml, elementoFontePalestra, this.Dados.fontePalestra);

			XmlElement elementoFonteMusicas = xml.CreateElement(TAG_FONTE_MUSICAS);
			elementoProjeto.AppendChild(elementoFonteMusicas);

			GerarElementoFonte(xml, elementoFonteMusicas, this.Dados.fonteMusica);

			XmlElement elementoSlidesVazios = xml.CreateElement(TAG_SLIDE_VAZIOS);
			elementoSlidesVazios.InnerText = this.Dados.slidesVaziosEntreMusicas.ToString();
			elementoProjeto.AppendChild(elementoSlidesVazios);
			
			return xml;
		}


		private Fonte LerElementoFonte(XmlTextReader reader, string tagFonte) 
		{
			Fonte fonte = new Fonte();
			while( reader.Read() ) 
			{
				if( reader.NodeType == XmlNodeType.Element ) 
				{
					switch( reader.Name ) 
					{
						case TAG_FONTE_COR:
							fonte.cor = new Cor(0,0,0);
							fonte.cor.cor = Convert.ToInt32(reader.ReadElementString());
							break;
						case TAG_FONTE_COR_SOMBRA:
							fonte.corSombra = new Cor(0,0,0);
							fonte.corSombra.cor = Convert.ToInt32(reader.ReadElementString());
							break;
						case TAG_FONTE_ITALICO:
							fonte.italico = Convert.ToBoolean(reader.ReadElementString());
							break;
						case TAG_FONTE_NEGRITO:
							fonte.negrito = Convert.ToBoolean(reader.ReadElementString());
							break;
						case TAG_FONTE_NOME:
							fonte.nome = reader.ReadElementString();
							break;
						case TAG_FONTE_SOMBREADO:
							fonte.sombreado = Convert.ToBoolean(reader.ReadElementString());
							break;
						case TAG_FONTE_SUBLINHADO:
							fonte.sublinhado = Convert.ToBoolean(reader.ReadElementString());
							break;
						case TAG_FONTE_TAMANHO:
							fonte.tamanho = float.Parse(reader.ReadElementString());
							break;
					}
				}
				else if( reader.NodeType == XmlNodeType.EndElement ) 
				{
					if( reader.Name.Equals(tagFonte) ) {
						return fonte;
					}
				}
			}
			return fonte;
		}


		private void GerarElementoFonte(XmlDocument xml, XmlElement elementoFonte, Fonte fonte) {
			XmlElement elementoFonteNome = xml.CreateElement("NomeFonte");
			elementoFonteNome.InnerText = fonte.nome;
			elementoFonte.AppendChild(elementoFonteNome);
			
			XmlElement elementoFonteCor = xml.CreateElement("CorFonte");
			elementoFonteCor.InnerText = fonte.cor.cor.ToString();
			elementoFonte.AppendChild(elementoFonteCor);

			XmlElement elementoSombraCor = xml.CreateElement("CorSombra");
			elementoSombraCor.InnerText = fonte.corSombra.cor.ToString();
			elementoFonte.AppendChild(elementoSombraCor);

			XmlElement elementoItalico = xml.CreateElement("Italico");
			elementoItalico.InnerText = fonte.italico.ToString();
			elementoFonte.AppendChild(elementoItalico);

			XmlElement elementoNegrito = xml.CreateElement("Negrito");
			elementoNegrito.InnerText = fonte.negrito.ToString();
			elementoFonte.AppendChild(elementoNegrito);
			
			XmlElement elementoSombreado = xml.CreateElement("Sombreado");
			elementoSombreado.InnerText = fonte.sombreado.ToString();
			elementoFonte.AppendChild(elementoSombreado);

			XmlElement elementoSublinhado = xml.CreateElement("Sublinhado");
			elementoSublinhado.InnerText = fonte.sublinhado.ToString();
			elementoFonte.AppendChild(elementoSublinhado);

			XmlElement elementoFonteTamanho = xml.CreateElement("TamanhoFonte");
			elementoFonteTamanho.InnerText = fonte.tamanho.ToString();
			elementoFonte.AppendChild(elementoFonteTamanho);
		}
		
		
		/// <summary>
		/// Carrega o projeto do disco.
		/// </summary>
		public void Carregar() {
			
			if( ! System.IO.File.Exists(this.NomeArquivo) ) 
				return;

			XmlTextReader reader = null;
			try {
				reader = new XmlTextReader(this.NomeArquivo);
				int musicas1ou2 = 1;
				while( reader.Read() ) {
					if( reader.NodeType == XmlNodeType.Element ) {
						
						switch( reader.Name ) {
						
							case TAG_ARQUIVO_MODELO:
								//TODO
								break;

							case TAG_ARQUIVO_MUSICA:
								string musica = reader.ReadElementString();
								if( musicas1ou2 == 1 )
									this.Dados.musicasPrimeiraParte.Add(musica);
								else if( musicas1ou2 == 2 )
									this.Dados.musicasSegundaParte.Add(musica);
								break;

							case TAG_ARQUIVO_PALESTRA:
								this.Dados.arquivoPalestra = reader.ReadElementString();
								break;

							case TAG_FONTE_MUSICAS:
								this.Dados.fonteMusica = LerElementoFonte(reader, reader.Name);
								break;

							case TAG_FONTE_PALESTRA:
								this.Dados.fontePalestra = LerElementoFonte(reader, reader.Name);
								break;

							case TAG_FUNDO_PALESTRA:
								this.Dados.fundoPalestra = reader.ReadElementString();
								break;

							case TAG_IMAGEM_CRIANCAS:
								this.Dados.imagemCriancas = reader.ReadElementString();
								break;

							case TAG_IMAGEM_INICIAL:
								this.Dados.imagemInicial = reader.ReadElementString();
								break;

							case TAG_IMAGEM_TEMA:
								this.Dados.imagemTema = reader.ReadElementString();
								break;

							case TAG_MUSICAS_1:
								musicas1ou2 = 1;
								break;

							case TAG_MUSICAS_2:
								musicas1ou2 = 2;
								break;

							case TAG_PROJETO:
								break;

							case TAG_RAIZ:
								break;

							case TAG_SLIDE_VAZIOS:
								this.Dados.slidesVaziosEntreMusicas = Convert.ToBoolean(reader.ReadElementString());
								break;

						}

					}
				}
			}
			catch {
				throw;
			}
			finally {
				if( reader != null )
					reader.Close();
			}
		}


		/// <summary>
		/// Salva o projeto no disco.
		/// </summary>
		public void Salvar() {
			XmlDocument xml = null;
			try {
				xml = GerarXML();
			}
			catch(Exception ex) {
				throw new Exception("Falha ao gerar XML.", ex);
			}

			XmlTextWriter writer = null;
			try {
				writer = new XmlTextWriter(this.NomeArquivo, System.Text.Encoding.UTF8);
				xml.WriteContentTo(writer);
			}
			catch(Exception ex) {
				throw new Exception("Falha ao salvar XML.", ex);
			}
			finally {
				if( writer != null )
					writer.Close();
			}
		}
	}
}
