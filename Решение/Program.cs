// Печать одномерного массива
void Print1DArray (string[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"[{array[i]}]\t");
    }
    if(array.Length == 0)
        {
            Console.WriteLine("Массив пустой");
        }
}
int maxLength = 3;
// Метод находит строки в массиве длина которых меньше или равна трем
string [] NewArray (string[] array)
{
    int length = array.Length;          
    string[] result = new string[length];
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        if(array[i].Length <= maxLength)
        {
            result[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref result, count);        
    return result;
}
string[] arr1 = {"Hello", "2", "world", ":-)"};
string[] arr2 = {"1234", "1567", "-2", "computer science"};
string[] arr3 = {"Russia", "Denmark", "Kazan"};
        
void PrintData(string[] array)
{
    Console.WriteLine("Исходный массив: ");
    Print1DArray(array);
    string[] shortArray = NewArray(array);
    Console.WriteLine();
    Console.WriteLine($"Массив из строк длина которых меньше или равна {maxLength}");
    Print1DArray(shortArray);
    Console.WriteLine();
}       
PrintData(arr1);
PrintData(arr2);
PrintData(arr3);

