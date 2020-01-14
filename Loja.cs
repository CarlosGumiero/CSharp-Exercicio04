using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio04_CSharp
{
    class Loja
    {
		private String nome;
		private String cnpj;
		private List<Livro> livros;
		private List<VideoGame> videoGames;

		public Loja(String nome, String cnpj, List<Livro> livros, List<VideoGame> videoGames)
		{
			this.nome = nome;
			this.cnpj = cnpj;
			this.livros = livros;
			this.videoGames = videoGames;
		}

		public void listaLivros()
		{
			Console.WriteLine("-----------------------------------------------------------------------");
			Console.WriteLine("A loja Americanas Possui estes livros para venda:");
			foreach (Livro livro in livros)
			{
				Console.WriteLine("Titulo: " + livro.nome + ", preço: " + livro.preco + ", quantidade: " + livro.qtd + " em estoque.");
			}
		}

		public void listaVideoGames()
		{
			Console.WriteLine("-----------------------------------------------------------------------");
			Console.WriteLine("A loja Americanas Possui estes video-games para venda:");
			foreach (VideoGame games in videoGames)
			{
				Console.WriteLine("Video-game: " + games.nome + ", preço: " + games.preco + ", quantidade: " + games.qtd + " em estoque.");
			}
		}

		public double calculaPatrimonio()
		{
			Console.WriteLine("-----------------------------------------------------------------------");
			double patrimonio = 0;

			if (livros.Count == 0)
			{

				Console.WriteLine("A loja não tem livros no seu estoque.");
			}
			else
			{
				foreach (Livro livro in livros)
				{
					patrimonio = patrimonio + (livro.preco * livro.qtd);
				}
			}

			if (videoGames.Count == 0)
			{
				Console.WriteLine("A loja não tem video-games no seu estoque.");
			}
			else
			{
				foreach (VideoGame games in videoGames)
				{
					patrimonio = patrimonio + (games.preco * games.qtd);
				}
			}

			Console.WriteLine("O patrimonio da loja: Americanas é de R$ " + patrimonio + ".");
			return patrimonio;
		}
	}
}
