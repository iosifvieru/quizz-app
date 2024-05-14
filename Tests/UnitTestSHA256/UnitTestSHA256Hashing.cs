/*
    Iosif Vieru

    Unit testing pentru clasa SHA256Hashing.

*/

using Microsoft.VisualStudio.TestTools.UnitTesting;

using proiect_ip;

namespace UnitTestProjectSHA256Hashing
{
    [TestClass]
    public class UnitTestSHA256Hashing
    {
        [TestMethod]
        public void BasicHashing()
        {
            SHA256Hashing hash = new SHA256Hashing();

            string result = hash.Hash("test");

            // cuvantul "test" hashuit folosind https://emn178.github.io/online-tools/sha256.html
            string expectedHash = "9f86d081884c7d659a2feaa0c55ad015a3bf4f1b2b0b822cd15d6c15b0f00a08";

            Assert.AreEqual(expectedHash, result);
        }

        [TestMethod]
        public void EmptyHash()
        {
            SHA256Hashing hash = new SHA256Hashing();

            string result = hash.Hash("");

            // "" hashuit folosind un site de pe net https://emn178.github.io/online-tools/sha256.html
            string expectedHash = "e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855";

            Assert.AreEqual(expectedHash, result);
        }
    }
}
