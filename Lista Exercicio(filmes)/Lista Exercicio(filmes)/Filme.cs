using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Exercicio_filmes_
{
    public class Filme
    {
        private string nome;
        private float nota;
        private string genero;
        private int ano;

        List<Filme> filmes = new List<Filme>();

        public string Nome { get => nome; set => nome = value; }
        public float Nota { get => nota; set => nota = value; }
        public string Genero { get => genero; set => genero = value; }
        public int Ano { get => ano; set => ano = value; }

        public Filme(string nome, string genero, float nota, int ano)
        {
            this.Ano = ano;
            this.Nome = nome;
            this.Genero = genero;
            this.Nota = nota;
        }
    }
}
