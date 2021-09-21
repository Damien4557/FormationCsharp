using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsole
{
    public class MesMethode
    {
        //Par convention: Classe, Méthode, Interface -- pour le nommage on utilise le PascalCase: MaClasse
        //Pour les variable: on utilise le camlCase / maVariable

        //Une classe donnée peut posséder 2 types de méthodes:
        //une methode d'instance: accessible via une instance de la classe en question - instancer une classe = creer un objet de cette classe
        //une methode e classe: une methode static (une methode de classe) - pas besoin d'instancier la classe pour avoir acces aux methodes static
        //visibilité [static] Type-Retour (void) Nom_Méthode(parametres) {instruction}
        /// <summary>
        /// Méthode de calcule de la somme de deux entiers
        /// </summary>
        /// <param name="x">est un entier</param>
        /// <param name="y">est un entier</param>
        /// <returns>renvoie un entier</returns>
        public static int Somme(int x, int y)
        {
            return x + y;
        }
        //Surcharge d'une methode: pouvoir definir la meme methode (mm signature) dans la meme avec uniquement la liste des parametre qui change 
        public static int Somme(int x, int y, int z)
        {
            return x + y + z;
        }

        public static void Afficher(string chaine)
        {
            Console.WriteLine(chaine);
        }
        //Definir une methode qui liste le contenu d'un tableau d'entiers

        public static void Afficher(int[] tab)
        {
            foreach (var item in tab)
            {
                Console.WriteLine(item);
            }
        }

        //Une methode qui revoie la somme des elements d'un tableau d'entiers
        public static int SommeElement(int[] tab)
        {
            int somme = 0;
            foreach (var item in tab)
            {
                somme += item;
            }
            return somme;
         
        }


        //une autre qui renvoie la moyenne des élements d'un tableau d'entiers

        public static double Moyenne(int[] tab)
        {
            double somme = 0;
            foreach (var item in tab)
            {
                somme += item;
            }
            return somme / tab.Length;

        }
        //et une qui renvoie la plus petite valeur du tableau 

        public static int Min(int[] tab)
        {
            int min  = tab[0];
            for (int i = 1; i < tab.Length; i++)
            {
                if (min > tab[i])
                {
                    min = tab[i];
                }
            }
            return min;

        }

        //parametre optionnels d'une methode
        //z est un parametre optionnel: il possede une valeur par defaut
        //param optionnel possede des valeur par defaut et doivent etre definie a la fin de la liste des parametre
        public static int SommeOptional(int x, int y,int z = 10)
        {
            return x + y + z;
        }

        //methode qui permute 2 entiers 
        //passage de paramtre par reference, s'utilise uniquement avec les types simple (types valeur) - 
        public static void Permuter(ref int x,ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        //parametre en sortie d'une methode 
        public static double Calculer(double a, double b, out double somme, out double moyenneSortie)
        {

            somme = a + b;
            moyenneSortie = (a + b) / 2;
            return a * b;
        }
    }
}
