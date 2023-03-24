public class Student : Person
{
    public string grade {get;set;}

    public void  SetCountry (string country)
    {
        this.Country = country;
    }

    public void ShowMeCountry ()
    {
        Console.WriteLine(this.Country);
    }
}