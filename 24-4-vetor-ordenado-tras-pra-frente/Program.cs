//vetorordenado(2) não pode mostrar numeros repetidos
int size = 100;
int aux = 0;
int[] vetorOriginal = new int[size];
int[] vetorOrdenado = new int[size];
int[] vetorContrario = new int[size];
for (int i = 0; i < size; i++)
{
    vetorOriginal[i] = new Random().Next(0, 100); //vetorOriginal recebe os numeros aleatorios
    vetorOrdenado[i] = vetorOriginal[i]; // Copia para o vetorOrdenado
}
Console.WriteLine("Números originais: ");
for (int i = 0; i < size; i++)
{
    Console.Write(vetorOriginal[i] + " ");
}
Console.ReadKey();
for (int referencia = 0; referencia < size; referencia++)
{
    for (int comparacao = referencia + 1; comparacao < size; comparacao++)
    {
        if (vetorOrdenado[referencia] > vetorOrdenado[comparacao])
        {
            aux = vetorOrdenado[referencia];
            vetorOrdenado[referencia] = vetorOrdenado[comparacao];
            vetorOrdenado[comparacao] = aux;
        }
    }
}
Console.WriteLine("\n\nNúmeros ordenados sem repetições: ");
Console.Write(vetorOrdenado[0] + " ");
for (int i = 1; i < size; i++)
{
    if (vetorOrdenado[i] != vetorOrdenado[i - 1])
    {
        Console.Write(vetorOrdenado[i] + " ");
    }
}
Console.ReadKey();
for (int i = 0; i < size; i++)
{
    vetorContrario[i] = vetorOrdenado[i];
}
Console.WriteLine("\n\nNúmeros ao contrario: ");
Console.Write(vetorContrario[size - 1] + " ");
for (int i = size - 2; i > 0; i--)
{
    if (vetorContrario[i] != vetorContrario[i + 1])
    {
        Console.Write(vetorContrario[i] + " ");
    }
}
Console.ReadKey();