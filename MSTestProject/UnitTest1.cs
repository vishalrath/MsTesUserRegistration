using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobileNumberUserRegistration;

namespace MSTestProject
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
            string actual = testing.validFirstName(MailId);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestMobileNo()
        {
            //AAA Methodology

            //Arrange
            string Mobile = "91 8007078569";
            string expected = "Valid";

            //Act
            RegularExp testing = new RegularExp();
            string actual = testing.MobileNo(Mobile);

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
