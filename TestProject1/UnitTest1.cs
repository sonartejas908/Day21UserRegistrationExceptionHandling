using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day21User_RegistrationException;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private readonly Methods method;

        public UnitTest1()
        {
            method = new Methods();
        }

        [TestMethod]
        public void WhenEnteredInvalidFNameShouldReturnException()
        {
            //Arrange
            object obj = method.FirstNameInput();
            //Act
            string expected = "Please enter valid First Name";
            //Assert
            Assert.AreEqual(expected, obj);
        }

        [TestMethod]
        public void WhenEnteredInvalidLNameShouldReturnException()
        {
            object obj = method.LastNameInput();
            string expected = "Please enter valid Last Name";
            Assert.AreEqual(expected, obj);
        }

        [TestMethod]
        public void WhenEnteredWrongEmailShouldReturnException()
        {
            object obj = method.EmailInput();
            string expected = "Please enter valid Email Address";
            Assert.AreEqual(expected, obj);
        }

        [TestMethod]
        public void WhenEnteredWrongMobileShouldReturnException()
        {
            object obj = method.MobileInput();
            string expected = "Please enter valid Mobile Number";
            Assert.AreEqual(expected, obj);
        }

        [TestMethod]
        public void WhenEnteredInvalidPasswordShouldReturnException()
        {
            object obj = method.PasswordInput();
            string expected = "Please enter valid Password";
            Assert.AreEqual(expected, obj);
        }
    }
}
