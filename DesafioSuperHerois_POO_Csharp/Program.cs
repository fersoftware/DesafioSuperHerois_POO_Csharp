using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioSuperHerois_POO_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {            
            Confronto.Confrontar(Superman(), Superbizarro());
        }

        static Heroi Superman()
        {
            Heroi heroi = new Heroi("Clark Kent", "Superman", "DC Comics", 100, 70, false, false);
            Poder poder = new Poder("Força", 10, 8);
            heroi.AdicionarPoder(poder);
            poder = new Poder("Visão de Raios", 5, 5);
            heroi.AdicionarPoder(poder);
            poder = new Poder("Supersopro", 4, 4);
            heroi.AdicionarPoder(poder);
            return heroi;
        }

        static Heroi Homem_Aranha()
        {
            Heroi heroi = new Heroi("Peter Parker", "Homem_Aranha", "Marvel Comics", 80, 50, false, false);
            Poder poder = new Poder("Força", 7, 5);
            heroi.AdicionarPoder(poder);
            poder = new Poder("Soltar teia", 5, 5);
            return heroi;
        }

        static Heroi Fenix()
        {
            Heroi heroi = new Heroi("Jean Grey", "Fênix", "Marvel Comics", 150, 100, false, false);
            Poder poder = new Poder("Força", 12, 10);
            heroi.AdicionarPoder(poder);
            return heroi;
        }

        static Heroi Mimico()
        {
            Heroi heroi = new Heroi(" Calvin Montgomery Rankin", "Mímico", "Marvel Comics", 70, 50, true, false);
            Poder poder = new Poder("Força", 10, 8);
            return heroi;
        }

        static Vilao Superbizarro()
        {
            Vilao  vilao = new Vilao(50, "Superbizarro", "DC Comics", 95, 65, false, false);
            Poder poder = new Poder("Força", 10, 8);
            vilao.AdicionarPoder(poder);
            poder = new Poder("Visão de Raios", 5, 5);
            vilao.AdicionarPoder(poder);
            poder = new Poder("Supersopro", 4, 4);
            vilao.AdicionarPoder(poder);
            return vilao;
        }

        static Vilao DuendeVerde()
        {
            Vilao vilao = new Vilao(70, "Duende Verde", "Marvel Comics", 80, 60, false, false);
            Poder poder = new Poder("Força", 7, 5);
            vilao.AdicionarPoder(poder);
            poder = new Poder("Granada de Abóbora", 5, 5);
            return vilao;
        }

        static Vilao DoutorOctopus()
        {
            Vilao vilao = new Vilao(40, "Doutor Octopus", "Marvel Comics", 70, 40, false, false);
            Poder poder = new Poder("Tentáculos", 6, 4);
            vilao.AdicionarPoder(poder);
            return vilao;
        }

        static Vilao SuperSkrull()
        {
            Vilao vilao = new Vilao(100, "Super Skrull", "Marvel Comics", 90, 60, true, false);
            Poder poder = new Poder("Força", 10, 8);
            return vilao;
        }

        static Vilao Parasita()
        {
            Vilao vilao = new Vilao(70, "Parasita", "DC Comics", 90, 70, false, true);
            Poder poder = new Poder("Força", 7, 8);
            vilao.AdicionarPoder(poder);
            poder = new Poder("Rajada Energética", 6, 8);
            vilao.AdicionarPoder(poder);
            return vilao;
        }
    }
}
