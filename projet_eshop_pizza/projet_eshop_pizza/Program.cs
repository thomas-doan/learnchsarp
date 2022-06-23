using System;

namespace projet_eshop_pizza

{

    class Pizza
    {
       public string nom { get; init; }
        float prix { get; init; }
        bool vegetarienne { get; init; }

        public Pizza(string nom, float prix, bool vegetarienne)
        {
            this.nom = nom;
            this.prix = prix;
            this.vegetarienne = vegetarienne;

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
         
            
        }

        private string FormaterNomDePizzaPremiereLettreMajuscule(string data_nom_pizza)
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
                new Pizza("4 fromages", 8.5f, false),
                new Pizza("SUPER Vege", 8f, true),
                new Pizza("royAL", 9.5f, false),
                new Pizza("soLEIL du midi", 12.5f, true)
            };

            foreach (var pizza in liste_de_pizzas)
            {
                pizza.Afficher();
            }

    }



    }


}
