using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioSuperHerois_POO_Csharp
{
    static class Confronto
    {
        public static void Confrontar(Personagem oponente1, Personagem oponente2)
        {
            oponente1.RecuperarTudo();
            oponente2.RecuperarTudo();

            if (oponente1.Mimico)
            { oponente1.ClonarPoderes(oponente2); }
            if (oponente2.Mimico)
            { oponente2.ClonarPoderes(oponente1); }

            if (oponente1.Editora != oponente2.Editora)
            { Console.WriteLine("Confronto CrossOver"); }
            else
            { Console.WriteLine("Confronto {0}", oponente1.Editora.ToUpper()); }

            if (oponente1.GetType().ToString().IndexOf("Heroi") >= 0 && oponente2.GetType().ToString().IndexOf("Vilao") >= 0)
            { Console.WriteLine("Confronto Clássico: Bem versus o Mal!"); }
            else if (oponente1.GetType().ToString().IndexOf("Heroi") >= 0 && oponente2.GetType().ToString().IndexOf("Heroi") >= 0)
            { Console.WriteLine("Confronto Herói contra Herói!"); }
            else
            { Console.WriteLine("Confronto Vilão contra Vilão!"); }
            Console.WriteLine();
            Console.WriteLine("{0} - Pf({1}) \t\tVERSUS\t\t {2} - Pf({3})", oponente1.Nome, oponente1.Pf, oponente2.Nome, oponente2.Pf);
            Console.WriteLine();
            Random rnd = new Random();
            while (oponente1.Pf > 0 && oponente2.Pf > 0)
            {                
             
                switch (rnd.Next(1, 3))
                {
                    case 1: oponente1.Atacar(oponente2); break;
                    case 2: oponente2.Atacar(oponente1); break;
                    default: Console.WriteLine("Falha no jogo!\t Informe ao programdor (Erro: Class:Confronto-Confrontar-switch)"); break;
                }
            }

            if (oponente1.Pf > oponente2.Pf)
            {
                Console.WriteLine();
                Console.WriteLine("Combate encerrado: vencedor : {0} - Pf({1})", oponente1.Nome, oponente1.Pf);
                Console.WriteLine("Combate encerrado: perdedor : {0} - Pf({1})", oponente2.Nome, oponente2.Pf);
                if (oponente1.Drenador) oponente1.Drenar(oponente2);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Combate encerrado: vencedor : {0} - Pf({1})", oponente2.Nome, oponente2.Pf);
                Console.WriteLine("Combate encerrado: perdedor : {0} - Pf({1})", oponente1.Nome, oponente1.Pf);
                if (oponente2.Drenador) oponente2.Drenar(oponente1);
            }
        }
    }
}
