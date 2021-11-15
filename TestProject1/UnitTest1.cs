using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordUserRegistration;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFirstName()
        {
            //AAA Methodology

            //Arrange
            string message = "Ram";
            string expected = "Valid";

            //Act
            RegularExp testing = new RegularExp();
            string actual = testing.validFirstName(message);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestLastName()
        {
            //AAA Methodology

            //Arrange
            string LName = "Rat";
            string expected = "Valid";

            //Act
            RegularExp testing = new RegularExp();
            string actual = testing.validFirstName(LName);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestMail()
        {
            //AAA Methodology

            //Arrange
            string MailId = "abc.xyz@bl.co.in";
            string expected = "Valid";

            //Act
            RegularExp testing = new RegularExp();
            string actual = testing.MailValidation(MailId);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestMobileNo()
        {
            //AAA Methodology

            //Arrange
            string Mobile = "91 7038762577";
            string expected = "Valid";

            //Act
            RegularExp testing = new RegularExp();
            string actual = testing.MobileNo(Mobile);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestPassword()
        {
            //AAA Methodology

            //Arrange
            string message = "rathodab";
            string expected = "Valid";

            //Act
            RegularExp testing = new RegularExp();
            string actual = testing.Validpassword1(message);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestPassword2()
        {
            //AAA Methodology

            //Arrange
            string message = "Vishalhi";
            string expected = "Valid";

            //Act
            RegularExp testing = new RegularExp();
            string actual = testing.Validpassword2(message);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestPassword3()
        {
            //AAA Methodology

            //Arrange
            string message = "Vishalh1";
            string expected = "Valid";

            //Act
            RegularExp testing = new RegularExp();
            string actual = testing.Validpassword3(message);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestPassword4()
        {
            //AAA Methodology

            //Arrange
            string message = "Vish@lh1";
            string expected = "Valid";

            //Act
            RegularExp testing = new RegularExp();
            string actual = testing.Validpassword4(message);

            //Assert
            Assert.AreEqual(expected, actual);

        }

    }
}
