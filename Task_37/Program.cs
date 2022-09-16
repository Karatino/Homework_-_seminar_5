/*Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21*/


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

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray = new int[size];
FillArrayRandomNumbers(myArray);
Console.WriteLine("Вот наш массив: ");
PrintArray(myArray);



  
    int mid = (myArray.Length + 1) / 2;
        int[] array1 = myArray.Take(mid).ToArray();
        int[] array2 = myArray.Skip(mid).ToArray();

Console.WriteLine("Разделенный массив:");
 
        Console.WriteLine(string.Join(", ", array1));        
        Console.WriteLine(string.Join(", ", array2));

Console.WriteLine("Перевернутый массив 2: ");

    Array.Reverse(array2);

    Console.WriteLine(String.Join(", ", array2));



    

    int hold = 1;
    int[] array3 = new int[size];
    for (int i = 0; i < array1.Length; i++)
    {
        if (i < array2.Length)
        {
            array3[i] = array1[i] * array2[i];
        }
        else
        {
            array3[i] = (array1[i] * hold);
        }

    
        Console.Write(array3[i] + ", ");
    }


    
        

