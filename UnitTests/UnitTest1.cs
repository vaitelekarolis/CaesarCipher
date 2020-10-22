using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework.Internal;
using CaesarCipher;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CipherLetterCorrectlyShiftsSingleChar()
        {
            char letter = 'a';
            int shift = 7;
            char expectedResult = 'h';

            Caesar caesar = new Caesar();

            char actualResult = caesar.CipherLetter(letter, shift);

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void CipherCorrectlyEncriptsWithSimpleShift()
        {
            string phrase = "Ashened";
            int shift = 11;
            string expectedResult = "Ldspypo";

            Caesar caesar = new Caesar();

            string actualResult = caesar.Encrypt(phrase, shift);

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void CipherCorrectlyEncriptsWithNegativeShift()
        {
            string phrase = "HelloKitty";
            int shift = -15;
            string expectedResult = "SpwwzVteej";

            Caesar caesar = new Caesar();

            string actualResult = caesar.Encrypt(phrase, shift);

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void CipherCorrectlyDecrypts()
        {
            string phrase = "CzggjFdoot";
            int shift = 21;
            string expectedResult = "HelloKitty";

            Caesar caesar = new Caesar();

            string actualResult = caesar.Decrypt(phrase, shift);

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void CipherWorksWithLargerShift()
        {
            string phrase = "Hello World";
            int shift = 15634;
            string expectedResult = "Pmttw Ewztl";

            Caesar caesar = new Caesar();

            string actualResult = caesar.Encrypt(phrase, shift);

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void CipherIgnoresNonLetterCharacters()
        {
            string phrase = "J3110 Y0t1f#$`)";
            int shift = -24;
            string expectedResult = "H3110 W0r1d#$`)";

            Caesar caesar = new Caesar();

            string actualResult = caesar.Decrypt(phrase, shift);

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void CipherEncryptsThenDecryptsToSamePhrase()
        {
            string phrase = "All Tests Work";
            int shift = 5;

            Caesar caesar = new Caesar();

            string actualResult = caesar.Decrypt(caesar.Encrypt(phrase, shift), shift);

            Assert.AreEqual(phrase, actualResult);
        }
    }
}
