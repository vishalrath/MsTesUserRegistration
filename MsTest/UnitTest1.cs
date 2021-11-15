using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstNameUserRegistration;

namespace MsTest
{
    [TestClass]
    public class UserRegTest
    {
        [TestMethod]
        public void TestFirstName()
        {
            //AAA Methodology

            //Arrange
            string Name = "Ram";
            string expected = "Valid";

            //Act
            RegularExp testing = new RegularExp(Name);
            string actual = testing.validFirstName();

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}