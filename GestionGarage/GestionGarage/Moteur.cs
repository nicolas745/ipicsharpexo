using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionGarage
{
    public class NameMoteurAttribute : Attribute
    {
        public string Value { get; }

        public NameMoteurAttribute(string value)
        {
            Value = value;
        }
    }

    enum TypeMoteur
    {
        [NameMoteur("Diesel")]
        diesel,
        [NameMoteur("Essence")]
        essence,
        [NameMoteur("Hybride")]
        hybride,
        [NameMoteur("Électrique")]
        electrique
    }
    internal class Moteur
    {
        private static int increlent= 0;
        private int id;
        private String nom;
        private TypeMoteur typeMoteur;
        private int puissance;
        private string GetEnumDisplayMoteurName(Enum value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());
            var attribut = (NameMoteurAttribute)Attribute.GetCustomAttribute(fieldInfo, typeof(NameMoteurAttribute));

            return attribut?.Value ?? value.ToString();
        }
        public Moteur(string nom, TypeMoteur typeMoteur, int puissance)
        {
            this.nom = nom;
            this.typeMoteur = typeMoteur;
            this.puissance = puissance;
        }
        public void Afficher()
        {
            Console.WriteLine("Moteur : ");
            Console.WriteLine($"nom: {this.nom}");
            Console.WriteLine($"type: {GetEnumDisplayMoteurName(this.typeMoteur)}");
            Console.WriteLine($"puissance : {this.puissance}");
        }
    }
}
