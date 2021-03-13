using Microsoft.VisualStudio.TestTools.UnitTesting;
using registration_regex;
namespace Registrationtest
{
    [TestClass]
    public class UnitTest1
    {
        private RegexValidation person;
        [TestInitialize]
        public void InitClassObject()
        {
            //Arrange
            person = new RegexValidation();
        }
        [TestMethod]
        public void GivenUserFistName_WhenValidate_ShouldReturnTrue()
        {
            string FirstName = "Amit";
            //Act
            bool result = person.ValidateFirstName(FirstName);
            //Assert
            Assert.IsTrue(result);
        }
    }
}
