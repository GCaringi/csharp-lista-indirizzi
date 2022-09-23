using csharp_lista_indirizzi;

string path = "C:/Users/Caringi's/RiderProjects/csharp-lista-indirizzi/addresses.csv";

List<Address> addresses = new List<Address>();
StreamReader? file = null;

try
{
    file = File.OpenText(path);
    file.ReadLine();

    while (!file.EndOfStream)
    {
        string addressLine = file.ReadLine();
        string[] dataLine = addressLine.Split(',');

        if (dataLine.Length != 6 || dataLine.Contains(""))
        {
            continue;
        }

        string name = dataLine[0];
        string surname = dataLine[1];
        string street = dataLine[2];
        string city = dataLine[3];
        string province = dataLine[4];
        string zipCode = dataLine[5];

        addresses.Add(new Address(name, surname, street, city, province, zipCode));
    }
}
catch (FileNotFoundException e)
{
    Console.WriteLine("File Non trovato");
}
finally
{
    if (file != null)
    {
        Console.WriteLine("Chiusura File...");
        foreach (Address address in addresses){
            Console.WriteLine(address.ToString());
        }

    }
}

