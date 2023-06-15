using emprestimolivros.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emprestimolivros.View
{
    public partial class FormView : Form
    {
        Livro emprestimo = new Livro();
        public FormView()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            tx_nomeCli.Text =  nomeCliente.Text;
            tx_cpfCli.Text =  cpfCliente.Text;
            tx_nomeLivro.Text = nomeLivro.Text;
            tx_anoLivro.Text = anoLivro.Text;

            string Livro = descontosLivro.Text;
            decimal Valor = Convert.ToDecimal(valorLivro.Text);           
            resultado.Text = string.Empty; /*LIMPAR O RESULTADO TODA VEZ*/
            resultado.Text = "R$ " + resultado.Text + emprestimo.calcular(Livro, Valor).ToString();
        }

        private void tx_nomeLivro_Click(object sender, EventArgs e)
        {

        }

        private void tx_anoLivro_Click(object sender, EventArgs e)
        {

        }

        private void tx_nomeCli_Click(object sender, EventArgs e)
        {

        }

        private void tx_cpfCli_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
