using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio04_CSharp
{
    class VideoGame : Produto
    {
		private String marca { get; set; }
		private String modelo { get; set; }
		private bool isUsado { get; set; }

		public VideoGame(String nome, double preco, int qtd, String marca, String modelo, bool isUsado) : base(nome, preco, qtd)
		{ 
			this.marca = marca;
			this.modelo = modelo;
			this.isUsado = isUsado;
		}

		
	public double calculaImposto()
		{
			double imp = 0;
			if (this.isUsado)
			{
				imp = this.preco * 0.25;
				Console.WriteLine("Imposto " + this.nome + " " + this.modelo + " usado, R$" + imp + ".");
				return imp;
			}
			else
			{
				imp = this.preco * 0.45;
				Console.WriteLine("Imposto " + this.nome + " " + this.modelo + "  R$" + imp + ".");
				return imp;
			}
		}
	}
}
