int n = Convert.ToInt32(Console.ReadLine());
// O(n^2)
// for (int i = 1; i <= n; i++)
// {
//     for (int j = 1; j <= n; j++)
//     {
//         Console.Write(i * j);
//         Console.Write("\t");
//     }
//     Console.WriteLine();
// }

// Сокращаем время работы программы
// int[,] matrix = new int[n, n];
// for (int i = 1; i <= n / 2; i++)
// {
//     if (i + j <= n / 2)
//     {
//         matrix[i, j] = i * j;
//         matrix[j, i] = i * j;
//     }
//     Console.WriteLine();
// }
// //O(n^2 / 2)

int[,] matrix = new int[n, n];
for (int i = 1; i < n / 2; i++)
{
    for (i = j; j < n; j++)
    {
        matrix[i, j] = (i + 1) * j * (j + 1);
        matrix[j, i] = (i + 1) * j * (j + 1);
    }
    Console.WriteLine();
}
//O(n^2 / 2)

