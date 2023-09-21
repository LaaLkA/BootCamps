// Сортировка Выбором О(n^2)

/*
 [45, 23, -10, 5, 3, 9, 1]

 min = -10;
 [-10, 23, 45, 5, 3, 9, 1]
 min = 1;
 [-10, 1, 45, 5, 3, 9, 23]
 min = 3;
 [-10, 1, 3, 5, 45, 9, 23]
 min = 5; 
 [-10, 1, 3, 5, 45, 9, 23]
 min = 9;
 [-10, 1, 3, 5, 9, 45, 23]
 min = 23;
 [-10, 1, 3, 5, 9, 23, 45]
*/
int[] InputArray(int[] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(-20,21);// [-20,20]
    }
    return array;
}

int[] SortViber(int[] array)
{
    for (int i = 0; i < array.Length; i++)// Счётчики цикла лучше всего обзывать i, j, k, m, n
    {
        int indexMin = i;
        for (int j = i; j < array.Length; j++)
        {
            if (array[j] < array[indexMin])
                indexMin = j;
        }
        if(array[indexMin] == array[i])
        continue;
        
        int temp = array[i];
        array[i] = array[indexMin];
        array[indexMin] = temp;
    }
    return array;
}

Console.Clear();
System.Console.WriteLine("Введите кол-во элементов: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{String.Join(", ", array)}]");
Console.WriteLine($"Начальный массив: [{String.Join(", ", SortViber(array))}]");