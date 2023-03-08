// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("Segunda Linea Sin Salto");


for(int i = 0; i<=10; i++)
{
    Console.WriteLine(i);
}


int numeroPersonas = 11;

string NombrePersona = "Jose Eduardo";

Console.WriteLine( "En este room hay {0} personas y una se llama {1}", numeroPersonas, NombrePersona);

int maxPErsonas = 100;
if(numeroPersonas > maxPErsonas)
{
    Console.WriteLine("Se ha sobrepasado el maximo de personas");
}
else 
{
    Console.WriteLine("No se ha llenado el espacio de personas");
}


if(NombrePersona == "Juan")
    Console.WriteLine("El es juan");
else 
    Console.WriteLine("el no es juan");

bool EsViernes = true;

if(EsViernes)
    Console.WriteLine("hay salida");
    
