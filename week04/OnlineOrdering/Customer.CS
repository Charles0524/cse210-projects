using System;
using System.Globalization;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = CapitalizeWords(name);
        _address = address;
    }

    // Private helper method to capitalize the first letter of every word in the name
    private string CapitalizeWords(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return string.Empty;
        }

        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        return textInfo.ToTitleCase(input.Trim().ToLower());
    }

    public string GetName()
    {
        return _name;
    }

    public Address GetAddress()
    {
        return _address;
    }

    // Delegates the USA residency check directly to the Address class
    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }
}
