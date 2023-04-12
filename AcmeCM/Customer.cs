﻿namespace AcmeCM;

public class Customer
{
    public Customer() : this(0)
    {
    }

    public Customer(int customerId)
    {
        CustomerId = customerId;
        AddressList = new List<Address>();
    }

    public int CustomerId { get; private set; }
    public int CustomerType { get; set; }
    public string EmailAddress { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string FullName
    {
        get
        {
            string fullName = LastName;
            if (!string.IsNullOrWhiteSpace(FirstName))
            {
                if (!string.IsNullOrWhiteSpace(LastName))
                {
                    fullName += ", ";
                }

                fullName += FirstName;
            }

            return fullName;
        }
    }

    public static int InstanceCount { get; set; }
    public List<Address> AddressList { get; set; }

    public List<Customer> Retrieve()
    {
        return new List<Customer>();
    }

    public override string ToString() => FullName;

    public bool Validate()
    {
        var isValid = true;

        if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
        if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

        return isValid;
    }
}