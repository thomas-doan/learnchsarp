using System;

namespace projet_eshop_pizza

{

    class Pizza
    {
       public string nom { get; init; }
        float prix { get; init; }
        bool vegetarienne { get; init; }
        List <string> ingredients;

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
           string nomFormate = FormaterNomDePizzaPremiereLettreMajuscule(nom);

            string badgeVegetarienne = "(V)";

            if(!vegetarienne)
            {
                 badgeVegetarienne = "";
            } 
            
                Console.WriteLine($"{nomFormate} {badgeVegetarienne} - {prix}€");
                Console.WriteLine($"{string.Join(", ", ingredients)}");
                Console.WriteLine();
         
            
        }

        private static string FormaterNomDePizzaPremiereLettreMajuscule(string data_nom_pizza)
        {
            

           string nomMinuscule = data_nom_pizza.ToLower();

           char premiereLettreMajuscule =  char.ToUpper(data_nom_pizza[0]);

           string resultat = $"{premiereLettreMajuscule}{nomMinuscule[1..]}";
             
            return resultat;

        }
        

    }

class Program
    {

        static void Main(string[] args)
    {

            var liste_de_pizzas = new List<Pizza>
            {
                new Pizza("4 fromages", 8.5f, false, new List<string>{"roquefort", "chevre", "conte", "gorgo"}),
                new Pizza("SUPER Vege", 8f, true, new List<string>{"tomate", "salade", "haricot"}),
                new Pizza( "royal" ,9.5f, false, new List<string>{"tomate", "jambon", "fromage"} ),
                new Pizza("soLEIL du midi", 12.5f, true, new List<string>{"tomate", "basilic", "vinaigre", "gorgo"} ),
            };


            foreach (var pizza in liste_de_pizzas)
            {
                pizza.Afficher();
            }

    }



    }


}
