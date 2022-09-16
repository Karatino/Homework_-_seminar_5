/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

void FillArrayRandomNumbers(double[] myArray)
{
    for(int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
    }
}

void PrintArray(double[] myArray)
{
    Console.Write("[ ");
    for(int i = 0; i < myArray.Length; i++)
        {
            Console.Write(myArray[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}

void DifferenceValues(double[] myArray)
{
    double min = Int32.MaxValue;
    double max = Int32.MinValue;

    for (int z = 0; z < myArray.Length; z++)
    {
        
        if (myArray[z] > max)
            {
                max = myArray[z];
            }
        if (myArray[z] < min)
            {
                min = myArray[z];
            }


    }

Console.WriteLine($"всего {myArray.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

}

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] myArray = new double[size];
FillArrayRandomNumbers(myArray);
Console.WriteLine("Вот наш массив: ");
PrintArray(myArray);
DifferenceValues(myArray);


