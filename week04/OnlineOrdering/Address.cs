using System;
using System.Globalization;

public class Address
{
    private bool _isUsa;
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    // Constructor asks for the USA boolean first and automatically capitalizes address fields
    public Address(bool isUsa, string streetAddress, string city, string stateOrProvince, string country)
    {
        _isUsa = isUsa;
        _streetAddress = CapitalizeWords(streetAddress);
        _city = CapitalizeWords(city);
        _stateOrProvince = CapitalizeWords(stateOrProvince);
        _country = _isUsa ? "USA" : CapitalizeWords(country);
    }

    // Private helper method to capitalize the first letter of every word
    private string CapitalizeWords(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return string.Empty;
        }

        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        return textInfo.ToTitleCase(input.Trim().ToLower());
    }

    public bool IsInUSA()
    {
        return _isUsa;
    }

    public string GetFormattedAddress()
    {
        return $"{_streetAddress}\n{_city}, {_stateOrProvince}\n{_country}";
    }
}