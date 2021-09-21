using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaration des variable
            string choix = "";
            int valeur1 = 0, valeur2 = 0;

            //affichage d'un menu
            Console.WriteLine("....... CALCULATRICE CONSOLE........");
            Console.WriteLine("Addiction: tapez a"  );
            Console.WriteLine("Soustraction: tapez s");
            Console.WriteLine("Multiplication: tapez m");
            Console.WriteLine("Division: tapez d");

            //recuperer le choix : tant que le choix saisi est invalide - inviter le user à rejouer
            //Tant que les valeurs saisie ne sont pas valides : le user doit saisir de nouvelle valeurs
            do
            {
                Console.WriteLine("Merci de faire votre choix");
                choix = Console.ReadLine();
            } while (!(choix== "a" || choix == "s" || choix == "m" || choix == "d"));

      

            do
            {
                Console.WriteLine("Merci de saissir la premiere valeur:");
                try
                {
                    valeur1 = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {

                    
                }
               
            } while (true);

            do
            {
                Console.WriteLine("Merci de saissir la dexieme valeur:");
                try
                {
                    valeur2 = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {


                }

            } while (true);


            Console.WriteLine($"{valeur1} + {valeur2} = {valeur1 + valeur2}");

            switch (choix)
            {
                case "a":
                    Console.WriteLine(valeur1 + "+" + valeur2 + "=" +(valeur1 + valeur2)); 
                    break;
                case "s":
                    Console.WriteLine(valeur1 + "-" + valeur2 + "=" + (valeur1 - valeur2));
                    break;
                case "m":
                    Console.WriteLine(valeur1 + "*" + valeur2 + "=" + (valeur1 * valeur2));
                    break;
                case "d":
                    Console.WriteLine(valeur1 + "/" + valeur2 + "=" + (valeur1 / valeur2));
                    break;

            }

        }
    }
}
