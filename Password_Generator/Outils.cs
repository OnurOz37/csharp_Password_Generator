using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCS
{
     static class Outils
    {
        public static int DemanderNombrePositifNonNul(string question)
        {
            //int positif = DemanderNombre(question);
            //if (positif >0)
            //{
            //    return positif; 
            //}
            //Console.WriteLine("ERROR : Veuillez entrer un nombre positif");

            //return DemanderNombrePositifNonNul(question); 
            return DemanderNombreEntre(question, 1, int.MaxValue, "ERROR: Le nombre doit être positif et non nul ");
        }
        public static int DemanderNombreEntre(string question, int min, int max, string messageErreur = null)
        {



            int nombre = DemanderNombre(question);

            if ((nombre <= max) && (nombre >= min))
            {
                return nombre;

            }
            if (messageErreur ==null)
            {
                Console.WriteLine("ERROR : Le nombre doit etre compris entre  " + min + " et " + max);
            }
            else
            {
                Console.WriteLine(messageErreur);
            }
               
                Console.WriteLine();

            
            return DemanderNombreEntre(question, min, max); //C'est une fonction récursive, ca permet de boucler comme avec while


        }
        public static int DemanderNombre(string question)
        {
            while (true)
            {
                Console.WriteLine(question);
                string reponse = Console.ReadLine();
                try
                {

                    int reponseInt = int.Parse(reponse);
                    return reponseInt;
                }
                catch
                {

                    Console.WriteLine("ERROR: Veuillez entrer un nombre");
                }

            }

        }

    }
}
