using System.Diagnostics;

namespace AcmeCM.Test;

public class ProductRepositoryTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void RetrieveValid()
    {
        //Arrange
        var productRepository = new ProductRepository();
        var expected = new Product(2)
        {
            CurrentPrice = 15.96M,
            ProductDescription = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers",
            ProductName = "Sunflowers",
        };
        
        //Act
        var actual = productRepository.Retrieve(2);

        //Assert
        Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
        Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
        Assert.AreEqual(expected.ProductName, actual.ProductName);
    }
}