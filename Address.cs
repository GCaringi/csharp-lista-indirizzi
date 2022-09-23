namespace csharp_lista_indirizzi;

public class Address
{
    public string? Name { get; }
    public string? Surname { get; }
    public string? Street { get; }
    public string? City { get; }
    public string? Province { get; }
    public string? ZIPCode { get; }
    
    public Address(string name, string surname, string street, string city, string province, string zipCode)
    {
        Name = name;
        Surname = surname;
        Street = street;
        City = city;
        Province = province;
        ZIPCode = zipCode;
    }

    public override string ToString()
    {
        return $"{Name} {Surname} - {Street},{City},{Province} {ZIPCode}";
    }
}