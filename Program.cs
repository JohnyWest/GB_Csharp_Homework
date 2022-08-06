namespace Itog // Объявляем пространство имен
{
    class Programm // Объявляем класс пространства имен
    {
        static void Main(string[] args) // Метод Main класса Programm
        {
            Console.Write("Введите количество элементов массива: \t");
            int elementsCount = int.Parse(Console.ReadLine()); // Вводим elementsCount и присваиваем ей ввод пользователя
            int[] uArray = new int[elementsCount]; //создаём массив на основе elementsCount
            
            for (int i = 0; i < uArray.Length; i++) //Бегаем по массиву и даём его обратно
            {
                Console.Write($"Введите элемент массива под индексом {i}: \t");
                uArray[i] = int.Parse(Console.ReadLine()); // Заполнить каждый элемент массива данными пользователя
            }

            Console.WriteLine("Ваш массив: ");
            for (int i = 0; i < uArray.Length; i++)
            {
                Console.WriteLine(uArray[i]);
            }




        }
    }   
}
// Не забудь смержить ветку userArray в мастер!!!!!!!!!!!!!