using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioSuperHerois_POO_Csharp
{
    class Vilao : Personagem
    {
        private int nivelDeMaldade;
                
        public Vilao(int nivelDeMaldade, string nome, string editora, int pf, int pe, bool mimico, bool drenador) : base(nome, editora, pf, pe, mimico, drenador)
        {
            this.nivelDeMaldade = nivelDeMaldade;
        }

        public int NivelDeMaldade
        {
            get { return nivelDeMaldade; }
            set { nivelDeMaldade = value; }
        }
    }
}
