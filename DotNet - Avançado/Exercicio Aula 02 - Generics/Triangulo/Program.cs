using System;

namespace ExercicioAula02_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo<int> trianguloInteiros = new Triangulo<int>(
                new Ponto<int>(1, 2, 3),
                new Ponto<int>(4, 5, 6),
                new Ponto<int>(7, 8, 9)
            );

            Triangulo<double> trianguloDobles = new Triangulo<double>(
                new Ponto<double>(1.5, 2.5, 3.5),
                new Ponto<double>(4.5, 5.5, 6.5),
                new Ponto<double>(7.5, 8.5, 9.5)
            );

            Triangulo<string> trianguloStrings = new Triangulo<string>(
                new Ponto<string>("A", "B", "C"),
                new Ponto<string>("D", "E", "F"),
                new Ponto<string>("G", "H", "I")
            );

            Console.WriteLine("Triângulo com pontos inteiros:");
            ImprimirTriangulo(trianguloInteiros);

            Console.WriteLine("Triângulo com pontos decimais:");
            ImprimirTriangulo(trianguloDobles);

            Console.WriteLine("Triângulo com pontos de string:");
            ImprimirTriangulo(trianguloStrings);
        }

        static void ImprimirTriangulo<T>(Triangulo<T> triangulo)
        {
            Console.WriteLine($"P1: {triangulo.P1}");
            Console.WriteLine($"P2: {triangulo.P2}");
            Console.WriteLine($"P3: {triangulo.P3}");
        }
    }

    class Triangulo<T>
    {
        public Ponto<T> P1 { get; set; }
        public Ponto<T> P2 { get; set; }
        public Ponto<T> P3 { get; set; }

        public Triangulo(Ponto<T> p1, Ponto<T> p2, Ponto<T> p3)
        {
            P1 = p1;
            P2 = p2;
            P3 = p3;
        }

        public override string ToString()
        {
            return $"Triângulo({P1}, {P2}, {P3})";
        }
    }

    class Ponto<T>
    {
        public T X { get; set; }
        public T Y { get; set; }
        public T Z { get; set; }

        public Ponto(T x, T y, T z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }
    }
}

