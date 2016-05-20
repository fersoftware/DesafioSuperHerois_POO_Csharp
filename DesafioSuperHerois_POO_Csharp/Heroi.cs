using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioSuperHerois_POO_Csharp
{
    class Heroi : Personagem
    {
        private string nomeReal;
               
        public Heroi(string nomeReal, string nome, string editora, int pf, int pe, bool mimico, bool drenador) : base (nome, editora, pf, pe, mimico, drenador)
        {
            this.nomeReal = nomeReal;
        }

        public string NomeReal
        {
            get { return nomeReal; }
            set { nomeReal = value; }
        }
    }
}
