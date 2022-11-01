using System; //Разработать мини-игру “Угадай число”. Пользователь выбирает диапазон значений, после программа случайным образом выбирает одно значение из диапазона и игра начинается. 
namespace лр_7
{
    class Program
    {///
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число диапазона");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число диапазона");
            int b = int.Parse(Console.ReadLine()); //ввод чисел диапазона
            Random x = new Random();
            int random = x.Next(a, b); //случайное число в рамках диапазона
            Console.WriteLine("Введите правильное число, у вас 5 попыток");
            for (int y = 0; y<5; y++) //цикл позволяет сделать 5 попыток
            {
                int otvet = int.Parse(Console.ReadLine()); 
                if (otvet==random)
                {
                    Console.WriteLine("Верно!");
                    break;
                }    
                else
                {
                    Console.WriteLine("Не верно!");
                }
            }
            Console.WriteLine($"Верное число {random}");

        }
    }
}
