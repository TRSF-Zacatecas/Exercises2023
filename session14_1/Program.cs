// See https://aka.ms/new-console-template for more information
Console.WriteLine("");


PropertyCaption.GenerateDummyData();

/*
Property property = new Property();
property.Address = new Address();


Console.WriteLine("Introduce la ubicacion de tu casas");


Console.WriteLine("Introduce la calle de la propiedad");
property.Address.Street = Console.ReadLine();

Console.WriteLine("Introduce el precio de renta / venta");

string stringPrice = Console.ReadLine();

Decimal.TryParse(stringPrice, out decimal finalPrice);

property.Price = finalPrice;

Console.WriteLine("Que tipo de propiedad vendes/ rentas?");

Console.WriteLine(" 0 - Casas / 1- Departamento / 2 - Cuarto / 3 - Terreno");

property.PropertyType = (PropertyType) Int32.Parse(Console.ReadLine());

string stringPropertyType;

switch(property.PropertyType)
{
    case PropertyType.House : 
                    stringPropertyType = "Casa";
                    break;
    case PropertyType.Apartment:
                    stringPropertyType = "Departamento";
                     break;   
    case PropertyType.Room:
                    stringPropertyType = "Cuarto";
                    break;
    case PropertyType.Lot:
                    stringPropertyType = "Terreno";
                    break;
    default:
                stringPropertyType = "Otro";
                break;
    
}

Console.WriteLine ($"Se Renta o vende un {stringPropertyType} ubicada en  {property.Address.Street} en {property.Price}");


*/