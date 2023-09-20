Console.Write("Ingrese el número de notas: ");
int cantidad = int.Parse(Console.ReadLine());
float promedio = 0f;

for (int i = 1; i <= cantidad; i++)
{
    Console.Write("Ingrese la nota " + i + ": ");
    int nota = int.Parse(Console.ReadLine());
    promedio += nota;
}
promedio /= cantidad;
Console.Write("El promedio es " + promedio);