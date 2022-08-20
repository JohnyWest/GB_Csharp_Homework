string[] uArray() // Метод для массива
{
    Console.Write("Введите с клавиатуры эллементы массива: ");
    int index = 0;
    string text = String.Empty;
    List<string> uList = new List<string>();

    do
    {
        Console.Write($"Элемент массива № {index}:  ");
        text = Console.ReadLine(); // Пишем в текст
        if (text == null) text = String.Empty;// Проверяем ввод пустого значения
        uList.Add(text);
        index++;
        Console.WriteLine("Для продолжения ввода нажмите Enter.  Для выхода - Esc");
    }
    while (Console.ReadKey().Key != ConsoleKey.Escape);
    string[] array = new string[uList.Count];
    for (int i = 0; i < array.Length; i++) array[i] = uList[i];
    return array;
}

(int, string[]) ProgArray(string[] array)//Метод создания второго массива
{
    int count = 0;
        for (int i = 0; i < array.Length; i++) if (array[i].Length <= 3) count++;
            
    string[] arrayResul = new string[count];
    return (count, arrayResul);
}


void FillArray(string[] array, string[] fillArray)//Метод заполнения массива 
{
    int index = 0;
        for (int i = 0; i < array.Length; i++) if (array[i].Length <= 3)
            {
                fillArray[index] = array[i];
                index++;
           }
            
}

string PrintArray(string[] array) // Метод печати массива
{
    string result = String.Empty;
    result += "[";
    for (int i = 0; i < array.Length; i++)
    {
        result += '"' + array[i] + '"';
        if (i < array.Length - 1) result += ',';
    }
    result += "]";
    return result;
}

string[] array = uArray(); // Массив пользователя
(int count, string[] progArray) = ProgArray(array); // Создём программный массив
FillArray(array, progArray); // Заполняем второй массив элементами, чья длина <=3 символов
Console.WriteLine();
Console.WriteLine("Первоначальный массив: ");
Console.WriteLine($"{PrintArray(array)} "); //Печатаем изначальный массив
Console.WriteLine("Массив из элементов, длина которых <=3: ");
Console.WriteLine($"{PrintArray(progArray)}"); //Вывод на консоль результата (массив длинной <=3 символа)
