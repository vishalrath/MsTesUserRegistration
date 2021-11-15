using LastNameUserRegistration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MsTestUserRegistrationl
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
        RegularExp testing = new RegularExp(message);
        string actual = testing.validFirstName();

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
        RegularExp testing = new RegularExp(LName);
        string actual = testing.validFirstName();

        //Assert
        Assert.AreEqual(expected, actual);

    }
}
}
