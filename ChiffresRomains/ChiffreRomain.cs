using System;
using System.Collections.Generic;
using System.Linq;

namespace ChiffresRomains
{ 
    public class ChiffreRomain
    {
        public int Entier { get; }

        public ChiffreRomain(string chiffreRomain)
        {
            var decoupages = Grouper_Par_Caractere_Occurences_Recursif(chiffreRomain.ToArray());
           
            var somme = 0;
            var i = 0;
            while(i  < decoupages.Count())
            {
                var actual = decoupages.ElementAt(i++);

                if (i < decoupages.Count())
                {
                    var next = decoupages.ElementAt(i);
                    if (actual.Valeur < next.Valeur)
                    {
                        somme -= actual.Valeur;
                        continue;
                    }
                }
                somme += actual.Valeur;
            }
            Entier = somme;
        }

        private IEnumerable<Caractere_Occurences> Grouper_Par_Caractere_Occurences_Recursif(char[] chiffreRomain)
        { 
            if (chiffreRomain.Length == 0)
                return new List<Caractere_Occurences>();

            if (chiffreRomain.Length == 1)
            {
                return new List<Caractere_Occurences>() { new Caractere_Occurences(chiffreRomain[0], 1) };
            }
           
            var i = 0;
            var premier = chiffreRomain.ElementAt(i++);
            var element = new Caractere_Occurences(premier, 1);
            var cpt = 1;
            while (i < chiffreRomain.Count())
            {
                var suivant = chiffreRomain.ElementAt(i++);
                if (premier == suivant)
                    element = new Caractere_Occurences(premier, ++cpt);
            }

            var reste = chiffreRomain.Skip(cpt).ToArray();
            var liste = new List<Caractere_Occurences> { element };
            return liste.Union(Grouper_Par_Caractere_Occurences_Recursif(reste));
        }
    }

}