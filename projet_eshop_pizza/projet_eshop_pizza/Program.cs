using System;
using System.Linq;

namespace projet_eshop_pizza

{
    class PizzaPersonnalisee : Pizza

    {
        float prixfinal = 0;
        static int numeroPizzaPerso = 1;

        public PizzaPersonnalisee() : base("personnalisée", 5, false, null)
        {
            
            this.nom = $"{nom} n° {numeroPizzaPerso++}";
        
            ingredients = new List<string>();

          

            while (true)
            {
            Console.WriteLine($"Rentrez un ingrédient pour la pizza personnalisée n° {nom} : (ENTER pour terminier la saisie) ");
      
                var ingredientRentreParUtilisateur = Console.ReadLine();

              

                if (string.IsNullOrWhiteSpace(ingredientRentreParUtilisateur))
                {
                  
                    break;
                }

                if (ingredients.Contains(ingredientRentreParUtilisateur))
                {
                    Console.WriteLine("ingredient identique");

                }
                else
                {
                
                   
             
                ingredients.Add(ingredientRentreParUtilisateur);
              
                Console.WriteLine($"votre liste d'ingrédient rentrée : {string.Join(", ", ingredients)}");
                Console.WriteLine();
                   



                }
            }

            prix = 5 + (ingredients.Count * 1.5f);
        }

    }

    class Pizza
    {
        protected string nom;
        protected float prix;
       public bool vegetarienne { get; init; }
       public List <string> ingredients { get; protected set; }

        public Pizza(string nom, float prix, bool vegetarienne, List<string> ingredients)
        {

                this.nom = nom;
                this.prix = prix;
                this.vegetarienne = vegetarienne;
                this.ingredients = ingredients;
            

            if (string.IsNullOrEmpty(nom))
            {
                nom = "pizza sans nom";
                this.nom = nom;
            }
        

        }

        public void Afficher()
        {
            AfficherIngredientsPizza();

        }

        private void AfficherIngredientsPizza()
        {
           string nomFormate = FormaterPremiereLettreMajuscule(nom);

            string badgeVegetarienne = "(V)";

            if(!vegetarienne)
            {
                 badgeVegetarienne = "";
            }

            List<string> listeIngredientsFormate = FormaterListDeNomsPremieresLettresMaj(ingredients);

            var ingredientsNomFormate = new List<string>();

      


            Console.WriteLine($"{nomFormate} {badgeVegetarienne} - {prix}€");
                Console.WriteLine($"{string.Join(", ", listeIngredientsFormate)}");
                Console.WriteLine();
         
            
        }

        private static string FormaterPremiereLettreMajuscule(string data_nom_pizza)
        {
            

           string nomMinuscule = data_nom_pizza.ToLower();

           char premiereLettreMajuscule =  char.ToUpper(data_nom_pizza[0]);

           string resultat = $"{premiereLettreMajuscule}{nomMinuscule[1..]}";
             
            return resultat;

        }

        private static List<string> FormaterListDeNomsPremieresLettresMaj(List<string> ingredients)
        {
            // version classique sans utiliser le Link
            //var ingredientsNomFormate = new List<string>();

            // foreach (var data in ingredients)
            // {

            //     ingredientsNomFormate.Add(FormaterPremiereLettreMajuscule(data));
            // }

            // return ingredientsNomFormate;



            //AVEC Link ressemble fortement a JS

            //var ingredientsNomFormate = new List<string>();
            var  ingredientsNomFormate = ingredients.Select(i => FormaterPremiereLettreMajuscule(i)).ToList();

            // avec Link et select la nouvelle variable prend le type donc List <string> dans ce cas précis.

            return ingredientsNomFormate;

        }


    }

class Program
    {

        static void Main(string[] args)
    {

            var liste_de_pizzas = new List<Pizza>
            {
                new Pizza("4 fromages", 8.5f, false, new List<string>{"roquefort", "chevre", "conte", "gorgo"}),
                new Pizza("SUPER Vege", 3.5f, true, new List<string>{"tomates", "salade", "haricot"}),
                new Pizza( "royal" ,9.5f, false, new List<string>{"sauce tomate", "jambon", "fromage"} ),
                new Pizza("soLEIL du midi", 12.5f, true, new List<string>{"tomate", "basilic", "vinaigre", "gorgo"} ),
                 new PizzaPersonnalisee(),
                 new PizzaPersonnalisee(),
            };

            //liste_de_pizzas = liste_de_pizzas.OrderBy(i => i.prix).ToList();

            // selection de pizza vegetarienne
            //liste_de_pizzas = liste_de_pizzas.Where(i => i.vegetarienne).ToList();

            //prog fonctionnelle
            //liste_de_pizzas = liste_de_pizzas.Where(i => i.ingredients.Where(j => j.ToLower().Contains("tomate")).ToList().Count >0).ToList();
          




              

            foreach (var pizza in liste_de_pizzas)
            {
                pizza.Afficher();
            }
             

       

        }



    }


}
