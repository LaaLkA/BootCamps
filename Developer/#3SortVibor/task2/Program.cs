int[] InputArray(int[] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(-20, 21); // [-20, 20]
    }
    return array;
}
int[] SortVibor (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int indexMin = i;
        for (int j = i; j < array.Length; j++)
        {
            if(array[j] < array[indexMin])
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
Console.WriteLine($"Введите размер массива:");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Неотсортированный массив: [{String.Join(", ", array)}]");
Console.WriteLine($"Отсортированный массив: [{String.Join(", ", SortVibor(array))}]");