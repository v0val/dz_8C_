Console.WriteLine("Введите размеры трёхмерной матрицы");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int t = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Построчный вывод матрицы: ");
int [,,] matrix = new int [m, n, t];
int dobavka = 1;
for (int i = 0; i < m; i++)
{
    for (int k = 0; k < t; k++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j, k] = 9 + dobavka;
            dobavka += 1;
            Console.Write($"{matrix[i,j,k]} ({i},{j},{k})  ");
        }
        Console.WriteLine();
    
    }
    
}