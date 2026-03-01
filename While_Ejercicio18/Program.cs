Console.WriteLine("Calcular el factorial de un número ingresado.");
Console.WriteLine("Ingrese número");
int numero = int.Parse(Console.ReadLine());
int i = 1;
int factorial = 1;
while (i <= numero)
{
    factorial *= i;
    i++;
}
Console.WriteLine("Factorial"+ factorial);