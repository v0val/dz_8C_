Console.WriteLine("Введите размерность квадратной матрицы");
int m = Convert.ToInt32(Console.ReadLine());
double [,] matrix = new double [m, m];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < m; j++)
    {
        matrix[i, j] = new Random().NextDouble()*10 - 10;
        Console.Write(matrix[i,j]+" ");
    }
Console.WriteLine();
}
double summa = 0;
for (int j = 0; j < m; j++)
{
    summa += matrix[0,j];
}
double minim = summa; int numberString = 0;
for (int i = 1; i < m; i++)
{
    summa = 0;
    for (int j = 0; j < m; j++)
    {
        summa += matrix[i,j];
    }
    if (summa < minim)
    {
        minim = summa;
        numberString = i;
    }
}
Console.Write($"   строка с минимальной суммой элементов = {numberString}, минимальная сумма = {minim}  ");