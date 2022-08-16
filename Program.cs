string[] FirstArray()//Метод создания массива 
{
    
    int index = 0;
    string text = String.Empty;
    List<string> arrayList = new List<string>();
    do
    {
        Console.Write($"Элемент массива № {index} : ");
        text = Console.ReadLine();
        if (text == null) text = String.Empty;// проверка пустых значений
        arrayList.Add(text);
        index++;
        Console.WriteLine("\t Для продолжения ввода элементов нажмите любую кнопку, для выхода нажмите ESC");
    }
    while (Console.ReadKey().Key != ConsoleKey.Escape);

    string[] array = new string[arrayList.Count];

    for (int i = 0; i < array.Length; i++) array[i] = arrayList[i];

    return array;
}

Console.WriteLine("Введите с клавиатуры эллементы массива ");
string[] array = FirstArray(); // Создаю изначальный массив
