using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace programme_json
{
    class Personne
    {
        public string nom { get; private set; }
        public int age { get; private set; }
        public bool majeur { get; private set; }

        public Personne(string nom, int age, bool majeur)
        {
            this.nom = nom;
            this.age = age;
            this.majeur = majeur;
        }

        public void Afficher()
        {
            Console.WriteLine("Nom: " + nom + " - age: " + age + " ans");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*var personne1 = new Personne("Toto", 20, true);
            personne1.Afficher();

            string json = JsonConvert.SerializeObject(personne1);
            Console.WriteLine(json);

            List<string> noms = new List<string>() { "Jean", "Paul", "Claire" };
            string jsonListe = JsonConvert.SerializeObject(noms);
            Console.WriteLine(jsonListe);


            string jsonTiti = "{\"nom\":\"Titi\",\"age\":15,\"majeur\":false}";
            Personne titi = JsonConvert.DeserializeObject<Personne>(jsonTiti);
            titi.Afficher();*/

            // 1 - Créer une liste de personnes (3 - 4)
            // 2 - Sérialiser
            // 3 - Ecrire ce json -> fichier texte "personnes.txt" WriteAllText

            /*var personnes = new List<Personne>()
            {
                new Personne("Paul", 20, true),
                new Personne("Claire", 17, false),
                new Personne("Martin", 30, true)
            };

            var json = JsonConvert.SerializeObject(personnes);
            Console.WriteLine(json);

            File.WriteAllText("personnes.txt", json);*/

            // 1 - Lire le json à partir du fichier
            // 2 - Créer vos personnes à partir du json (deserialise)
            // 3 - Afficher les personnes

            string json = File.ReadAllText("personnes.txt");
            var personnes = JsonConvert.DeserializeObject<List<Personne>>(json);

            foreach(var personne in personnes)
            {
                personne.Afficher();
            }
        }
    }
}
