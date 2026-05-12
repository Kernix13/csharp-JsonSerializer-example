namespace JsonOOP;

public class Address 
{
    public string Street { get; set; }
    public string StreetNumber { get; set; }
    public string Unit { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }

    // Constructor
    public Address(string street, string streetNumber, string unit, string city, string state, string zipCode)
    {
        Street = street;
        StreetNumber = streetNumber;
        Unit = unit;
        City = city;
        State = state;
        ZipCode = zipCode;
    }

    public string FormatAddress()
    {
        return $"{StreetNumber} {Street} {Unit}\n{City}, {State} {ZipCode}";
    }
}