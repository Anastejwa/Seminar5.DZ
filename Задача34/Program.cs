// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int size = 6;
int[] numbers = new int [size];
FillArray(numbers, 100, 999);
PrintArray(numbers);
Console.WriteLine("Количество четных чисел в массиве: " + Counter(numbers));

int Counter(int[] numbers)
{
int count = 0;
for (int i = 0; i < numbers.Length; i++)
    {
      if (numbers[i] % 2 == 0)
       count++;
    }
return count;
}
void FillArray(int[] numbers, int minValue=0, int maxValue=100)
{
Random random = new Random();
maxValue++;
for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(minValue,maxValue);
    }
}

void PrintArray(int[] numbers)
{
Console.WriteLine("Вывод массива:");
for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
Console.WriteLine();
}