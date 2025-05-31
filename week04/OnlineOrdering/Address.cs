/*
-------------------------------------
|              Address              |
-------------------------------------
| - _streetAddress: string          |
| - _city: string                   |
| - _stateProvince: string          |
| - _country: string                |
-------------------------------------
| + Address(street: string, city: string, stateProvince: string, country: string) |
| + IsInCountry(): bool                 |
| + GetFullAddressString(): string  |
-------------------------------------
*/
class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    // Constructor
    public Address(string street, string city, string stateProvince, string country)
    {
        _streetAddress = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }
    public bool InCountry()
    {
        bool inCountry = false;
        if (_country == "Ghana")
        {
            inCountry = true;
        }
        else
        {
            inCountry = false;
        }
        return inCountry;
    }
    public string GetFullAddressString()
    {
        return $"{_streetAddress}, {_city}, {_stateProvince}, {_country}";
    }
}