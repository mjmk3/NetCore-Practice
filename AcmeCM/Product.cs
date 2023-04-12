using System.Runtime.InteropServices;

namespace AcmeCM;

public class Product : EntityBase
{
    public Product()
    {
    }

    public Product(int productId)
    {
        ProductId = productId;
    }

    public int ProductId { get; private set; }
    public decimal? CurrentPrice { get; set; }
    public string ProductDescription { get; set; }
    public string ProductName { get; set; }

    public List<Product> Retrieve()
    {
        return new List<Product>();
    }

    public override string ToString() => ProductName;

    public override bool Validate()
    {
        var isValid = true;
        
        if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
        if (CurrentPrice == null) isValid = false;

        return isValid;
    }
}