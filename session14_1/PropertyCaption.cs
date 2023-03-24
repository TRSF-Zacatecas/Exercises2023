public class PropertyCaption 
{
    public static List<Property> properties = new List<Property>();
    public static void GenerateDummyData()
    {

        for (int i = 0; i < 10; i++)
        {
            Property property = new Property() {
                SellOrRent = i % 2 == 0 ? "Sell" : "Rent",
                Address = new Address() {
                    Street = $"{i + 1} Main St",
                    City = "Anytown",
                    State = "CA",
                    ZipCode = "12345"
                },
                Rooms = i % 3 + 1,
                Floors = i % 2 == 0 ? 1 : 2,
                HasElectricity = true,
                HasPotableWater = true,
                HasInternet = true,
                Price = 50000 * (i + 1),
                Published = DateTime.UtcNow.AddDays(-i),
                IsAvailable = i % 2 == 0,
                MinimalTime = $"{i + 1} year{(i + 1 > 1 ? "s" : "")}",
                RequiresDeposit = i % 2 == 0,
                DepositDetail = i % 2 == 0 ? "First and last month's rent" : "One month's rent",
                IncludeFurniture = i % 2 == 0,
                PhoneContact = $"555-12{i + 10}",
                MailContact = $"johndoe{i + 1}@example.com",
                Publisher = "ABC Real Estate",
                M2 = $"{(i + 1) * 50}",
                PropertyType = i % 2 == 0 ? PropertyType.House : PropertyType.Apartment
            };

            properties.Add(property);
        }

        foreach(var item in properties)        
            PropertyCaption.ShowData(item);

        Console.WriteLine($"Se encontraron {properties.Count} propiedades");
        properties.RemoveAt(3);
        Console.WriteLine($"Se encontraron {properties.Count} propiedades");
  
    }

    public static void ShowData(Property property)
    {
         Console.WriteLine("Property Details:");
        Console.WriteLine("-------------------");
        Console.WriteLine("Sell or Rent: {0}", property.SellOrRent);
        Console.WriteLine("Address: {0}, {1}, {2} {3}", property.Address.Street, property.Address.City, property.Address.State, property.Address.ZipCode);
        Console.WriteLine("Rooms: {0}", property.Rooms);
        Console.WriteLine("Floors: {0}", property.Floors);
        Console.WriteLine("Has Electricity: {0}", property.HasElectricity);
        Console.WriteLine("Has Potable Water: {0}", property.HasPotableWater);
        Console.WriteLine("Has Internet: {0}", property.HasInternet);
        Console.WriteLine("Price: {0:C}", property.Price);
        Console.WriteLine("Published: {0}", property.Published.ToString("MM/dd/yyyy"));
        Console.WriteLine("Is Available: {0}", property.IsAvailable);
        Console.WriteLine("Minimal Time: {0}", property.MinimalTime);
        Console.WriteLine("Requires Deposit: {0}", property.RequiresDeposit);
        Console.WriteLine("Deposit Detail: {0}", property.DepositDetail);
        Console.WriteLine("Include Furniture: {0}", property.IncludeFurniture);
        Console.WriteLine("Phone Contact: {0}", property.PhoneContact);
        Console.WriteLine("Mail Contact: {0}", property.MailContact);
        Console.WriteLine("Publisher: {0}", property.Publisher);
        Console.WriteLine("M2: {0}", property.M2);
        Console.WriteLine("Property Type: {0}", property.PropertyType.ToString());

    }
}