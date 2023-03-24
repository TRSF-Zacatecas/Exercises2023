public class Person 
{
    private string lastName ;

    public string LastName 
    {
        get 
        {
            return lastName;
        }
        set 
        {
            lastName = value;
        }
    } 

    public string Name {get;set;}

    protected string Country {get;set;}

    internal string City {get;set;}
}