using System;
using ProjetDll;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("test c#");

            Tools.MethodeDLL();




            #region Les variables

            // veriable: zone memoire contenant une valeur typée
            // Types simple (types valeur): entiers, reals, boolean, char
            // Types complexes (types reference): Array, string, enum, classe et objet


            //entiers: byte(1 o), shrt(2 o), long(8 o)
            //declarer une variable:Type Nom-Variable = valeur

            int myInt = 10;
            int myInt2 = myInt; 
            Console.WriteLine("Contenu de la varible myInt = " + myInt); // +: une concaténation

            char myChar = 'c';
            string chaine = "ceci est une chaine";
            string chaine2 = chaine;

            chaine = "nouvelle chaine";
            chaine = chaine.ToUpper();
            chaine = null;
            

            // Appel explicite du garbage collector: n'implique pas le passage immédit du garbage
            GC.Collect();

            

            //réel: float(4 o), double (8 o), decimal (16 o)
            double myDouble = 10.5;

            bool myBool = true;


            //le mot clé var: le compilateur determine le type de la variable selon la valeur
            var maVariable = 10;
            var maVariable1 = 10.5;
            // maVariable = 10 - Erreur de compilation

            //Contante: variable qui contient une valeur typée non modifiable (par convention les nom des const en majuscule

            const double MA_CONSTANTE = 10.5;
            #endregion



            #region Operateur
            //operateur arithmetique: modulo - reste de la division
            double resultat = 9 / 2;
            Console.WriteLine("9 devisé par :" + resultat); //4.5

            int mod = 9 % 2;
            Console.WriteLine("Reste de la division de 9 sur 2:" + mod); //1

            //operateurs d'incrementation et de decrementation

            int i = 5;
            i++; // i= i+ 1
            i--;// i = i -1

            i += 5; // i= i +5

            //operateur de comparaison : ==(egalité), <, >, <=,>=, !=
            //operateur logique : && (et), || (ou), ^ (ou exclusif), ! (non logique)
            int v1 = 10, v2 = 15;
            Console.WriteLine((v2 > v1) && (v2 < v1));//false

            //table logique
            //A      B       (A&&B)     (A||B)   (A^B)
            //v      v          v          v       f
            //v      f          f          v       v
            //f      v          f          v       v 
            //f      f          f          f       f

            //Caracteres d'echapement
            Console.WriteLine("\tBonjour, \nje suis en formation chez Dawan. \nFormation c#");
            string chemin = "c:\\test";

            //Chaine verbatim
            string chemin2 = @"c:\test";

            string paragraph = @"   Bonjour,
je suis chez Dawan.
Formation c#";


            //Formatage de chaine en utilisant l'intérpolation
            int x = 20, y = 30;
            Console.WriteLine("x = " + x + "y = " + y);//concatenation
            Console.WriteLine("x = {0} y = {1}", x, y);
            Console.WriteLine($"x = {x} y = {y}");
            #endregion


            #region Convertion de Types

            //convertion implicite: concerne le passage d'un type inferieur à un type superieux

            byte myByte = 10;
            int myInterger = myByte;
            

            //Coversion explicite
            //Utilisation d'un CAST : (byte), (int), (double)........ risque de perte de données
            //Utilisation de la classe Convert
            int myInterger2 = 10;
            byte myByte2 = (byte)myInterger2;
            byte myByte3 = Convert.ToByte(myInterger2);
            // byte myByte4 = byte.Parse(muInterger2); - la methode parse concerne les conversion en type compatible

            string str = "20";
            int chiffre = int.Parse(str);
            int chiffre2 = Convert.ToInt32(str);
            Console.WriteLine("Merci de saisir votre:");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Votre age est: {age} ");

            #endregion


            #region Conditions
            //if(condition est vraie) {instru1} else {instruc1}

            int nb = 5;
            if (nb > 0)
            {
                Console.WriteLine("nb est positif");
            }
            else if (nb == 0)
            {
                Console.WriteLine("nb est null");
            }
            else
            {
                Console.WriteLine("nb est negatif");
            }


            //Swicth : une variante de la condition if

            int note = 10;

            switch (note)
            {
                case 0:
                    Console.WriteLine("recalé");
                    break;
                case 10:
                case 11:
                case 12:
                    Console.WriteLine("juste la moyenne: 10, 11, 12");
                    break;
                default:
                    Console.WriteLine("Reussite garantie");
                    break;
            }

            //operateur ternaire: (condition)? expression 1 : expresion 2 -- si la condition est vrai : resultat = expresion 1 sinon resultat = expression 2

            bool myBoolean = (10 > 5) ? false : true;// myBoolean = flase;

            #endregion


            #region Boucles
            Console.WriteLine("********Boucle********");
            //boucle conditionnelles: while, do while
            //Boucle iteratives: for, for each

            //for: connaitre le nb d'iterations
            for (int index = 0; index < 5; index++)
            {
                Console.WriteLine($"Passage num : {index++}");
            }

            //for each: permet de faire un parcours complet d'une collection
            int[] tab = { 1, 2, 3, 4, 5 };
            foreach (int item in tab)//pour chaque entier item contenu dans le tableau tab
            {
                Console.WriteLine(item);
            }

            //while
            int valeur = 1;
            while (valeur < 5)// tant que valeur est inferieure à 5
            {
                Console.WriteLine($"Passage num : {valeur}");
                valeur++;

                //sortir de la boucle while si valeur == 3
                if (valeur == 3 )
                {
                    break;
                    //break permet de sortir de la boucle while
                }
            }

            //Do - While: tant que condition est vrai

            //do
            // {
            //    Console.WriteLine($"passage num: {valeur}");
            //   valeur++;
            // } while (true);
            #endregion


            #region Tableau
            Console.WriteLine("********Tableau********");
            //Tableau: ensemble d'élements - de taille fixe

            //1 dimension 
            int[] monTableau = new int[3];//tableau de 3 case
            monTableau[0]=10;
            monTableau[1]=20;
            monTableau[2] = 30;

            int[] monTableau2 = { 10, 20, 30 };
            Console.WriteLine("Taille du tableau2: " + monTableau2.Length);
            //lister le contenu du tableau

            foreach (var item in monTableau2)
            {
                Console.WriteLine(item);
            }
            for (int indice = 0; indice < monTableau2.Length; indice++)
            {
                Console.WriteLine(monTableau2[indice]);
            }

            //Tableau à 2 dimanssion
            int[,] matrice = new int[2, 3];
            matrice[0, 0] = 10;
            matrice[0, 1] = 15;
            matrice[0, 2] = 20;
            matrice[1, 0] = 25;
            matrice[1, 1] = 30;
            matrice[1, 2] = 30;

            int[,] matrice2 = { { 10, 20, 30 }, { 40, 50, 60 } };
            Console.WriteLine(matrice2[1,0]);//40

            Console.WriteLine("nb de ligne de matrice2: "+ matrice2.GetLength(0));//2
            Console.WriteLine("nb de ligne de matrice2: " + matrice2.GetLength(1));//3
            Console.WriteLine("nb de d'element de matrice2: " + matrice2.Length);//6
            Console.WriteLine("nb de dimention de matrice2: " + matrice2.Rank);//2

            //Lister le contenu de matrice2
            for (int ligne = 0; ligne < matrice2.GetLength(0); ligne++)
            {
                for (int colonne = 0; colonne < matrice2.GetLength(1); colonne++)
                {
                    Console.WriteLine(matrice2[ligne,colonne]);
                }
            }

            #endregion



            #region Méthode

            //Méthode: ensemble d'instruction reutilisables 
            // en programation objet, 2 types de methodes possibles:
            //Procedure: méthode qui ne renvoie aucun résultat
            //Fonction: méthode qui renvoie un resultat
            Console.WriteLine("********Methode********");
            
            int res = MesMethode.Somme(10, 20);
            Console.WriteLine($"somme de 10 et 20 est : {res}");

            MesMethode.Somme(10, 20, 30);

            MesMethode.Afficher("test de chaine");

            int[] tableau = { 10, 20, 0, 15 };
            Console.WriteLine("tableau 1");
            MesMethode.Afficher(tableau);
            Console.WriteLine("********tableau1********");
            int[] tableau2 = { 10, 20, 0, 15, 75, 55, 86 };
            Console.WriteLine("tableau 2");
            MesMethode.Afficher(tableau2);
            Console.WriteLine("********somme tableau 2********");
            int SommeElement = MesMethode.SommeElement(tableau2);
            Console.WriteLine(SommeElement);
            Console.WriteLine("********moyenne du tableau2********");
            double moyenne = MesMethode.Moyenne(tableau2);
            Console.WriteLine(moyenne);
            Console.WriteLine("********moyenne du tableau2********");
            int min = MesMethode.Min(tableau2);
            Console.WriteLine(min);

            // appel de la methode optionnel
            MesMethode.SommeOptional(10, 20);//40 z = 10
            MesMethode.SommeOptional(10, 20, 40);//70 z = 40
            //StreamWriter sw = new StreamWriter("");


            int valeur1 = 10, valeur2 = 20;
            Console.WriteLine($"avnt permutation: valeur 1 = {valeur1} - valeur2 = {valeur2}");
            MesMethode.Permuter(ref valeur1, ref valeur2);
            Console.WriteLine($"apres permutation: valeur 1 = {valeur1} - valeur2 = {valeur2}");


            //appel de la methode avec des param en sortie

            double a = 10, b = 20;
            double somme = 0, moyenneSortie = 0;
            double produit = MesMethode.Calculer(a, b , out somme, out moyenneSortie);


            string number = "50";
            int numConvert = 0;
            bool conversion = int.TryParse(number, out numConvert);

            if (conversion)
            {
                Console.WriteLine($"Conversion reussie - numConvert = {numConvert}");
            }
            else
            {
                Console.WriteLine("echec");
            }
            #endregion
            //maintenir la console active -> commentaire sur une ligne
            Console.ReadLine();
        }
    }
}
