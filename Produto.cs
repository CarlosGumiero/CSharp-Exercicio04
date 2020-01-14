using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio04_CSharp
{
	

	public abstract class Produto
    {

		protected String _nome;
		protected double _preco;
		protected int _qtd;


		public Produto(String nome, double preco, int qtd)
		{
			this.nome = nome;
			this.preco = preco;
			this.qtd = qtd;
		}

		public String nome { get; set; }
		public double preco { get; set; }
		public int qtd { get; set; }
	}
}
