using System;
using System.Collections.Generic;
using System.Linq;

namespace programme_poo
{
    class Personne
    {
        static int nombreDePersonnes = 0;

        public string nom;
        int age;
        string emploi;
        int numeroPersonne;


        public Personne(string nom, int age, string emploi)
        {
            this.nom = nom;
            this.age = age;
            this.emploi = emploi;

            nombreDePersonnes++;

            this.numeroPersonne = nombreDePersonnes;
        }

        public Personne (string nom, int age) : this(nom, age, null)
        {
         
        }


        public void Afficher()
        {
            Console.WriteLine("PERSONNE N°" + numeroPersonne);
            Console.WriteLine("  NOM : " + nom);
            Console.WriteLine("  AGE : " + age + " ans");
            if (emploi == null)
            {
                Console.WriteLine("  Aucun emploi spécifié");
            }
            else
            {
                Console.WriteLine("  EMPLOI : " + emploi);
            }
        }

        public static void AfficherNombreDePersonnes()
        {
            Console.WriteLine("Nombre total de personnes : " + nombreDePersonnes);
        }
    }

    class Program
    {
        /*static void AfficherInfosPersonne(string nom, int age, string emploi)
        {
            Console.WriteLine("NOM : " + nom);
            Console.WriteLine("  AGE : " + age + " ans");
            Console.WriteLine("  EMPLOI : " + emploi);
        }*/

        static void Main(string[] args)
        {
            // nom, age, emploi
            /*var noms = new List<string> { "Paul", "Jacques", "David", "Juliette" };
            var ages = new List<int> { 30, 35, 20, 8 };
            var emplois = new List<string> { "Développeur", "Professeur", "Etudiant", "CP" };

            for (int i = 0; i < noms.Count; i++)
            {
                AfficherInfosPersonne(noms[i], ages[i], emplois[i]);
            }*/

            //Personne personne1 = new Personne("Paul", 30, "Développeur");
            //personne1.Afficher();

            //Console.WriteLine("nom personne1: " + personne1.nom);

            /*
            Personne personne2 = new Personne("Jacques", 35, "Professeur");
            personne2.Afficher();*/

            var personnes = new List<Personne> {
                new Personne("Paul", 30, "Développeur"),
                new Personne("Jacques", 35, "Professeur"),
                new Personne("David", 20, "Etudiant"),
                new Personne("Juliette", 8),
            };

            personnes = personnes.OrderBy(p => p.nom).ToList();

            foreach (var personne in personnes)
            {
                personne.Afficher();
            }

            Personne.AfficherNombreDePersonnes(); 

           // var personne1 = new Personne("Paul", 30);
           // personne1.Afficher();


            // EMPLOI : (non spécifié)
        }
    }
}
