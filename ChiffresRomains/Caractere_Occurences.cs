using System;
using System.Collections.Generic;

namespace ChiffresRomains
{
    public class Caractere_Occurences
    {
        public int Valeur { get; }

        public Caractere_Occurences(char caractere, int occurences)
        {
            Valeur = occurences * caractereRomain_to_Valeur(caractere);
        }


        private Dictionary<char, int> _caractere_romain_To_Decimal = new Dictionary<char, int>()
            {
                {'I', 1},
                {'V', 5 },
                {'X', 10 },
                {'L', 50 },
                {'C', 100 },
                {'D', 500 },
                {'M', 1000 }
            };

        private int caractereRomain_to_Valeur(char caractereRomain)
        {
            if (_caractere_romain_To_Decimal.ContainsKey(caractereRomain))
                return _caractere_romain_To_Decimal[caractereRomain];
            throw new Exception(caractereRomain + " n'est pas un caractère romain");
        }


    }
}