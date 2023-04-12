namespace AcmeCM;

public class ProductRepository
{
    public Product Retrieve(int productId)
    {
        Product product = new Product(productId);

        if (productId == 2)
        {
            product.ProductName = "Sunflowers";
            product.ProductDescription = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers";
            product.CurrentPrice = 15.96M;
        }

        Object myObject = new Object();
        Console.WriteLine($"Object: {myObject.ToString()}");
        Console.WriteLine($"Product: {product.ToString()}");
        return product;
    }
    
    public bool Save(Product product)
    {
        var success = true;

        if (product.HasChanges)
        {
            if (product.IsValid)
            {
                if (product.IsNew)
                {
                    
                }
                else
                {
                    
                }
            }
            else
            {
                success = false;
            }
        }
        
        return success;
    }
}