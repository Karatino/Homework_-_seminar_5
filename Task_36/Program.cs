/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

void FillArrayRandomNumbers(int[] myArray)
{
    for(int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = new Random().Next(1,10);
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

void SumOddNumbers(int[] myArray)
{
    int sum = 0;
    for (int z = 0; z < myArray.Length; z += 2)
    sum = sum + myArray[z];
    Console.WriteLine($"Всего {myArray.Length} чисел, сумма элементов на нечётных позициях = {sum}");
}

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray = new int[size];
FillArrayRandomNumbers(myArray);
Console.WriteLine("Вот наш массив: ");
PrintArray(myArray);
SumOddNumbers(myArray);