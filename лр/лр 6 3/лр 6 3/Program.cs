using System; //Напишите метод с именем Circarea(), которая вычисляет площадь круга. Функция должна принимать один аргумент типа float и возвращать значение типа float.

namespace лр_6_3
{
    class Program
    {
        static float Circarea(float R)
        {
            return (float)(3.14 * Math.Pow(R, 2)); //формула площади круга Пи на квадрат радиуса
        }
        static void Main(string[] args)
        {
            Console.WriteLine("введите радиус");
            float R = float.Parse(Console.ReadLine()); //ввод радиуса
            float s = Circarea(R);
            Console.WriteLine($"Площадь круга {s}");

        }
    }
}
