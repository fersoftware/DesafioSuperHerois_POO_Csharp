using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioSuperHerois_POO_Csharp
{
    abstract class Personagem
    {
        private string nome, editora;
        private int pfInicial, peInicial, pf, pe;
        private bool mimico, drenador;
        List<Poder> poderes = new List<Poder>();

        public Personagem(string nome, string editora, int pf, int pe, bool mimico, bool drenador)
        {
            this.nome = nome;
            this.editora = editora;
            this.pfInicial = pf;
            this.peInicial = pe;
            this.pf = pf;
            this.pe = pe;
            this.mimico = mimico;
            this.drenador = drenador;            
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Editora
        {
            get { return editora; }
            set { editora = value; }
        }

        public int PfInicial
        {
            get { return pfInicial; }
            set { pfInicial = value; }
        }

        public int PeInicial
        {
            get { return peInicial; }
            set { peInicial = value; }
        }

        public int Pf
        {
            get { return pf; }
            set { pf = value; }
        }

        public int Pe
        {
            get { return pe; }
            set { pe = value; }
        }

        public bool Mimico
        {
            get { return mimico; }
            set { mimico = value; }
        }

        public bool Drenador
        {
            get { return drenador; }
            set { drenador = value; }
        }

        public void Drenar(Personagem oponente)
        {
            if (this.Drenador)
            { this.PeInicial = oponente.Pe; }
        }

        public void ClonarPoderes(Personagem oponente)
        {
            if (this.Mimico)
            {
                poderes = new List<Poder>();
                poderes = oponente.poderes;
            }
        }

        public void AdicionarPoder(Poder poder)
        { poderes.Add(poder); }

        public void RemoverPoder(Poder poder)
        { poderes.Remove(poder); }

        public void Recuperar()
        { this.Pe += (int)(this.PeInicial * 0.30); }

        public void RecuperarTudo()
        {
            this.Pf = this.PfInicial;
            this.Pe = this.PeInicial;
        }

        public void Atacar(Personagem oponente)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, poderes.Count);

            if (this.Pe >= poderes[randomNumber].Pe)
            {
                this.Pe -= poderes[randomNumber].Pe;
                this.Pf -= poderes[randomNumber].Dano;
            }
            else
            {
                Console.WriteLine("Atacante não tem PE suficiente");
                Console.WriteLine("[NOME DO ATACANTE] está esgotado! Usou este turno para se recuperar!", this.Nome);
                Recuperar();
            }

            Console.WriteLine("{0} usou seu poder {1} em{2}. /t Dano causado: {3}", this.Nome.ToUpper(), poderes[randomNumber].Nome.ToUpper(), oponente.Nome, poderes[randomNumber].Dano);
        }
    }
}
