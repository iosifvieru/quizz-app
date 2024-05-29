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
        [TestMethod]
        public void TestRandom()
        {
            SHA256Hashing hash = new SHA256Hashing();

            string result = hash.Hash("ahjdjidid");

            // hashuit folosind un site de pe net https://emn178.github.io/online-tools/sha256.html
            string expectedHash = "42e7785ac991217bb41443002804da488bfefc003340f2a13c9ab7e18f556c13";

            Assert.AreEqual(expectedHash, result);
        }

        [TestMethod]
        public void TestRandom2()
        {
            SHA256Hashing hash = new SHA256Hashing();

            string result = hash.Hash("username");

            // hashuit folosind un site de pe net https://emn178.github.io/online-tools/sha256.html
            string expectedHash = "16f78a7d6317f102bbd95fc9a4f3ff2e3249287690b8bdad6b7810f82b34ace3";

            Assert.AreEqual(expectedHash, result);
        }

        [TestMethod]
        public void TestRandom3()
        {
            SHA256Hashing hash = new SHA256Hashing();

            string result = hash.Hash("alabala");

            // hashuit folosind un site de pe net https://emn178.github.io/online-tools/sha256.html
            string expectedHash = "9d265439f5018db526723d392967ac927626b605f60cf034509d6cf562fd0778";

            Assert.AreEqual(expectedHash, result);
        }


        [TestMethod]
        public void TestRandom4()
        {
            SHA256Hashing hash = new SHA256Hashing();

            string result = hash.Hash("parolaaaamea");

            // hashuit folosind un site de pe net https://emn178.github.io/online-tools/sha256.html
            string expectedHash = "db1526662b78ffab90cdb716ac757f12b5c5f6d1541d12e205a6027e75f98005";

            Assert.AreEqual(expectedHash, result);
        }

        [TestMethod]
        public void TestRandom5()
        {
            SHA256Hashing hash = new SHA256Hashing();

            string result = hash.Hash("123456");

            // hashuit folosind un site de pe net https://emn178.github.io/online-tools/sha256.html
            string expectedHash = "8ae3d49d125e001c396b240913acf7af4adac02553a29bf58efa0925f60db86d";

            Assert.AreEqual(expectedHash, result);
        }


        [TestMethod]
        public void TestRandom6()
        {
            SHA256Hashing hash = new SHA256Hashing();

            string result = hash.Hash("afkejnkjen");

            // hashuit folosind un site de pe net https://emn178.github.io/online-tools/sha256.html
            string expectedHash = "30c4d3f8cd3af8457e627a7567d3ceed98b70f578bac54820df3a4fd4dc6db40";

            Assert.AreEqual(expectedHash, result);
        }
    }
}
