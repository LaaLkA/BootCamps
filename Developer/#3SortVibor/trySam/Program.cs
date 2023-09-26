int[] SortVibor(int[] array)
{
      for (int i = 0; i < array.Length; i++)
      {
            int indexMin = i;
            for (int j = i; j < array.Length; j++)
            {
             if(array[j] < array[indexMin]) indexMin = j;     
            }
            if(array[i] == array[indexMin]) continue;

            int temp = array[i];
            array[i] = array[indexMin];
            array[indexMin] = temp;
      }
      return array;
}
void InputArray(int[] array)
{
      Random rand = new Random();
      for (int i = 0; i < array.Length; i++)
      {
            array[i] = rand.Next(-20,21);
      }
}

System.Console.WriteLine("Введите количество элементов массива:");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
System.Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
System.Console.WriteLine($"Конечный массив: [{string.Join(", ", SortVibor(array))}]");