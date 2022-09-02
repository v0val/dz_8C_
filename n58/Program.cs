Console.WriteLine("Введите размерность матрицы");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int t = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите матрицы");
int [,] matrix1 = new int [m, n];
int [,] matrix2 = new int [n, t];
int [,] matrixResult = new int [m, t];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix1[i, j] = Convert.ToInt32(Console.ReadLine());//new Random().Next(100) - 100;
    }
}
Console.WriteLine();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < t; j++)
    {
        matrix2[i, j] = Convert.ToInt32(Console.ReadLine());//new Random().Next(100) - 100;
    }
}
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < t; j++)
    {
        matrixResult[i,j] = 0;
        for (int k = 0; k < n; k++) matrixResult[i,j] += matrix1[i, k]*matrix2[k, j];
    }
}
Console.WriteLine();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(matrix1[i, j]+" ");
    }
    Console.WriteLine();
}
Console.WriteLine("X        ");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < t; j++)
    {
        Console.Write(matrix2[i, j]+" ");
    }
    Console.WriteLine();
}
Console.WriteLine("||           ");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < t; j++)
    {
        Console.Write(matrixResult[i, j]+" ");
    }
    Console.WriteLine();
}
