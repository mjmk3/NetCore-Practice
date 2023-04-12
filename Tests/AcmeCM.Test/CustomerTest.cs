namespace AcmeCM.Test;

public class CustomerTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void FullNameTestValid()
    {
        //Arrange
        Customer customer = new Customer()
        {
            FirstName = "Bilbo",
            LastName = "Baggins"
        };
        string expected = "Baggins, Bilbo";
        
        //Act
        string actual = customer.FullName;
        
        //Assert
        Assert.AreEqual(expected, actual);
    }
    
    [Test]
    public void FullNameFirstNameEmpty()
    {
        //Arrange
        Customer customer = new Customer()
        {
            LastName = "Baggins"
        };
        string expected = "Baggins";
        
        //Act
        string actual = customer.FullName;
        
        //Assert
        Assert.AreEqual(expected, actual);
    }
    
    [Test]
    public void FullNameLastNameEmpty()
    {
        //Arrange
        Customer customer = new Customer()
        {
            FirstName = "Bilbo"
        };
        string expected = "Bilbo";
        
        //Act
        string actual = customer.FullName;
        
        //Assert
        Assert.AreEqual(expected, actual);
    }
    
    [Test]
    public void StaticTest()
    {
        //Arrange
        var c1 = new Customer();
        c1.FirstName = "Bilbo";
        Customer.InstanceCount += 1;
        
        var c2 = new Customer();
        c2.FirstName = "Frodo";
        Customer.InstanceCount += 1;
        
        var c3 = new Customer();
        c3.FirstName = "Rosie";
        Customer.InstanceCount += 1;

        //Act

        //Assert
        Assert.AreEqual(3, Customer.InstanceCount);
    }
    
    [Test]
    public void ValidateValid()
    {
        //Arrange
        var customer = new Customer()
        {
            LastName = "Baggins",
            EmailAddress = "fbaggins@hobbiton.me"
        };
        
        var expected = true;

        //Act
        var actual = customer.Validate();
        
        //Assert
        Assert.AreEqual(expected, actual);
    }
    
    [Test]
    public void ValidateMissingLastName()
    {
        //Arrange
        var customer = new Customer()
        {
            EmailAddress = "fbaggins@hobbiton.me"
        };
        
        var expected = true;

        //Act
        var actual = customer.Validate();
        
        //Assert
        Assert.AreEqual(expected, actual);
    }
}