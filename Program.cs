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
            
            
            int[] triArray = new int[]
            for (int i = 0; i < length; i++)
            {
                uArray[i].Length = 
            }
            

            do
            {
                
            } while (true);

            /* Короче хз, лучше наверное использовать:
            uArray[i].Length
            */


            /* Еще один пример
            Console.WriteLine("Введите строку");
            string input = Console.ReadLine();
            int ind = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input.Substring(i, 1) != " ")
                    ind++;
            }
            Console.WriteLine("Количество букв равно {0}", ind);
            Console.ReadKey();
            */


            //Выбираем один элемент, сверяем длинну <=3 символа и пишем в переменную
            /*
            Переменную записать в новый МАССИВ
            */


        }
    }   
}
// Не забудь смержить ветку userArray в мастер!!!!!!!!!!!!!