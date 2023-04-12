using AcmeCM;
using AcmeCommon;

namespace Acme.CommonTest;

public class LoggingServiceTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void WriteToFileTest()
    {
        // Arrange
        var changedItems = new List<ILoggable>();
        var customer = new Customer(1)
        {
            EmailAddress = "fbaggins@hobbiton.me",
            FirstName = "Frodo",
            LastName = "Baggins",
            AddressList = null
        };
        changedItems.Add(customer);

        var product = new Product(2)
        {
            ProductName = "Rake",
            ProductDescription = "Garden Rake with Steel Head",
            CurrentPrice = 6M
        };
        changedItems.Add(product);

        // Act
        LoggingService.WriteToFile(changedItems);

        // Assert
        // Nothing to Assert in this one
    }
}