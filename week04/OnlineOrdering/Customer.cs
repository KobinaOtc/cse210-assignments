/*
-------------------------------------
|             Customer              |
-------------------------------------
| - _name: string                   |
| - _address: Address               |
-------------------------------------
| + Customer(name: string, address: Address) |
| + GetName(): string               |
| + IsInCountry(): bool                 |
-------------------------------------
*/
class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetName()
    {
        return _name;
    }

    public bool IsInCountry()
    {
        return _address.InCountry();
    }
}