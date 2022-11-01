using System; // Реализовать метод подсчѐта среднего арифметического числа учебных оценок.


namespace лр_6_1
{
    class Program
    {
        static double SrednArifmet(int[] x) //создание метода, возвращает double, принимает массив
        {
            double z = 0;
            foreach (int sr in x)
            {
                z += sr;
            } //сложение нулевой переменной со всеми элементами массива
            return z / x.Length; //возвращает деление суммы всех элементов массива на их количество
        }
        static void Main(string[] args)
        {
            int[] estimates = { 5, 4, 3, 2, 3, 4, 3, 4, 5, 2 };
            double g = SrednArifmet(estimates); //применение метода на массив estimates
            Console.WriteLine(g); //вывод результата применения метода
        }
    }
}
