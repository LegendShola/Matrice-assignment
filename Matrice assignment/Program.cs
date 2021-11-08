using System;

namespace Matrice_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose any of the Operation\n1: For Multiplying Matrix\n2: " +
               "For Finding Matrix Determinant\n3: For Finding Matrix Dot Program");
            int choice = Int32.Parse(Console.ReadLine());

            Console.WriteLine();

            if (choice == 1)
            {
                MatrixMultiplication mul = new MatrixMultiplication();
                mul.multiplication();
            }
            else if (choice == 2)
            {
                Determinant mat = new Determinant();
                mat.Display();
            }
            else if (choice == 3)
            {
                Dot dot = new Dot();
                dot.Dots();
            }
            else
            {
                Console.WriteLine("No Such Choice");
            }
        }
    }
}
