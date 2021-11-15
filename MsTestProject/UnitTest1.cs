using Microsoft.VisualStudio.TestTools.UnitTesting;
using Password1UserRegistration;

namespace MsTestProject
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
            string actual = testing.Validpassword(message);

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
