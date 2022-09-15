/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

void FillArrayRandomNumbers(int[] myArray)
{
    for(int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = new Random().Next(100,1000);
    }
}

void PrintArray(int[] myArray)
{
    Console.Write("[ ");
    for(int i = 0; i < myArray.Length; i++)
    {
        Console.Write(myArray[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

void FindEvenNumbers(int[] myArray)
{
    int count = 0;
    for (int z = 0; z < myArray.Length; z++)
    if (myArray[z] % 2 == 0)
    count++;
    Console.WriteLine($"всего {myArray.Length} чисел, {count} из них чётные");
}


Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray = new int[size];
FillArrayRandomNumbers(myArray);
Console.WriteLine("Вот наш массив: ");
PrintArray(myArray);
FindEvenNumbers(myArray);




/*Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Вот наш массив: ");
PrintArray(numbers);
int count = 0;

for (int z = 0; z < numbers.Length; z++)
if (numbers[z] % 2 == 0)
count++;

Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}*/
