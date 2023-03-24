// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Dictionary <int, string> StudentsList = new Dictionary<int, string>();
StudentsList.Add(1, "Jose Serrano");

StudentsList.Add(2, "Alejandro Molina");

StudentsList.Add(3, "Cinthia Daniela");



StudentsList.TryGetValue(3, out string retrievedStudent);

Console.WriteLine($"El estudiante con el numero 3 es {retrievedStudent}");


Dictionary<int, Animal> AnimalList = new Dictionary<int, Animal>();

AnimalList.Add(1, new Animal(){  Name= "Perro", Location="Land", Fly = false  });
AnimalList.Add(200, new Animal(){  Name= "Camello", Location="Land", Fly = false  });
 
AnimalList.Add(32, new Animal(){  Name= "Paloma", Location="Land", Fly = true  });

AnimalList.Add(4, new Animal(){  Name= "Delfin", Location="Sea", Fly = false  });


AnimalList.TryGetValue(4, out Animal retrievedAnimal);

Console.WriteLine($" {retrievedAnimal.Name}");