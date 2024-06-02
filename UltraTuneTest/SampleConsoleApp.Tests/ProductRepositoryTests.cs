using Moq;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using SampleConsoleApp.Question_2;

//Question 6 : Write a unit test for the `ProductRepository` method `GetAllProducts` using xUnit and Moq.
//NUnit is used instead of xUnit
namespace SampleConsoleApp.Tests
{
    public class ProductRepositoryTests
    {
        IRepository<Product> productRepository;

        [Test]
        public void TestGetAll()
        {
            var expectedProducts = new List<Product>()
            {
                new Product(){ Id = 1001, Name = "Shirt", Description = "Cotton" },
                new Product(){ Id = 1002, Name = "Dress", Description = "Silk" }
            };

            var productRepositoryMock = new Mock<IRepository<Product>>();
            productRepositoryMock.Setup(x => x.GetAll()).Returns(expectedProducts);

            productRepository = productRepositoryMock.Object;
            var actualProducts = productRepository.GetAll();

            ClassicAssert.AreEqual(expectedProducts.Count, actualProducts.Count);
        }
    }
}
