using FormationCS;
using System;


namespace Password_Generator
{
    class Program
    {
      
        static void Main(string[] args)
        {
            const int nb_mdp = 10; 
           
            int longueurMotDePasse = Outils.DemanderNombrePositifNonNul("Longueur du mot de passe : ");
            Console.WriteLine();
            int choixAlphabet = Outils.DemanderNombreEntre("Vous voulez un mot de passe avec :\n" + 
                "1- Uniquement des caractères en miniscule\n" +
                "2- Des caractères miniscules et majuscules\n" + 
                "3- Des caractères et des chiffres\n" + 
                "4- Caractères, chiffres et caractères spécieaux\n" +
                "Votre choix : ", 1, 4);

          
            string miniscules = "abcdefghijklmnopqrstuvwxyz";
            string majuscules =miniscules.ToUpper();
            string chiffres = "0123456789";
            string caracteresS = "€#&+-¤$ù%!?";
            string alphabet;
            string motDePasse = "";
          
            Random rand = new Random();

            if (choixAlphabet ==1)
            {
                alphabet = miniscules;
            }
            else if (choixAlphabet==2)
            {
                alphabet = miniscules + majuscules; 
            }
            else if (choixAlphabet==3)
            {
                alphabet = miniscules + majuscules + chiffres; 
            }
            else
            {
                alphabet = miniscules + majuscules + chiffres + caracteresS; 
            }
            int l = alphabet.Length;
            int num = 0;
            for (int j = 0; j < nb_mdp; j++)
            {
                motDePasse = "";
                num++;
                for (int i = 0; i < longueurMotDePasse; i++)
                {
                    int index = rand.Next(0, l);
                    motDePasse += alphabet[index];
                    

                }
               
                Console.WriteLine("Password " +num + " =" + motDePasse);
            }

            
            




        }
    }
}
