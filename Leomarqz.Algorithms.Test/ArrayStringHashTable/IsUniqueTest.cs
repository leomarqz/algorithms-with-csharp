using Leomarqz.Algorithms.ArrayStringHashTable;
using System;

namespace Leomarqz.Algorithms.Test.ArrayStringHashTable
{
    [TestClass]
    public sealed class IsUniqueTest
    {
        [TestMethod]
        public void IsUnique_ShouldReturnTrue_ForUniqueCharacters()
        {
            // cadena de caracteres unica
            string input = "abcdefg"; //true

            // accion
            bool result = Unique.IsUnique(str: input);

            // Verificacion
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsUnique_ShouldReturnFalse_ForNonUniqueCharacters()
        {
            // cadena de caracteres no unica
            string input = "hello"; //false

            // accion
            bool result = Unique.IsUnique(str: input);

            // Verificacion
            Assert.IsFalse(result);
        }

        //test sobre fallo
        [TestMethod]
        public void IsUnique_ShouldThrowArgumentException_ForEmptyString()
        {
            // Se lanzo una excepcion ?
            bool thrown = false;

            // cadena de caracteres vacia
            string input = ""; // Exception

            // accion
            try
            {
                Unique.IsUnique(str: input);
            }
            catch (ArgumentException)
            {
                thrown = true;
            }
            // Verificacion
            Assert.IsTrue(thrown);
        }

    }
}
