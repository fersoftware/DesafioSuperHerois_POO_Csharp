using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioSuperHerois_POO_Csharp
{
    class Poder
    {
        private string nome;
        private int dano, pe;

        public int Dano
        {
            get { return dano; }
            set { dano = value; }
        }

        public int Pe
        {
            get { return pe; }
            set { pe = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public Poder(string nome, int dano, int pe)
        {
            this.nome = nome;
            this.dano = dano;
            this.pe = pe;
        }
    }
}
