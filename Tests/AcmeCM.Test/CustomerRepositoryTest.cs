using System.Diagnostics;

namespace AcmeCM.Test;

public class CustomerRepositoryTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void RetrieveValid()
    {
        //Arrange
        var customerRepository = new CustomerRepository();
        var expected = new Customer(1)
        {
            EmailAddress = "fbaggins@hobbiton.me",
            FirstName = "Frodo",
            LastName = "Baggins",
        };
        
        //Act
        var actual = customerRepository.Retrieve(1);

        //Assert
        Assert.AreEqual(expected.CustomerId, actual.CustomerId);
        Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
        Assert.AreEqual(expected.FirstName, actual.FirstName);
        Assert.AreEqual(expected.LastName, actual.LastName);
    }
    
    [Test]
    public void RetrieveExistingWithAddress()
    {
        //Arrange
        var customerRepository = new CustomerRepository();
        var expected = new Customer(1)
        {
            EmailAddress = "fbaggins@hobbiton.me",
            FirstName = "Frodo",
            LastName = "Baggins",
            AddressList = new List<Address>()
            {
                new Address()
                {
                    AddressType = 1,
                    PostalCode = "144",
                    AddressLine2 = "Bagshot row",
                    AddressLine1 = "Bag End",
                    City = "Hobbiton",
                    State = "Shire",
                    Country = "Middle Earth"
                },
                new Address()
                {
                    AddressType = 2,
                    PostalCode = "146",
                    AddressLine1 = "Green Dragon",
                    City = "Bywater",
                    State = "Shire",
                    Country = "Middle Earth"
                }
            }
        };
        
        //Act
        var actual = customerRepository.Retrieve(1);

        //Assert
        Assert.AreEqual(expected.CustomerId, actual.CustomerId);
        Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
        Assert.AreEqual(expected.FirstName, actual.FirstName);
        Assert.AreEqual(expected.LastName, actual.LastName);

        for (int i = 0; i < 1; i++)
        {
            Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
            Assert.AreEqual(expected.AddressList[i].AddressLine2, actual.AddressList[i].AddressLine2);
            Assert.AreEqual(expected.AddressList[i].AddressLine1, actual.AddressList[i].AddressLine1);
            Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
            Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
            Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
        }
    }
}