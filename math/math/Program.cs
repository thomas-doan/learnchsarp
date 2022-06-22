using System;

namespace math
{

    class Program
    {


        static generer_aleatoirement_question()
        {




        };



        static int Generer_question(int nbr_de_question)

        {
            int initialisation_num_question = 1;

            int test = 1;


            while (initialisation_num_question < nbr_de_question)
            {
                 Console.WriteLine($"numero de question : {initialisation_num_question} / {nbr_de_question}");
                generer_aleatoirement_question();
                initialisation_num_question++;

            }

            return test;
 

        }


        static void Main(string[] args)
        {
        const int NOMBRE_DE_QUESTION = 5;
            List<int> tableau = new List<int>();
            

  
      Generer_question(NOMBRE_DE_QUESTION);

           

        }

    }

}