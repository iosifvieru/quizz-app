using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using proiect_ip;

/*
    Unit tests pentru testarea functionalitatii clasei UserController. 

    Unit testul are o baza de date propriu-zisa ce poate fi gasita in 
    \Tests\UnitTestUserController\bin\Debug ce n-are treaba cu baza de date "mare" din proiect.

*/

namespace UnitTestUserController
{
    [TestClass]
    public class UnitTestUserController
    {
        private IUserController _userController = new UserController();

        [TestMethod]
        public void TestAddAndGetUser()
        {
            User tempUser = new User(0, "test", "test");
            _userController.addUser(tempUser);

            User user = _userController.getUser("test");
            Assert.IsNotNull(user);
        }

        [TestMethod]
        public void TestDelete()
        {
            User user = new User(0, "de_sters", "de_sters");
            _userController.addUser(user);

            user = _userController.getUser("de_sters");
            _userController.deleteUser(user.ID);

            // ar trb sa fie null
            User usr = _userController.getUser("de_sters");

            Assert.IsNull(usr);
        }

        [TestMethod]
        public void TestUpdateANonExistingUser()
        {
            bool hasUpdated = _userController.updateUser(-1, new User(-1, "test", "test"));

            Assert.IsFalse(hasUpdated);
        }

        [TestMethod]
        public void TestUpdateAExistingUser()
        {
            bool hasUpdated = _userController.updateUser(1, new User(1, "update", "update"));

            Assert.IsTrue(hasUpdated);
        }
    } 
}
