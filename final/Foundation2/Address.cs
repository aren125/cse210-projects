using System;

public class Address
{
    private string _street;
    private string _city;
    private string _stateOrProvidence;
    private string _country;

    public Address(string street, string city, string stateOrProvidence, string country)
    {
        _street = street;
        _city = city;
        _stateOrProvidence = stateOrProvidence;
        _country = country;
    }

    public bool IsInUSA()
    {
        return _country == "USA" || _country == "United States";
    }

    public string GetAddress()
    {
        return $"{_street}\n{_city}, {_stateOrProvidence}\n{_country}";
    }
}