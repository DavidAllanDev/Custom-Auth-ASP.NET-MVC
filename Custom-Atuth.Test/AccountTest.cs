using System;
using Custom_Auth.Domain.Model;
using Custom_Auth.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Custom_Atuth.Test
{
    [TestClass]
    public class AccountTest
    {
        [TestMethod]
        public void CanAccountBeFoundByUserNameTest()
        {
            //Arrange
            Account account = new Account() { UserName = "User", Password = "jjj" };

            //Act
            bool found = Accounts.FindByUserName(account.UserName) != null;

            //Assert
            Assert.IsTrue(found);
        }


        [TestMethod]
        public void CanAccountBeAuthenticableTest()
        {
            //Arrange
            Account account = new Account() { UserName = "User", Password = "xXx" };

            //Act
            bool authenticable = Accounts.IsAuthenticable(account.UserName, account.Password);

            //Assert
            Assert.IsTrue(authenticable);
        }
    }
}
