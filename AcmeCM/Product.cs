using System.Runtime.InteropServices;
using AcmeCommon;

namespace AcmeCM;

public class Product : EntityBase, ILoggable
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
    public string _productName;

    public string ProductName
    {
        get
        {
            return _productName.InsertSpaces();
        }
        set
        {
            _productName = value;
        }
    }

    public List<Product> Retrieve()
    {
        return new List<Product>();
    }

    public string Log() => $"{ProductId}: {ProductName} Email: {ProductDescription} Status: {EntityState.ToString()}";
    
    public override string ToString() => ProductName;

    public override bool Validate()
    {
        var isValid = true;
        
        if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
        if (CurrentPrice == null) isValid = false;

        return isValid;
    }
}