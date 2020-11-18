using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using HWUT.Models;

namespace UnitTests
{
    [TestClass]
    public class ProductModelTests
    {
        [TestMethod]
        public void ProductModel_Valid_Constructor_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ProductModel_Valid_Get_Date_Default_Should_Return_Date()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(DateTime.UtcNow.ToShortDateString(), result.Date.ToShortDateString());
        }

        [TestMethod]
        public void ProductModel_Valid_GetDescription_TestDescription_Should_Return_String()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Description = "Test description";

            // Assert
            Assert.AreEqual("Test description", result.Description);

        }

        [TestMethod]
        public void ProductModel_Valid_GetEmail_TestEmail_Should_Return_String()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Email = "stchamba@seattleu.edu";

            // Assert
            Assert.AreEqual("stchamba@seattleu.edu", result.Email);

        }

        [TestMethod]
        public void ProductModel_Valid_GetId_TestId_Should_Return_String()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Id = "123456789";

            // Assert
            Assert.AreEqual("123456789", result.Id);

        }

        [TestMethod]
        public void ProductModel_Valid_GetImage_TestImage_Should_Return_String()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Image = "image.png";

            // Assert
            Assert.AreEqual("image.png", result.Image);

        }

        [TestMethod]
        public void ProductModel_Valid_GetLogistics_TestLogistics_Should_Return_String()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Logistics = "Logistics";

            // Assert
            Assert.AreEqual("Logistics", result.Logistics);

        }

        [TestMethod]
        public void ProductModel_Valid_GetMaker_TestMaker_Should_Return_String()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Maker = "Test Maker";

            // Assert
            Assert.AreEqual("Test Maker", result.Maker);

        }

        [TestMethod]
        public void ProductModel_Valid_GetTitle_TestTitle_Should_Return_String()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Title = "Test Title";

            // Assert
            Assert.AreEqual("Test Title", result.Title);

        }

        [TestMethod]
        public void ProductModel_Valid_GetSequence_TestSequence_Should_Return_String()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Sequence = "Test Sequence";

            // Assert
            Assert.AreEqual("Test Sequence", result.Sequence);

        }


        [TestMethod]
        public void ProductModel_Valid_GetUrl_TestUrl_Should_Return_String()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Url = "seattleu.edu";

            // Assert
            Assert.AreEqual("seattleu.edu", result.Url);

        }


        [TestMethod]
        public void ProductModel_Valid_GetRatings_TestRatings_Should_Return_Boolean()
        {
            int[] testArray = { 1, 2, 3, 4 };
            // Arrange
            var result = new ProductModel();

            // Act
            result.Ratings = testArray;

            // Assert
            bool valid = true;
            for (int i = 0; i < testArray.Length; i++)
            {
                valid = true && testArray[i] == result.Ratings[i];
            }
            Assert.IsTrue(valid);

        }

        [TestMethod]
        public void ProductModel_Valid_AverageRating_TestAverageRating_Should_Return_Int()
        {
            int[] testArray = { 1, 2, 3, 2 };
            // Arrange
            var result = new ProductModel();

            // Act
            result.Ratings = testArray;

            // Assert
            Assert.AreEqual(2, result.AverageRating());

        }

        [TestMethod]
        public void ProductModel_Valid_AverageRating_TestAverageRating_Should_Return_Zero_case_one()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Ratings = null;

            // Assert
            Assert.AreEqual(0, result.AverageRating());

        }

        [TestMethod]
        public void ProductModel_Valid_AverageRating_TestAverageRating_Should_Return_Zero_case_two()
        {
            int[] testArray = { };
            // Arrange
            var result = new ProductModel();

            // Act
            result.Ratings = testArray;

            // Assert
            Assert.AreEqual(0, result.AverageRating());

        }

        [TestMethod]
        public void ProductModel_Valid_AverageRating_TestAverageRating_Should_Return_Zero_case_three()
        {
            int[] testArray = { -5, 5 };
            // Arrange
            var result = new ProductModel();

            // Act
            result.Ratings = testArray;

            // Assert
            Assert.AreEqual(0, result.AverageRating());

        }

        [TestMethod]
        public void ProductModel_Valid_ToString_TestToString_Should_Return_String()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Id = "123456";
            result.Title = "string";
            result.Description = "desc";

            String print = result.ToString();

            Boolean valid = print.Contains("123456") && print.Contains("string") && print.Contains("desc");

            // Assert
            Assert.IsTrue(valid);

        }

    }
}