using System;


namespace nombre_magique
{ 

    class Program
    {


        static int DemanderNombre(int min, int max)
        {

            int nbrUtilisateur = 0;
     

            while (nbrUtilisateur == 0)
            {

                try
                {
                    Console.Write($"Rentrer un nombre :");
                    string result = Console.ReadLine();
    
                    nbrUtilisateur = int.Parse(result);

                    if ((nbrUtilisateur > max) || (nbrUtilisateur < min))
                    {
                        Console.WriteLine($"le chiffre doit entre {min} et {max} !");
                        DemanderNombre(min, max);
                       
                    }

                }

                catch
                {
                    Console.WriteLine($"Cela doit être un chiffre !");
                }

            }

            return nbrUtilisateur;
        }


        static int GenererNombreAleatoire()
        {

            Random aleatoire = new Random();

            int entierUnChiffre = aleatoire.Next(1,10);

            return entierUnChiffre;

        }


        static string GenererSolution(int min, int max)
        {
           int nbrEchec = 5;
            Console.WriteLine($" nombre d'echec : {nbrEchec} ");
           int nbrAletoireGenere = GenererNombreAleatoire();
            Console.WriteLine($" nombre aleatoire créer : {nbrAletoireGenere} ");
            int resultDemanderNombre = DemanderNombre(min, max);
           
           string result = "";


            while (nbrAletoireGenere != resultDemanderNombre)
            {
              
                    if (nbrEchec != 1)
                    {
                        nbrEchec--;

                        if (resultDemanderNombre < nbrAletoireGenere)
                    {
                        Console.WriteLine("Votre chiffre est supérieur");
                    } else
                    {
                        Console.WriteLine("Votre chiffre est inférieur");
                    }

                        Console.WriteLine($"Il vous reste {nbrEchec} tentative");
                        resultDemanderNombre = DemanderNombre(min, max);

                    }
                    else
                    {
                        Console.Write("Votre nombre de tentative est dépassée");
                        break;
                    }
                
            }

            if (nbrAletoireGenere == resultDemanderNombre)
            {
                result = "victoire";
            }
                         
            return result;
     
        }

        static void Main(string[] args)
        {
            const int NOMBRE_MIN = 1;
            const int NOMBRE_MAX = 10;
            string test = GenererSolution(NOMBRE_MIN, NOMBRE_MAX);

            Console.Write(test);

        }

    }


}