int[] array = new int[5];
for (int i = 0; i < 5; i++)
    array[i] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("[" + string.Join(" ", array) + "]");
Console.WriteLine(array[3]); // Выполнили 1 дествие, чтобы узнать какое число под индексом 3 в массиве
// Сложность алгоритма О(1)

// Сгенерировали массив [4, 5, 3, 1, 2]
// O(n)
// [1, 2, 3, 4, 5] -> O(n * log n)
// ((5 + 1)/2) * 5 -> O(1)
// n < n * log(n) + 1
int summa = 0;
for(int i = 0; i < array.Length; i++)
summa += array[i];
Console.WriteLine(summa);