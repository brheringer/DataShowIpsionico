/* TODO
 * formatar fonte no slide master para facilitar inclus�es manuais posteriores
 * tratar exce��es
 */

using System;
using Microsoft.Office.Core;
using PowerPoint;

namespace DataShowIpsionico
{
	/// <summary>
	/// Classe com m�todos para executar opera��es sobre apresenta��es do
	/// Power Point, tendo em vista especificamente o caso ipsi�nico.
	/// </summary>
	public class ControlePowerPoint
	{
		/// <summary>
		/// Caminho do arquivo usado como modelo para criar a apresenta��o.
		/// </summary>
		private string apresentacaoModelo = @"d:\template.ppt";
		/// <summary>
		/// 
		/// </summary>
		private const int MARGEM_SUPERIOR = 25;
		/// <summary>
		/// Manipulador da aplica��o (PowerPoint propriamente dito).
		/// </summary>
		private PowerPoint.Application app;
		/// <summary>
		/// Manipulador da apresenta��o (arquivo ppt).
		/// </summary>
		private PowerPoint.Presentation apresentacao;
		/// <summary>
		/// Dados para gerar a apresenta��o.
		/// </summary>
		private ApresentacaoIpsionica dadosApresentacao;

		/// <summary>
		/// 
		/// </summary>
		public ControlePowerPoint(ApresentacaoIpsionica dadosApresentacao, string apresentacaoModelo) 
		{
			try 
			{
				this.apresentacaoModelo = apresentacaoModelo;
				this.dadosApresentacao = dadosApresentacao;
				app = new PowerPoint.ApplicationClass();
				app.Visible = MsoTriState.msoTrue; //em princ�pio, vis�vel (para depura��o).
				apresentacao = app.Presentations.Open(apresentacaoModelo, MsoTriState.msoFalse, MsoTriState.msoTrue, MsoTriState.msoTrue);
			} 
			catch(System.Runtime.InteropServices.COMException) 
			{
				throw new Exception("O arquivo de modelo n�o foi encontrado. \r\nVerifique se voc� preencheu corretamente o �ltimo campo.");
			}
			catch(Exception) 
			{
				//TODO
				throw;
			}
		}


		/// <summary>
		/// Gera o arquivo da apresenta��o.
		/// </summary>
		public void MontarApresentacao() 
		{
			GerarSlideMaster();
			GerarSlideInicial();
			GerarSlideTema();
			foreach( Musica musica in dadosApresentacao.musicasPrimeiraParte )
				GerarSlideMusica(musica);
			GerarSlideCriancas();
			GerarSlidePalestra();
			foreach( Musica musica in dadosApresentacao.musicasSegundaParte )
				GerarSlideMusica(musica);
			GerarSlideTema();
		}

		private void GerarSlideCriancas() 
		{
			if( (dadosApresentacao.imagemCriancas != null) &&
				! dadosApresentacao.imagemCriancas.Equals("") ) 
			{
				GerarSlideImagem(dadosApresentacao.imagemCriancas);
			}
		}

		private void GerarSlideInicial() {
			if( (dadosApresentacao.imagemInicial != null) &&
				! dadosApresentacao.imagemInicial.Equals("") ) {
				GerarSlideImagem(dadosApresentacao.imagemInicial);
			}
		}

		private void GerarSlideTema() {
			if( (dadosApresentacao.imagemTema != null) &&
				! dadosApresentacao.imagemTema.Equals("") ) {
				GerarSlideImagem(dadosApresentacao.imagemTema);
			}
		}

		private void GerarSlideImagem(string arquivoImagem) 
		{
			_Slide slide = apresentacao.Slides.Add(apresentacao.Slides.Count+1, PpSlideLayout.ppLayoutBlank);
			slide.FollowMasterBackground = MsoTriState.msoFalse;
			slide.Background.Fill.UserPicture(arquivoImagem);
		}

		private void GerarSlideMaster() 
		{
			if( (dadosApresentacao.fundoMusicas != null) &&
				! dadosApresentacao.fundoMusicas.Equals("") ) 
			{
				apresentacao.SlideMaster.Background.Fill.UserPicture(dadosApresentacao.fundoMusicas);
			}
			//TODO caixaTrecho.TextFrame.TextRange.Font.Bold;
			//TODO caixaTrecho.TextFrame.TextRange.Font.Italic;
			//TODO caixaTrecho.TextFrame.TextRange.Font.Size;
			//TODO caixaTrecho.TextFrame.TextRange.Font.Color;
			//TODO caixaTrecho.TextFrame.TextRange.Font.Name;
		}

		private void GerarSlideMusica(Musica musica) 
		{
			bool porTitulo = true;
			foreach( string trecho in musica.trechos ) 
			{
				//Configurar o slide.
				_Slide slide = apresentacao.Slides.Add(apresentacao.Slides.Count+1, PpSlideLayout.ppLayoutBlank);
				slide.FollowMasterBackground = MsoTriState.msoTrue;

				float margemSuperiorAjustada = MARGEM_SUPERIOR;

				if( porTitulo ) 
				{
					//Configurar caixa de texto com t�tulo da m�sica.
					PowerPoint.Shape caixaTitulo = slide.Shapes.AddTextbox(
						MsoTextOrientation.msoTextOrientationHorizontal, 
						0, MARGEM_SUPERIOR, apresentacao.SlideMaster.Width, 
						dadosApresentacao.fonteMusica.tamanho);
					caixaTitulo.TextFrame.TextRange.ParagraphFormat.Alignment = PowerPoint.PpParagraphAlignment.ppAlignCenter;
					caixaTitulo.TextFrame.TextRange.Text = musica.titulo;
					caixaTitulo.TextFrame.TextRange.Font.Bold = MsoTriState.msoTrue;
					caixaTitulo.TextFrame.TextRange.Font.Italic = bool2mso(dadosApresentacao.fonteMusica.italico);
					//caixaTitulo.TextFrame.TextRange.Font.Shadow = bool2mso(dadosApresentacao.fonteMusica.sombreado);
					caixaTitulo.TextFrame.TextRange.Font.Underline = MsoTriState.msoTrue;
					caixaTitulo.TextFrame.TextRange.Font.Size = dadosApresentacao.fonteMusica.tamanho;
					if( dadosApresentacao.fonteMusica.sombreado )
					{
						caixaTitulo.Shadow.ForeColor.RGB = dadosApresentacao.fonteMusica.corSombra.cor;
						caixaTitulo.Shadow.Visible = bool2mso(dadosApresentacao.fonteMusica.sombreado);
						caixaTitulo.Shadow.OffsetX = 3.0F;
						caixaTitulo.Shadow.OffsetY = 3.0F;
					}
					
					if( ! dadosApresentacao.fonteMusica.nome.Equals("") )
						caixaTitulo.TextFrame.TextRange.Font.Name = dadosApresentacao.fonteMusica.nome;
					caixaTitulo.TextFrame.TextRange.Font.Color.RGB = dadosApresentacao.fonteMusica.cor.cor;
					
					porTitulo = false;
					margemSuperiorAjustada = caixaTitulo.Top + caixaTitulo.Height + MARGEM_SUPERIOR;
				}

				//Configurar a caixa de texto com trecho da m�sica.
				PowerPoint.Shape caixaTrecho = slide.Shapes.AddTextbox(
					MsoTextOrientation.msoTextOrientationHorizontal, 
					0, margemSuperiorAjustada, 
					apresentacao.SlideMaster.Width, 
					trecho.Split('\r').Length * dadosApresentacao.fonteMusica.tamanho);
				caixaTrecho.TextFrame.TextRange.ParagraphFormat.Alignment = PowerPoint.PpParagraphAlignment.ppAlignCenter;
				caixaTrecho.TextFrame.TextRange.Text = trecho;
				caixaTrecho.TextFrame.TextRange.Font.Bold = bool2mso(dadosApresentacao.fonteMusica.negrito);
				caixaTrecho.TextFrame.TextRange.Font.Italic = bool2mso(dadosApresentacao.fonteMusica.italico);
				caixaTrecho.TextFrame.TextRange.Font.Underline = bool2mso(dadosApresentacao.fonteMusica.sublinhado);
				//caixaTrecho.TextFrame.TextRange.Font.Shadow = bool2mso(dadosApresentacao.fonteMusica.sombreado);
				caixaTrecho.TextFrame.TextRange.Font.Size = dadosApresentacao.fonteMusica.tamanho;
				if( dadosApresentacao.fonteMusica.sombreado ) 
				{
					caixaTrecho.Shadow.ForeColor.RGB = dadosApresentacao.fonteMusica.corSombra.cor;
					caixaTrecho.Shadow.Visible = bool2mso(dadosApresentacao.fonteMusica.sombreado);
					caixaTrecho.Shadow.OffsetX = 3.0F;
					caixaTrecho.Shadow.OffsetY = 3.0F;
				}

				if( ! dadosApresentacao.fonteMusica.nome.Equals("") )
					caixaTrecho.TextFrame.TextRange.Font.Name = dadosApresentacao.fonteMusica.nome;
				caixaTrecho.TextFrame.TextRange.Font.Color.RGB = dadosApresentacao.fonteMusica.cor.cor;
			}

			if( dadosApresentacao.slidesVaziosEntreMusicas ) 
			{
				//Inserir slide vazio ap�s a m�sica.
				_Slide slide = apresentacao.Slides.Add(apresentacao.Slides.Count+1, PpSlideLayout.ppLayoutBlank);
				slide.FollowMasterBackground = MsoTriState.msoTrue;
			}
		}

		private void GerarSlidePalestra() 
		{
			if( (dadosApresentacao.arquivoPalestra != null) &&
				! dadosApresentacao.arquivoPalestra.Equals("") ) 
			{
				int primeiro = apresentacao.Slides.Count;
				apresentacao.Slides.InsertFromFile(dadosApresentacao.arquivoPalestra, primeiro, 1, -1);
				for( int i = primeiro+1; i <= apresentacao.Slides.Count; i++ ) 
				{
					Slide slide = apresentacao.Slides[i];
					slide.FollowMasterBackground = MsoTriState.msoFalse;
					if( (dadosApresentacao.fundoPalestra != null) &&
						! dadosApresentacao.fundoPalestra.Equals("") ) 
					{
						slide.Background.Fill.UserPicture(dadosApresentacao.fundoPalestra);
					}
				
					foreach( PowerPoint.Shape shape in slide.Shapes )
					{
						if( shape.HasTextFrame == MsoTriState.msoTrue ) 
						{
							Font f = shape.TextFrame.TextRange.Font;
							if( dadosApresentacao.MudarCorFontePalestra ) 
							{
								f.Color.RGB = dadosApresentacao.fontePalestra.cor.cor;
							}
							if( dadosApresentacao.MudarFontePalestra ) 
							{
								f.Name = dadosApresentacao.fontePalestra.nome;
								shape.Shadow.ForeColor.RGB = dadosApresentacao.fontePalestra.corSombra.cor;
								shape.Shadow.Visible = bool2mso(dadosApresentacao.fontePalestra.sombreado);
								shape.Shadow.OffsetX = 3.0F;
								shape.Shadow.OffsetY = 3.0F;
							}
						}
					}
				}
			}
		}

		private MsoTriState bool2mso(bool valor) 
		{
			return valor ? MsoTriState.msoTrue : MsoTriState.msoFalse;
		}

	}
}
