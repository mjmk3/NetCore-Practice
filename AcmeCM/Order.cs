using System.Collections.Generic;

namespace AcmeCM;

public class Order
{
    public Order() : this (0)
    {
    }

    public Order(int orderId)
    {
        OrderId = orderId;
        OrderItems = new List<OrderItem>();
    }

    public int OrderId { get; private set; }
    public int CustomerId { get; set; }
    public int ShippingAddressId { get; set; }
    public List<OrderItem> OrderItems { get; set; }
    public DateTimeOffset? OrderDate { get; set; }

    public List<Order> Retrieve()
    {
        return new List<Order>();
    }

    public override string ToString() => $"{OrderDate.Value.Date} ({OrderId})";

    public bool Validate()
    {
        var isValid = true;

        if (OrderDate == null) isValid = false;
        
        return isValid;
    }
}