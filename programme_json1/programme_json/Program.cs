using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace programme_json
{
    class Personne
    {
        public string prenom { get; init; }
        public string nom;
     

        public Personne(string prenom, string nom)
        {
            this.prenom = prenom;
            this.nom = nom;

        }


        public void Afficher()
        {
            Console.WriteLine("Nom: " + nom + " - age: " + " ans");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //var personne1 = new Personne();
            //personne1.nom = "Toto";
            //personne1.age = 20;
            //personne1.majeur = true;
            ////personne1.Afficher();

            //string json = JsonConvert.SerializeObject(personne1);
            //Console.WriteLine(json);

            //string jsonTiti = "{\"nom\":\"Titi\",\"age\":15,\"majeur\":false}";
            //Personne titi = JsonConvert.DeserializeObject<Personne>(jsonTiti);
            //titi.Afficher();

  //         Personne personne1 = new Personne("thomas", "doan");
  //          Personne personne2 = new Personne("dodobo", "dodo");
  //          Personne personne3 = new Personne("supertoto", "toto");

  //          List<Personne> listeOfPerson = new List<Personne>() {
  //               personne1,
  //              personne2,
  //              personne3
  //};
  //          var json = JsonConvert.SerializeObject(listeOfPerson);
  //          Console.WriteLine(json);

            var path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filename = "monFichierTest.txt";

            string pathAndFile = Path.Combine(path, filename);

            //File.WriteAllText(pathAndFile, json);

            string json2 = File.ReadAllText(pathAndFile);



            dynamic jsonObj = JsonConvert.DeserializeObject<List<Personne>>(json2);

            int i = 0;

            foreach (var dataOfobject in jsonObj)
            {
                //dataOfobject.Afficher();
                dataOfobject.nom = $"toeeeto{i++}"; 
                Console.WriteLine(dataOfobject.nom);
            }

            //Personne ListPersonn = JsonConvert.DeserializeObject<Personne>(json);

            
           

            
        }
    }
}
