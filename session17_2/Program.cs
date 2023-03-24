// See https://aka.ms/new-console-template for more information


Queue<string> queue = new Queue<string>();
queue.Enqueue("Jose");
queue.Enqueue("Alejandro");
queue.Enqueue("Cinthia");
queue.Enqueue("Eduardo");

while(  queue.TryDequeue(out string item))
{ 
    if(item != null) 
        Console.WriteLine(item);
}


Queue<People> ColaTortillas = new Queue<People>();

ColaTortillas.Enqueue(new People(){ Name="Alejandro", Kg= 10, IsUsingPaper = true });

ColaTortillas.Enqueue(new People(){ Name="Xioamara", Kg= 2, IsUsingPaper = true });

ColaTortillas.Enqueue(new People(){ Name="Cesar", Kg= 5, IsUsingPaper = true });


while(ColaTortillas.TryDequeue(out People item))
{ 
    Console.WriteLine($"Se despacho a {item.Name} con {item.Kg} y debe {item.Total} ");
}