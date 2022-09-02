Console.WriteLine("Введите размерность матрицы");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(100) - 10;
        Console.Write(matrix[i,j]+" ");
    }
Console.WriteLine();
}
int temp = 0;
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n-1; j++)
    {
        for (int k = 0; k < n-j-1; k++)
        {
            if (matrix[i, k] < matrix[i, k+1])
            {
            temp = matrix[i, k]; matrix[i, k] = matrix[i, k+1]; matrix[i, k+1] = temp;
            }
        }
    }

}
Console.WriteLine();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(matrix[i,j]+" ");
    }
Console.WriteLine();
}