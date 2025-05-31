/*
-------------------------------------
|              Order                |
-------------------------------------
| - _products: List<Product>        |
| - _customer: Customer             |
-------------------------------------
| + Order(customer: Customer)       |
| + AddProduct(product: Product): void |
| + GetTotalCostOfProducts(): double|
| + GetShippingCost(): double       |
| + GetOverallTotalCost(): double   |
| + GetOrderSummary(): void         |
-------------------------------------
*/
class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    // Constructor
    public Order(Customer customer)
    {
        _customer = customer;
    }

    // Methods
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public double GetTotalCostOfProducts()
    {
        double total = 0.00;
        foreach (Product prod in _products)
        {
            total += prod.GetCost();
        }
        return total;
    }
    public double GetShippingCost()
    {
        double shippingCost = 0;
        if (_customer.IsInCountry())
        {
            shippingCost = 8;
        }
        else
        {
            shippingCost = 23;
        }
        return shippingCost;
    }
    public double GetOverallTotalCost()
    {
        return GetTotalCostOfProducts() + GetShippingCost();
    }
    public void GetOrderSummary()
    {
        Console.WriteLine();
        Console.WriteLine($"Customer: {_customer.GetName()}");
        foreach (Product prod in _products)
        {
            Console.WriteLine($"{prod.GetName()}: {prod.GetCost()}");
        }
        Console.WriteLine();
        Console.WriteLine($"Subtotal: {GetTotalCostOfProducts()}");
        Console.WriteLine($"Total: {GetOverallTotalCost()}");

    }
}