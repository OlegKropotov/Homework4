// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


int [] Print()
{
int [] array= new int [8];
    for (int i = 0; i < array.Length; i++)
{
    Console.Write("enter the element of the array \n");
    array[i]=Convert.ToInt32(Console.ReadLine());
}
return array;
}
Console.WriteLine(string.Join(",",Print()));