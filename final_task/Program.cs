int GetOriginalArraySize()
{
    int size = 0;
    while (true)
    {
        Console.Write("Введите размер массива: ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out size))
        {
            break;
        }
        Console.WriteLine("Введено некорректное значение. Пожалуйста, введите целое число.");
    }
    return size;
}

void FillOriginalArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите эллемент под индексом {i}: ");
        array[i] = Console.ReadLine();
    }
}

void PrintArray(string[] array)
{
    string result = "[ ";
    for (int i = 0; i < array.Length; i++)
    {
        result += $"{array[i]} ";
    }
    result += "]";
    Console.Write(result);
}

string[] ModifiedArray(string[] array)
{
    int lengthLimit = 3;

    int numbersItems = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= lengthLimit)
        {
            numbersItems++;
        }
    }

    string[] modifiedArray = new string[numbersItems];

    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= lengthLimit)
        {
            modifiedArray[j] = array[i];
            j++;
        }
    }
    return modifiedArray;

}

int size = GetOriginalArraySize(); // запрос исходного размера массива
string[] originalArray = new string[size]; // инициализация массива
FillOriginalArray(originalArray); // заполнение массива пользователем
PrintArray(originalArray); // печать массива на консоль
System.Console.WriteLine();// разделитель для удобства чтения
PrintArray(ModifiedArray(originalArray)); // основная функция по условию задачи на проверку длины элементов массива и формирования нового удовлетворяющих условию








