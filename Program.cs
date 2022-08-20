string[] FirstArray() // Метод для массива
{
    Console.Write("Введите количество элементов массива:  ");
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

(int, string[]) progArray(string[] array)//Метод создания нового массива
{
    
}





    
/*    int elementsCount = int.Parse(Console.ReadLine()); // Вводим elementsCount и присваиваем ей ввод пользователя
    int[] uArray = new int[elementsCount]; //создаём массив на основе elementsCount

    for (int i = 0; i < uArray.Length; i++) //Бегаем по массиву и даём его обратно
    {
        Console.Write($"Введите элемент массива под индексом {i}: ");
        uArray[i] = int.Parse(Console.ReadLine()); // Заполнить каждый элемент массива данными пользователя
    }

    int[] triArray = new int[]
    for (int i = 0; i < length; i++)
    {
        uArray[i].Length = 
    }
            
    do
    {
          
    } while (true);
}
*/ 