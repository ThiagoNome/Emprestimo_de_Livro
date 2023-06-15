using emprestimolivros.View;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emprestimolivros.Controller
{
    
    internal class Livro
    {
        private string livro;
        private decimal valor;
        private decimal frete;

        public Livro() { }

        public decimal calcular(string Livro, decimal Valor)
        {
            this.livro = Livro;
            this.valor = Valor;
            this.frete = 0;

            switch (Livro)
            {
                case "10%":
                    this.frete = 0.10m;
                    break;
                case "20%":
                    this.frete = 0.20m;
                    break;
                case "30%":
                    this.frete = 0.30m;
                    break;
            }
            valor = frete * valor;
            valor = Valor - valor;
            return valor;
        }
    }
}
