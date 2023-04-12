namespace AcmeCM;

public class AddressRepository
{
    public Address Retrieve(int addressId)
    {
        Address address = new Address(addressId);

        if (addressId == 1)
        {
            address.AddressType = 1;
            address.PostalCode = "144";
            address.AddressLine2 = "Bagshot row";
            address.AddressLine1 = "Bag End";
            address.City = "Hobbiton";
            address.State = "Shire";
            address.Country = "Middle Earth";
        }
        
        return address;
    }

    public IEnumerable<Address> RetrieveByCustomerId(int customerId)
    {
        var addressList = new List<Address>();

        Address address = new Address(1)
        {
            AddressType = 1,
            PostalCode = "144",
            AddressLine2 = "Bagshot row",
            AddressLine1 = "Bag End",
            City = "Hobbiton",
            State = "Shire",
            Country = "Middle Earth"
        };
        addressList.Add(address);
        
        address = new Address(2)
        {
            AddressType = 2,
            PostalCode = "146",
            AddressLine1 = "Green Dragon",
            City = "Bywater",
            State = "Shire",
            Country = "Middle Earth"
        };
        addressList.Add(address);

        return addressList;
    }

    public bool Save(Address address)
    {
        return true;
    }
}