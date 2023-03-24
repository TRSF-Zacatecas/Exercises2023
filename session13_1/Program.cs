 

Person person = new Person()
{
   Name = "Jose Eduardo",
   LastName = "Serrano" ,
   City = "Zapopan"
};

Utils.ShowFullName(person);


Student student = new Student()
{
    Name = "Alejandro",
    LastName = "Molina"
};

Utils.ShowFullName(student);

student.SetCountry("Mexico");

student.ShowMeCountry();