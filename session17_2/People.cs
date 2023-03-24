public class People 
{
    private decimal price = 20;
    public string Name {get;set;}
    public decimal Kg {get;set;}
    public bool IsUsingPaper {get;set;}

    public decimal Total 
    {
        get {return price * Kg;}
    }
}