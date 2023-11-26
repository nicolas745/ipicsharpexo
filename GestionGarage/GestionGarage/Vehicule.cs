using GestionGarage.menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionGarage
{
    public class MarqueNameAttribute : Attribute
    {
        public string Value { get; }

        public MarqueNameAttribute(string value)
        {
            Value = value;
        }
    }
    enum Marque
    {
        [MarqueName("Peugeot")]
        peugeot,
        [MarqueName("Renault")]
        renault,
        [MarqueName("Citroen")]
        citroen,
        [MarqueName("Audi")]
        audi,
        [MarqueName("Ferrari")]
        ferrari
    }
    abstract class Vehicule
    {
        private static int Increment = 0;
        private int id = 0;
        private String nom;
        private decimal prixHT;
        private Marque marque;
        private List<Option> options = new List<Option>();
        private Moteur moteur;

        public int Id { get => id; set => id = value; }
        internal List<Option> Options { get => options; set => options = value; }
        public string Nom { get => nom; set => nom = value; }
        internal Moteur Moteur { get => moteur; set => moteur = value; }

        private string GetEnumDisplayMarqueName(Enum value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());
            var attribut = (MarqueNameAttribute)Attribute.GetCustomAttribute(fieldInfo, typeof(MarqueNameAttribute));

            return attribut?.Value ?? value.ToString();
        }
        public Vehicule(String nom, Marque marque, Moteur moteur) {
            this.Nom = nom;
            this.marque = marque;
            this.Moteur = moteur;
            this.Id = Increment;
            Console.WriteLine(Increment);
            Increment++;
        }
        public void AfficherOptions()
        {
            Console.WriteLine("List des option:");
            foreach (Option option in Options)
            {
                option.Afficher();
            }
        }
        public int getidmarque()
        {
            Marque[] listmarque = (Marque[])Enum.GetValues(typeof(Marque));
            for(int i = 0; i < listmarque.Count(); i++)
            {
                if (listmarque[i]==marque)
                {
                    return i;
                }
            }
            return -1;
        }
        public void AjouterOption(Option option)
        {
            Options.Add(option);
        }
        public virtual void Afficher() {
            Console.WriteLine($"info du Vicule id {Id}:");
            Console.WriteLine($"nom : {this.Nom}");
            Console.WriteLine($"Marque: {GetEnumDisplayMarqueName(this.marque)}");
            this.Moteur.Afficher();
            this.AfficherOptions();
        }
        public abstract Dictionary<String,String> data();
        public abstract void CalculerTaxe();
        public decimal PrixTotal()
        {
            return 0;
        }

    }
}
