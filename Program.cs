using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
 namespace chercher_le_mot;
 static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
      //creation de la liste du fichier dictionnaire
        List <string> motsdictionnaire = File.ReadAllLines("dictionnaire.txt").select(i => i.ToLower().Trim()).ToList();
        Console . WriteLine("entrez les mots avec les lettres en désordre");
        string inputMot = Console.ReadLine();
        List <string> motsDesordonnés.Trim().Split(',')
        bool correspondance = true;
        foreach ( string mot in motsDesordonnés )
        { 
           string motTrier = new string(mot.OrderBy(c => c).ToArray()); 
            foreach ( string motDictionnaire in motsdictionnaire)
                {
                    var motDictionnaireTri = new string(motsdictionnaire.OrderBy(c => c).ToArray());
                    if (motDictionnaireTri.Equals(motTrier))
                    {
                        Console.WriteLine($"{mot}:correspond à {motDictionnaire} \n");
                        correspondance=true;
                        break;
                    }
                }
                   if (!correspondance){
                     Console.WriteLine($"{mot}:ne correspond à aucun mot \n");
                   }
            }

           
        }