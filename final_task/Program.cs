int GetArraySize() // Размер массива. Используется проверка на ввод корректного значения от пользователя
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

void FillArray(string [] array)  // Заполнение пользователем массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите эллемент под индексом {i}: ");
        array[i] = Console.ReadLine();
    }
}

void PrintArray(string[] array) // Печать  массива
{
    Console.Write(string.Join(",", array));
}

void CheckSizeValue(string[] array) // Проверка значений на кол-во символов и печать по условию задачи
{
    string[] newArray = array.Where(str => str.Length <= 3).ToArray();
}

int size = GetArraySize(); // получаем размер

string[] array = new string[size]; //ициализируем массив размера size

FillArray(array); // заполнение массива пользователем

Console.Write("Оригинальный массив: ");

PrintArray(array); // вывод массива на печать

System.Console.WriteLine();

Console.Write("Модифицированный массив: ");

CheckSizeValue(array); // проверка длины значений массива

PrintArray(array); // вывод массива на печать 







