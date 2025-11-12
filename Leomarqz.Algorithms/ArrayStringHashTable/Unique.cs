
using System.Collections;
using System.Collections.Generic;

namespace Leomarqz.Algorithms.ArrayStringHashTable
{
    public class Unique
    {
        /// <summary>
        /// Numero de caracteres ASCII estándar.
        /// </summary>
        private static readonly int NUMBER_OF_CHARS = 128;

        /// <summary>
        /// Determinar si todos los caracteres en una cadena son únicos.
        /// </summary>
        /// <param name="str"></param>
        /// <returns>
        /// True si todos los caracteres en la cadena son únicos, false en caso contrario.
        /// </returns>
        /// <exception cref="ArgumentException"></exception>
        public static bool IsUnique(string str)
        {
            HashSet<char> charSet = new HashSet<char>();

            if (string.IsNullOrEmpty(str))
                throw new ArgumentException("Input string cannot be null or empty.");

            if (str.Length > NUMBER_OF_CHARS) return false;

            foreach(char c in str)
            {
                if(charSet.Contains(c))
                {
                    return false;
                }
                charSet.Add(c);
            }

            return true;
        }
    }
}
