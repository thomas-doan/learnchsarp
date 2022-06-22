using System;

namespace learn
{
    class Program
    {

            //demander nom

            static string demanderNom(string numero_personne)
            {

                Console.Write($"Quel est ton nom numero {numero_personne}?");

                string nom = Console.ReadLine();

                while (nom.Trim() == "")
                {
                    Console.WriteLine("il faut rentrer un  nom obligatoirement");
                     nom = Console.ReadLine();
                }

            return nom;

            }

            // demander age

            static int demanderAge()
            {

            int age_num = 0;

            while (age_num <= 0)
                {
         

                    Console.Write("Quel est votre age ?");
                    string ageDeLaPersonne = Console.ReadLine();

                    try
                    {

                     age_num = int.Parse(ageDeLaPersonne);
       
           if (age_num < 0 || age_num == 0)
                    {
                       Console.WriteLine("Impossible de rentrer un age négatif");
                    }

                    }
                    catch
                    {
                        Console.WriteLine("Erreur, vous devez rentrer un age valide");
                    }

           

                };
            return age_num;
            }

        //afficher les informations
        static string AfficherInformation(string nom, int age_num) {
            int age_num_plus_1 = age_num + 1;

            string result = $"Bonjour {nom} ! Votre age est {age_num} ans. " +
                $"vous allez avoir {age_num_plus_1}";

            return result;

            }


        static void Main(string[] args)

        {

            string nom = demanderNom("1"); 
            string nom2 = demanderNom("2");
            int age_num1 = demanderAge();
            int age_num2 = demanderAge();

            string result_info = AfficherInformation(nom, age_num1);
            string result_info2 = AfficherInformation(nom2, age_num2);

            Console.WriteLine(result_info);
            Console.WriteLine(result_info2);

        }
    }
}
    