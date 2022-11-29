Console.WriteLine("Введите элементы массива через пробел");
string[] array = Console.ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

string[] array2 = NewArray(array);
Console.WriteLine("Ваш новый массив");
PrintArray(array2);

void PrintArray(string[] array1)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        Console.Write($"{array1[i]} ");
    }
}



string[] NewArray(string[] array1)
{
    int j = 0;
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        if (array1[i].Length <= 3)
        {
            j = j + 1;
        }
    }
    string[] arraynew = new string[j + 1];
    j = 0;   
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        if (array1[i].Length <= 3)
        {
            arraynew[j] = array1[i];
            j = j + 1;
        }
    }
    return arraynew;
}