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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbnGenero.Items.Add("ação");
            cbnGenero.Items.Add("terror");
            cbnGenero.Items.Add("animação");
        }

        string nome;
        string genero;
        float nota;
        int ano;
        List<Filme> filmes = new List<Filme>(); 

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ObterDados();
            Filme f = new Filme(nome,genero, nota, ano);
            filmes.Add(f);

            MessageBox.Show("Adicionado com sucesso");
            LimparDados();
        }

        void ObterDados()
        {
            nome = tbxNome.Text;
            nota = float.Parse(tbxNota.Text);
            ano = Int32.Parse(tbxAno.Text);
            genero = cbnGenero.Text;

        }
        void LimparDados()
        {
            tbxNome.Text = "";
            tbxNota.Text = "";
            tbxAno.Text = "";
            cbnGenero.SelectedIndex = 0;
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            Visualizacao v = new Visualizacao(filmes);
            v.Show();
            //this.Hide();
        }
    }
}
