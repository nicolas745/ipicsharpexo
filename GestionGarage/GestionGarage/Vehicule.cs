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

        private string GetEnumDisplayMarqueName(Enum value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());
            var attribut = (MarqueNameAttribute)Attribute.GetCustomAttribute(fieldInfo, typeof(MarqueNameAttribute));

            return attribut?.Value ?? value.ToString();
        }
        public Vehicule(String nom, Marque marque, Moteur moteur) {
            this.nom = nom;
            this.marque = marque;
            this.moteur = moteur;
            this.Id = Increment;
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
        public void AjouterOption(Option option)
        {
            Options.Add(option);
        }
        public virtual void Afficher() {
            Console.WriteLine($"info du Vicule id {Id}:");
            Console.WriteLine($"nom : {this.nom}");
            Console.WriteLine($"Marque: {GetEnumDisplayMarqueName(this.marque)}");
            this.moteur.Afficher();
            this.AfficherOptions();
        }

        public abstract void CalculerTaxe();
        public decimal PrixTotal()
        {
            return 0;
        }

    }
}
