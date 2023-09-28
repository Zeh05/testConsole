/**
 * Jeux du nombre caché
 * author : Gautier
 * date : 20/09/2023
 */
using System;

namespace testConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //déclaration
            int valeur = 0, essai, nbre = 1;
            bool correct = false; // Déclaration de type 'bool'

            // saisie du nombre à chercher
            while (!correct)
            {
                try
                {
                    Console.Write("Entrez le nombre à chercher = ");
                    valeur = int.Parse(Console.ReadLine());
                    correct = true;
                }
                catch
                {
                    Console.WriteLine("Erreur de saisie : Saisisez un nombre entier");
                }
            }
            Console.Clear();

            // saisie du premier essai
            Console.Write("Entrez un essai = ");
            essai = int.Parse(Console.ReadLine());

            while (essai != valeur)
            {
                // test de l'essaie par rapport à la valeur à chercher
                if (essai > valeur)
                {
                    Console.WriteLine(" --> trop grand ! ");
                }
                else
                {
                    Console.WriteLine(" --> trop petit ! ");
                }

                // saisie un essai
                Console.Write("Entrez un essai = ");
                essai = int.Parse(Console.ReadLine());

                // compteur d'essai
                nbre++;
            }
            // valeur trouvée
            Console.WriteLine("Vous avez trouvé en "+nbre+" fois ");

            Console.ReadLine();
        }
    }
}
