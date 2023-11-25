﻿using System;
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
        [MarqueName("peugeot")]
        peugeot,
        [MarqueName("renault")]
        renault,
        [MarqueName("citroen")]
        citroen,
        [MarqueName("audi")]
        audi,
        [MarqueName("ferrari")]
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
            this.id = Increment;
            Increment++;
        }
        public void AfficherOptions()
        {
            foreach (Option option in options)
            {
                option.Afficher();
            }
        }
        public void AjouterOption(Option option)
        {
            options.Add(option);
        }
        public virtual void Afficher() {
            Console.WriteLine($"info du Vicule id {id}:");
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
