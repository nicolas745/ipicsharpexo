using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.ComponentModel.Design;

namespace ProjetJeuDuPendu {
    internal class jeux
    {
        /// <summary>
        /// function qui permet de commencer le jeux
        /// </summary>
        public void Start()
        {
            String motcach = "";
            int vie = 10;
            List<String> ListMots = ChargerMot();
            String mot = ChoisirMot(ListMots);
            for (int i = 0; i < mot.Length; i++)
            {
                motcach += "*";
            }
            while (vie != 0)
            {
                textjeux(mot, vie, motcach);

                String usermot = inputmot();
                if (usermot.Length == 1)
                {
                    if (!TestCaractere(mot, ref motcach, GetCaractere(usermot, 0)))
                    {
                        Console.WriteLine("domage c'est incorect");
                        vie--;
                    }
                }
                else if(!TestGagne(motcach, mot, usermot))
                {
                    Console.WriteLine("domage c'est incorect");
                    vie--;
                }
                if (TestGagne(motcach, mot,usermot))
                {
                    Console.WriteLine("tu a gagnier le mots c'est {0}", mot);
                    return;
                };
            }
            affichependu(vie);
            Console.WriteLine("Désolé vous avez perdu !");
        }
        /// <summary>
        /// une function qui choisi aléatoire des mots
        /// </summary>
        /// <param name="ListMots">une liste de mots</param>
        /// <returns>mots</returns>
        private string ChoisirMot(List<String> ListMots)
        {
            return ListMots[GetNombreAleatoire(ListMots)]; ;
        }
        /// <summary>
        /// function qui test si le jouer a gagnier
        /// </summary>
        /// <param name="motcach">le mots cacher</param>
        /// <returns>boolean</returns>
        private Boolean TestGagne(String motcach, String mot, String usermot)
        {   
            return !motcach.Contains("*") || mot == usermot;
        }

        private char GetCaractere(String mots, int index)
        {
            return mots[index];
        }
        private int GetNombreAleatoire(List<String> ListMots)
        {
            Random random = new Random();
            return random.Next(ListMots.Count);
        }
        private List<String> ChargerMot() {
            List<String> list = new List<String>
            {

            };
            foreach (string ligne in File.ReadLines("mots.txt"))
            {
                list.Add(ligne);
            }

            return list;
        }
        private Boolean TestCaractere(String mot, ref String motcach, char lettre)
        {
            if (mot.ToCharArray().Contains(lettre))
            {
                Console.WriteLine("{0} La letree est correct", lettre); ;
                for (int i = 0; i < mot.Length; i++)
                {
                    if (mot[i] == lettre)
                    {
                        char[] newcach = motcach.ToArray();
                        newcach[i] = lettre;
                        motcach = new string(newcach);
                    }
                }
                return true;
            }
            return false;
        }
        private String inputmot(){
            String usermot =Console.ReadLine();
            while (usermot.Length==0) {
                Console.WriteLine("Choisi une lettre / mots:");
                usermot = Console.ReadLine();
            }
            return usermot;
}
        private void affichependu(int vie)
        {
            String[] interfacetextpendu = new String[]{
                " {1}{2}{2}{2}{2}",
                " {1}  {3}",
                " {1}  {4}",
                " {1} {5}{6}{7}",
                " {1}  {6}",
                " {1} {8} {9}",
                "{0}{1}{0}"
            };
            foreach(String ligne in interfacetextpendu)
            {
                List<String> listcorp = new List<String> { "_", "|", "_", "|", "O", "/", "|", "\\", "/", "\\" };
                
                for(int i = vie-1; i >=0; i--)
                {
                    listcorp[9-i] = " ";
                }
                Console.WriteLine(ligne, listcorp[0], listcorp[1], listcorp[2], listcorp[3], listcorp[4], listcorp[5], listcorp[6], listcorp[7], listcorp[8], listcorp[9]);
            }
        }
        private void textjeux(String mot,int vie,String motcach)
        {
            affichependu(vie);
            Console.WriteLine("Il vous reste {0} coups à jouer", vie);
            Console.WriteLine("triche : {0}", mot);
            Console.WriteLine("mots : {0}", motcach);
            Console.WriteLine("Choisi une lettre / mots: ");
        }
    }
}
