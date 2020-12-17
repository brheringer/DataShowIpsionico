using System;
using System.Collections;

namespace DataShowIpsionico
{
	/// <summary>
	/// Entidade que encapsula a letra de uma música.
	/// Uma música é composta por um título e trechos de música.
	/// </summary>
	public class Musica
	{
		public string titulo;
		public ArrayList trechos = new ArrayList();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="arquivoMusica"></param>
		public Musica(string arquivoMusica)
		{
			try 
			{
				LerArquivo(arquivoMusica);
			} 
			catch(Exception ex) 
			{
				//TODO
				throw ex;
			}
		}

		private void LerArquivo(string arquivoMusica) 
		{
			string trecho = "";
			System.IO.StreamReader reader = new System.IO.StreamReader(arquivoMusica, System.Text.Encoding.Default);
			try 
			{
				this.titulo = reader.ReadLine();
				string linha = reader.ReadLine();
				
				while( linha != null ) 
				{
					if( linha.Equals("") ) 
					{
						if( !trecho.Equals("") ) 
						{
							trechos.Add(trecho);
							trecho = "";
						}
					}
					else 
					{
						trecho += linha + "\r";
					}
					linha = reader.ReadLine();
				}
			} 
			catch(Exception ex)
			{
				throw ex;
			}
			finally 
			{
				if( ! trecho.Equals("") )
					trechos.Add(trecho); //caso o arquivo não termine com uma linha em branco.
				reader.Close();
			}
		}
	}
}
