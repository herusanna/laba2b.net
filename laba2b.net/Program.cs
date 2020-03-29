using System;

namespace laba2.net
{
    class Program
    {
        static void Main(string[] args)
        {
            Quadrangle quadrangle = new Quadrangle();
            quadrangle.Show();
            Console.WriteLine($"Стороны: ");
            quadrangle.getSide();
            Parallelogramm parallelogramm = new Parallelogramm();

            Console.WriteLine($"Проверка на существование: ");
            if (quadrangle.exist())
                Console.WriteLine("Четырехугольник существует");
            else
                Console.WriteLine("Стороны неправильные");
            Console.WriteLine();
            Console.WriteLine($"Периметр: {String.Format("{0:0.00}", quadrangle.getPerimetr())}");
            Console.WriteLine($"Площадь: {String.Format("{0:0.00}", quadrangle.getArea())}");
            quadrangle.getDiagon();
            Console.WriteLine();
            Quadrangles quadrangles = new Quadrangles(20);
            quadrangles.printQuadrangles();
            Console.WriteLine($"Среднее значение площадей(N): {String.Format("{0:0.00}", quadrangles.findAverageArea())}");
            Console.WriteLine();
            if (parallelogramm.checkParallelogramm())
                Console.WriteLine("Это параллелограмм");
            else
                Console.WriteLine("Это просто четырехугольник");

            Parallelogrammes parallelogrammes = new Parallelogrammes();
            parallelogrammes.getParallelo(50);
            //parallelogrammes.getParallelArea();
            Console.WriteLine($"Наибольшая площадь(M) у параллелограмма [{parallelogrammes.findWithdMaxArea() + 1}]");
            Console.WriteLine($"Наименьшая площадь(M) у параллелограмма [{ parallelogrammes.findWithdMinArea() + 1}]");

        }
        public class Parallelogramm : Quadrangle
        {
            public bool checkParallelogramm()
            {
                getSide();
                if (side[0] == side[2] && side[1] == side[3])
                    return true;
                else return false;
            }
        }
    }
}
