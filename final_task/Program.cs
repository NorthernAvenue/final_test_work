int GetArraySize()
{
    System.Console.Write("Размер - ");
    int size = Convert.ToInt32(Console.ReadLine());
    return size;
}
void PrintOriginalArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"Введите элемент № {i}");
        array[i] = Console.ReadLine();
    }
    System.Console.Write("Оригинальный массив: " + string.Join(",", array));
}
void PrintModifiedArray(string [] array)
{   
    string [] newArray = array.Where(array => array.Length <=3).ToArray();
    System.Console.WriteLine();
    System.Console.WriteLine("Новый массив : " + string.Join(",", newArray));
}

int size = GetArraySize();
string [] array = new string [size];
PrintOriginalArray(array);
PrintModifiedArray(array);