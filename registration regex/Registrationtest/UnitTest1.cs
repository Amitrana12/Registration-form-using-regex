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
        [TestMethod]
        public void Given_MobileNumber_WhenValidate_ShouldReturn_True()
        {
            string MobileNumber = "91 8978325434";
            //Act
            bool result = person.ValidateMobile(MobileNumber);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Given_Password_WhenValidate_ShouldReturn_True()
        {
            //Arrange
            //All paswoord test case 5/6/7/8 done in single method
            string Password = "Sumitrana@12";
            //Act
            bool result = person.ValidatePassword(Password);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        [DataRow("ami@ygmail.com")]
        [DataRow("ami-100@yahoo.com")]
        [DataRow("ami.100@abcd.com")]
        [DataRow("amit111@amit.com")]
        [DataRow("ami-100@gmail.net")]
        [DataRow("amit.100@abc.com.au")]
        [DataRow("aamit@1.com")]
        [DataRow("amitc@gmail.com.co")]
        [DataRow("amit+100@gmail.com")]
        public void ValidateEmailId_Should_return_true(string email)
        {
            Assert.IsTrue(person.ValidateEmail(email));
        }
    }
}

