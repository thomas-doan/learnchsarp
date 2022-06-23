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
                new Pizza("SUPER Vege", 8f, true, new List<string>{"tomates", "salade", "haricot"}),
                new Pizza( "royal" ,9.5f, false, new List<string>{"sauce tomate", "jambon", "fromage"} ),
                new Pizza("soLEIL du midi", 12.5f, true, new List<string>{"tomate", "basilic", "vinaigre", "gorgo"} ),
            };


            foreach (var pizza in liste_de_pizzas)
            {
                pizza.Afficher();
            }

    }



    }


}
