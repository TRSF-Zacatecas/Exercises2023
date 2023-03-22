public class Property 
{

    public String SellOrRent {get;set;}
    public Address Address {get;set;}
    public int Rooms {get;set;}
    public int Floors {get;set;}

    public bool HasElectricity {get;set;} 
    public bool HasPotableWater {get;set;}

    public bool HasInternet {get;set;}

    public decimal Price {get;set;}

    public DateTime Published {get;set;}
    public bool IsAvailable {get;set;}
    
    public string MinimalTime {get;set;}

    public bool RequiresDeposit {get;set;}
    public string DepositDetail {get;set;}

    public bool IncludeFurniture {get;set;}

    public string PhoneContact {get;set;}
    public string MailContact {get;set;}
    public string Publisher {get;set;}

    public string M2 {get;set;}

    public PropertyType PropertyType {get;set;}

}