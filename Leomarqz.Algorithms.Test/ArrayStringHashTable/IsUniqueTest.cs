using Leomarqz.Algorithms.ArrayStringHashTable;

namespace Leomarqz.Algorithms.Test.ArrayStringHashTable
{
    [TestClass]
    public sealed class IsUniqueTest
    {
        [TestMethod]
        public void IsUnique_ShouldReturnTrue_ForUniqueCharacters()
        {
            // Arrange
            string input = "abcdefg"; //true
            // Act
            bool result = Unique.IsUnique(str: input);
            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsUnique_ShouldReturnFalse_ForNonUniqueCharacters()
        {
            // Arrange
            string input = "hello"; //false
            // Act
            bool result = Unique.IsUnique(str: input);
            // Assert
            Assert.IsFalse(result);
        }

        //fail
        [TestMethod]
        public void IsUnique_ShouldThrowArgumentException_ForEmptyString()
        {
            bool thrown = false;
            // Arrange
            string input = ""; // Exception
            // Act & Assert
            try
            {
                Unique.IsUnique(str: input);
            }
            catch (ArgumentException)
            {
                thrown = true;
            }
            Assert.IsTrue(thrown);
        }

    }
}
