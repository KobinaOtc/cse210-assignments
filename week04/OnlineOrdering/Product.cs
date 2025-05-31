/*
-------------------------------------
|             Product               |
-------------------------------------
| - _name: string                   |
| - _productId: string              |
| - _price: double                  |
-------------------------------------
| + Product(name: string, productId: string, price: double) |
| + GetCost(): double          |
| + GetName(): string               |
| + GetProductId(): string          |
-------------------------------------
*/
class Product
{
    private string _name;
    private string _productId;
    private double _price;

    // Constructor
    public Product(string name, string productId, double price)
    {
        _name = name;
        _productId = productId;
        _price = price;
    }

    // Methods
    public double GetCost()
    {
        return _price;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetProductId()
    {
        return _productId;
    }
}