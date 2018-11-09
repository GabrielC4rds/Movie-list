using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_Exercicio_filmes_
{
    public partial class Visualizacao : Form


    {
        float maiorNota;
        float menorNota;
        int qtdFilmes;
        float mediaNotas;
        float soma;


        public Visualizacao(List<Filme> filmes)
        {
            InitializeComponent();
            foreach (Filme f in filmes)
            {
                if(f.Nota > maiorNota)
                {
                    maiorNota = f.Nota;
                }
                soma = soma + f.Nota;

                if (menorNota == 0)
                {
                    menorNota = f.Nota;
                }
                else
                {
                    if(f.Nota < menorNota)
                    {
                        menorNota = f.Nota;
                    }
                }


            }
            qtdFilmes = filmes.Count();
            mediaNotas = soma / qtdFilmes;

            lblVer.Text = "Maior Nota: " + maiorNota + "\n Menor Nota: " + menorNota + "\n Média: " + mediaNotas + "\n Quantidade de filmes:" + qtdFilmes;
        }

        private void Visualizacao_Load(object sender, EventArgs e)
        {

        }
    }
}
