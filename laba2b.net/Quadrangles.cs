using System;
using System.Collections.Generic;
using System.Text;

namespace laba2.net
{
    public class Quadrangles
    {
        Quadrangle[] quadrangle;
        internal Quadrangle[] Quadran { get => quadrangle; set => quadrangle = value; }
        public Quadrangles()
        { }
        public Quadrangles(int N)
        {
            Console.Write("Введите количество четырехугольников(N): ");
            N = Convert.ToInt32(Console.ReadLine());
            Quadran = new Quadrangle[N];
            for (int i = 0; i < N; i++)
            {
                Quadran[i] = new Quadrangle();
                Console.WriteLine($"{i + 1} четырехугольник: ");
                Quadran[i].getSide();
            }
            Console.WriteLine();
        }
        public virtual void printQuadrangles()
        {
            int i = 1;
            foreach (Quadrangle quadrangle in Quadran)
            {
                Console.Write($"{i++} Площадь: {String.Format("{0:0.00}", quadrangle.getArea())}");
                Console.WriteLine();
            }
        }
        public virtual double findAverageArea()
        {
            double average = 0;
            double sum = 0;
            if (Quadran.Length > 0)
            {
                for (int i = 0; i < Quadran.Length; i++)
                {
                    sum += Quadran[i].getArea();
                }
                average = sum / Quadran.Length;
            }
            return average;
        }
    }
    public class Parallelogrammes : Quadrangle
    {

        Quadrangle[] quadrangles;
        internal Quadrangle[] parallelo { get => quadrangles; set => quadrangles = value; }
        public double[] area;
        public void getParallelo(int M)
        {
            Console.Write("Введите количество параллелограммов(М): ");
            M = Convert.ToInt32(Console.ReadLine());
            // Quadrangle.Parallelogramm parallelogramm = new Quadrangle.Parallelogramm();
            parallelo = new Quadrangle[M];
            Random r = new Random();

            for (int i = 0; i < M; i++)
            {
                parallelo[i] = new Quadrangle();
                parallelo[i].a = r.Next(2, 20);
                //parallelo[i].c = parallelo[i].a;
                parallelo[i].b = r.Next(2, 20);
                //parallelo[i].d = parallelo[i].b;
                parallelo[i].angle[0] = Math.Sin(r.Next(1, 3));
                parallelo[i].angle[1] = Math.Sin(Math.PI - parallelo[i].angle[0]);
                Console.Write($"{i + 1} параллелограмм ");
                Console.WriteLine($" Cтороны {parallelo[i].a} cm,   {parallelo[i].b}cm");
            }
        }
        public int findWithdMaxArea()
        {
            int max = 0;
            if (parallelo.Length > 0)
            {
                for (int i = 1; i < parallelo.Length; i++)
                {
                    if ((parallelo[max].a * parallelo[max].b * parallelo[max].angle[0]) < (parallelo[i].a * parallelo[i].b * parallelo[i].angle[0]))
                        max = i;
                }
            }
            return max;
        }
        public int findWithdMinArea()
        {
            int min = 0;
            if (parallelo.Length > 0)
            {
                for (int i = 1; i < parallelo.Length; i++)
                {
                    if ((parallelo[min].a * parallelo[min].b * parallelo[min].angle[0]) > (parallelo[i].a * parallelo[i].b * parallelo[i].angle[0]))
                        min = i;
                }
            }
            return min;
        }
    }
}
