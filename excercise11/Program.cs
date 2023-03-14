var resultado = Suma(6,7);


Print(resultado);

Print(Resta(5,6));



int Suma(int x, int y)
{
    return x + y; 
}


int Resta (int x, int y)
{
    return x - y; 
}

int Multiplica (int x, int y)
{
    return x * y ;
}


void Print (int resultado)
{
    Console.WriteLine("Resultado = {0}", resultado);
}

