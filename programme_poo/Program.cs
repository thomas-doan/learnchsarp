using System;
using System.Collections.Generic;
using System.Linq;

namespace programme_poo
{

    class Enfant : Etudiant
    {
        private string ClasseEcole;

        public Enfant(string nom, int age) : base(nom, age, null)
        {
            this.nom = nom;
            this.age = age;
        }

        private void DeterminerLaClasse(int age)
        {
                      switch (age)
            {
                     case 7 :
                    ClasseEcole = "CP";
                    break;

                case 8:
                    ClasseEcole = "CE1";
                    break;

                case 9:
                    ClasseEcole = "CE2";
                    break;

            }
        }

        public override void Afficher()
        {
            AfficherNomEtAge();
            DeterminerLaClasse(age);

            Console.WriteLine($"enfant en classe de {ClasseEcole} ");

      
            
                AfficherProfesseurPrincipal();
            


        }
    }

    class Etudiant : Personne
    {
       protected string infoEtudes;



        public Personne professeurPrincipal { get; init; }
      

      

        public Etudiant(string nom, int age, string infoEtudes) : base(nom, age, "Etudiant")
        {
            this.infoEtudes = infoEtudes;
 
        }

        // Etudiant en école d'ingénieur informatique

        public override void Afficher()
        {
            AfficherNomEtAge();

            if (emploi != null)
            {
                Console.WriteLine($"  etudiant en {infoEtudes} " );
            }

           
                AfficherProfesseurPrincipal();
            

        }


            protected void AfficherProfesseurPrincipal()
            {
            if (professeurPrincipal != null)
                {
                    Console.WriteLine($"le professeur est : ");
                professeurPrincipal.Afficher();

                }
            }


    }

    class Personne
    {

        static int nombreDePersonnes = 0;

        string _nom;

        public string nom
        {
            get
            {
                return _nom;
            }

            set
            {
                _nom = value;
            }
        }

        int _age;
        public int age
        {
            get
            {
                return _age;
            }

            set
            {
                _age = value;
            }
        }

        protected string emploi;

       protected int numeroPersonne;


        public Personne(string nom, int age, string emploi = null)
        {
            this.nom = nom;
            this.age = age;
            this.emploi = emploi;

            nombreDePersonnes++;
            this.numeroPersonne = nombreDePersonnes;
        }

        public virtual void Afficher()
        {
            AfficherNomEtAge();
            if (emploi == null)
            {
                Console.WriteLine("  Aucun emploi spécifié");
            }

        }

        protected void AfficherNomEtAge()
        {
            Console.WriteLine("PERSONNE N°" + numeroPersonne);
            Console.WriteLine("  NOM : " + nom);
            Console.WriteLine("  AGE : " + age + " ans");
   
        }

        public static void AfficherNombreDePersonnes()
        {
            Console.WriteLine("Nombre total de personnes : " + nombreDePersonnes);
        }
    }

    class Program
    {
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

            //var personnes = new List<Personne> {
            //    new Personne("Paul", 30, "Développeur"),
            //    new Personne("Jacques", 35, "Professeur"),
            //    new Etudiant("David", 20, "ecole d'ingenieur"),
            //    new Personne("Juliette", 8)
            //}; 

            //personnes = personnes.OrderBy(p => p.nom).ToList();

            //foreach (var personne in personnes)
            //{
            //    personne.Afficher();
            //}

            //Personne.AfficherNombreDePersonnes();

            //var personne1 = new Personne("Paul", 30);
            //var personne1 = new Personne() { age = 30, nom = "Paul", emploi="Ingénieur" };
            //var personne2 = new Personne("Jacques", 35, "Professeur");


            var etudiant = new Etudiant("Dav", 20, "ecole d'ingenieur")
            {
                professeurPrincipal = new Personne("John", 99, "professeur au top")
            };
            // etudiant.professeurPrincipal = new Personne("Jacques", 99, "professeur");
            etudiant.Afficher();

            var petitEnfant = new Enfant("sophie", 8) { professeurPrincipal = new Personne("Jacques", 99, "professeur")};
          
            petitEnfant.Afficher();

        }
    }
}
