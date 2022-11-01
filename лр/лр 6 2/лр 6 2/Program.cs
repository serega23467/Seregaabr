using System; //Создайте метод Distance который вычисляет расстояние между двумя точками на плоскости. Координаты точек вводятся (переменные x1, y1 — для первой точки, и x2, y2 — для второй).


namespace лр_6_2
{
    class Program
    {
        static double distance(double x1, double y1, double x2, double y2) //метод принимает координаты x и y двух точек
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)); //возврат расстояния по формуле нахождегтя расстояния
        }
        static void Main(string[] args)
        {
            Console.WriteLine("x1=");
            double x1 = Convert.ToDouble(Console.ReadLine());        
            Console.WriteLine("y1=");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("x2=");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y2=");
            double y2 = Convert.ToDouble(Console.ReadLine()); //ввод координат точек
            double z = distance(x1, y1, x2, y2); //вычисление расстояния созданным методом
            Console.WriteLine($"Расстояние между точками {z}");

        }
    }
}
