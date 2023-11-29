using System;
using System.Collections.Generic;

namespace Liste
{
    class Program
    {
        static void menu()
        {
            Console.WriteLine(" gestion d'une Liste de mariage");
            Console.WriteLine(" 1 - ajouter un cadeau et son prix");
            Console.WriteLine(" 2 – offrir un cadeau (le cadeau sera supprimé ainsi que son prix");

            // le nom du cadeau sera saisi au préalable (on pourra utiliser le module 3 à conditionqu’il soit fait avant le 2)
            Console.WriteLine(" 3 - rechercher un cadeau par son nom, obtenir son indice dans le tableau, afficher son prix");
            Console.WriteLine(" 4 - vider les listes");
            Console.WriteLine(" 5 - afficher les listes avec foreach");
            Console.WriteLine(" 6 - afficher les listes avec une boucle");
            Console.WriteLine(" 10 - sortir ");
            Console.WriteLine(" Votre choix");
        }
        static void remplir(ref List<string> lesCadeaux, ref List<double> lesPrix)
        {
            lesCadeaux.Add("verre à eau "); lesPrix.Add(15);
            lesCadeaux.Add("verre à vin"); lesPrix.Add(18);
            lesCadeaux.Add("flute"); lesPrix.Add(20);
            lesCadeaux.Add("assiette à dessert"); lesPrix.Add(25);
            lesCadeaux.Add("assiette plate"); lesPrix.Add(35);
            lesCadeaux.Add("plat ovale"); lesPrix.Add(100);
            lesCadeaux.Add("plat rond"); lesPrix.Add(100);
            lesCadeaux.Add("soucoupes"); lesPrix.Add(150);
            lesCadeaux.Add("couette"); lesPrix.Add(380);
        }
        
        static void Affichage(ref List<string> lesCadeaux, ref List<double> lesPrix)
        {
            int i = 0;
            for (i = 0; i < lesCadeaux.Count; i++)
            {
                Console.WriteLine(i + " " + lesCadeaux[i] + " " +lesPrix[i]);
            }

        }

        static void ajout(ref List<string> lesCadeaux, ref List<double> lesPrix)
        {
            string cadeaux;
            int i;
            double prix;
            i = 0;

            Console.WriteLine("Veillez indiquer le cadeau");
            cadeaux = Console.ReadLine();

            Console.WriteLine("Veillez indiquer le prix");
            prix = Double.Parse(Console.ReadLine());

            lesCadeaux.Add(cadeaux);
            lesPrix.Add(prix);
            for (i = 0; i < lesCadeaux.Count; i++)
            {
                Console.WriteLine(i + " " + lesCadeaux[i] + " " + lesPrix[i]);
            }
        }
        
        static void suppr(ref List<string> lesCadeaux, ref List<double> lesPrix)
        {
            string cadeau;
            int i;

            Console.WriteLine("Quel cadeau voulez vous offrir ?");
            cadeau = Console.ReadLine();

            if(lesCadeaux.Contains(cadeau))
            {
                lesCadeaux.Remove(cadeau);
            }

            for (i = 0; i < lesCadeaux.Count; i++)
            {
                Console.WriteLine(i + " " + lesCadeaux[i] + " " + lesPrix[i]);
            }
        }

        static int rechercher(ref List<string> lesCadeaux, ref List<double> lesPrix)
        {
            string mot; int res = 0;
            Console.WriteLine("Quel cadeau voulez vous chercher ?");
            mot = Console.ReadLine();
            res = lesCadeaux.IndexOf(mot);
            return res;
        }

        static void vider(ref List<string> lesCadeaux, ref List<double> lesPrix)
        {
            lesCadeaux.Clear();
            lesPrix.Clear();
        }

        static void affiche(ref List<string> lesCadeaux, ref List<double> lesPrix)
        {
            int i = 0;
            foreach (string nom in lesCadeaux)
            {
                Console.WriteLine(i + " " + lesCadeaux[i] + " " + lesPrix[i]);
                i++;
            }

        }

        static void afficher(ref List<string> lesCadeaux, ref List<double> lesPrix)
        {
            int i = 0;
            for (i = 0; i < lesCadeaux.Count; i++)
            {
                Console.WriteLine(i + " " + lesCadeaux[i] + " " + lesPrix[i]);
            }

        }

        // Debut du void Main
        static void Main(string[] args)
        {
            int choix, pos, i;

            List<string> mesCadeaux = new List<string>();
            List<double> mesPrix = new List<double>();
            remplir(ref mesCadeaux, ref mesPrix);
            Affichage(ref mesCadeaux, ref mesPrix);
            Console.WriteLine("les listes viennent d'être remplies");
            Console.WriteLine("Appuyer sur une touche pour continuer");
            Console.ReadLine();

            Console.Clear();
            menu();
            choix = int.Parse(Console.ReadLine());

            switch (choix)
            {
            case 1 :
                ajout(ref mesCadeaux, ref mesPrix);
            break;

            case 2 :
                suppr(ref mesCadeaux, ref mesPrix);
            break;

            case 3:
                pos = rechercher(ref mesCadeaux, ref mesPrix);

                    if (pos > mesCadeaux.Count || pos < 0)
                        Console.WriteLine("Ce cadeau n'est pas dans la liste");
                    else
                    {
                        Console.WriteLine("Le cadeau est présent à la position n°" + pos);
                    }

                 Console.WriteLine("  ");
                    for (i = 0; i < mesCadeaux.Count; i++)
                    {
                        Console.WriteLine(i + " " + mesCadeaux[i] + " " + mesPrix[i]);
                    }
            break;

            case 4:
                vider(ref mesCadeaux, ref mesPrix);
                    Console.WriteLine("Les listes ont été vidé");
            break;

            case 5:
                affiche(ref mesCadeaux, ref mesPrix);
            break;

            case 6:
                afficher(ref mesCadeaux, ref mesPrix);
            break;
            }
            Console.WriteLine("Appuyez sur une touche pour sortir");
            Console.ReadLine();
        }
    }
}
