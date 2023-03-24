

Console.WriteLine("Escribe un nombre");

var cadenaORiginal = Console.ReadLine();


var resultadoN = EncontrarN (cadenaORiginal);

if(resultadoN <=0)
  Console.WriteLine("No se encontro una n en esta cadena");
else
    Console.WriteLine("Hay una n en la posicion {0}", resultadoN);



int EncontrarN (string cadena)
{
    return cadena.IndexOf("n");
}


