namespace Itog // Объявляем пространство имен
{
    class Programm // Объявляем класс пространства имен
    {
        static void Main(string[] args) // Метод Main класса Programm
        {
            Console.Write("Введите количество элементов массива: \t");
            int elementsCount = int.Parse(Console.ReadLine()); // Вводим elementsCount и присваиваем ей ввод пользователя
            int[] uArray = new int[elementsCount]; //создаём массив на основе elementsCount

            Console.WriteLine("Введенный Вами массив: ");
            
            for (int i = 0; i < uArray.Length; i++) //Бегаем по массиву и даём его обратно
            {
                Console.WriteLine(uArray[i]);
            }






        }
    }   
}
// Не забудь смержить ветку userArray в мастер!!!!!!!!!!!!!