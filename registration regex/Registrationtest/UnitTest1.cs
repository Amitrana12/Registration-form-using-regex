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
        [TestMethod]
        public void GivenUser_LastName_WhenValidate_ShouldReturn_True()
        {
            string LastName = "Rana";
            //Act
            bool result = person.ValidateFirstName(LastName);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Given_EmailId_WhenValidate_ShouldReturn_True()
        {
            string Email = "amirana14325@gmail.com";
            //Act
            bool result = person.ValidateEmail(Email);
            //Assert
            Assert.IsTrue(result);
        }
    }
}
