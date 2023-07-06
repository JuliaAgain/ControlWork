// Задача: Написать программу, которая из имеющегося массива строк формирует 
// новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] FillArray(int size)    // метод для заполнения массива
{
    string[] arr = new string[size];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine("Введите элемент массива");
        string element = Console.ReadLine();
        arr[i] = element;
    }
    return arr;
}

void PrintArray(string[] arr, string sep = ",")  // метод для вывода массива
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length -1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}]");
    }
}

int CountNumElementsShorterThanThree(string[] arr)
{
    int counter = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < 4) counter+=1;
    }
    return counter;
}

string[] FillNewShortArray(int size, string[] arr)    // метод для заполнения массива
{
    string[] newArr = new string[size];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < 4) 
        {
        newArr[j] = arr[i];
        j+=1;
        }
    }
    return newArr;
}

Console.WriteLine("Введите число элементов в массиве");
int num = Convert.ToInt32(Console.ReadLine());
string[] array = FillArray(num);
Console.WriteLine("Исходный массив:");
PrintArray(array);
int newNum = CountNumElementsShorterThanThree(array);
Console.WriteLine();
Console.WriteLine("Новый массив из элементов, длина которых <=3:");
string[] NewShortArray = FillNewShortArray(newNum, array);
PrintArray(NewShortArray);
