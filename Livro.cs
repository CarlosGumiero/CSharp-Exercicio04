using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio04_CSharp
{
    class Livro : Produto
    {
		private String autor { get; set; }
		private String tema { get; set; }
		private int qtdPag { get; set; }

		public Livro(String nome, double preco, int qtd, String autor, String tema, int qtdPag) : base(nome, preco, qtd)
		{ 
			this.autor = autor;
			this.tema = tema;
			this.qtdPag = qtdPag;
		}

	public double calculaImposto()
		{
			double imp = 0;
			if (this.tema == "educativo")
			{
				Console.WriteLine("Livro educativo não tem imposto: " + this.nome + ".");
				return 0;
			}
			else
			{
				imp = preco * 0.1;
				Console.WriteLine("R$" + imp + " de impostos sobre o livro " + this.nome + ".");
				return imp;
			}
		}
	}
}
