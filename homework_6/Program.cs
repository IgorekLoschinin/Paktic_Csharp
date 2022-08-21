using System;


namespace Homework_6 {
    class Homework {
        static void Main () {

            Console.WriteLine("--------===== Decision Task 41 =====--------\n");
            Console.WriteLine("--------===== CountNumGreaterZero =====--------\n");
            Task41 task41 = new Task41();

            Console.WriteLine($"Введите количество чисел М: ");
            Console.WriteLine($"Количество чисел больше 0: {task41.CountNumGreaterZero()}");

            Console.WriteLine("--------===== Decision Task 43 =====--------\n");
            Console.WriteLine("--------===== intersectionPoint =====--------\n");
            
            Console.WriteLine($"Введите коэффициенты (k1, b1) уровнения y = k1 * x + b1: ");
            Console.WriteLine($"Введите коэффициент k1: ");
            double k1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Введите коэффициент b1: ");
            double b1 = Convert.ToDouble(Console.ReadLine());
            EquationLine1 eqL1 = new EquationLine1(k1, b1);

            Console.WriteLine($"Введите коэффициенты (k2, b2) уровнения y = k2 * x + b2: ");
            Console.WriteLine($"Введите коэффициент k2: ");
            double k2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Введите коэффициент b2: ");
            double b2 = Convert.ToDouble(Console.ReadLine());
            EquationLine2 eqL2 = new EquationLine2(k2, b2);

            Task43 task43 = new Task43();
            double[] M = task43.intersectionPoint(eqL1, eqL2);

            Console.WriteLine($"Точка пересечения двух прямых M(x, y) = ({M[0]}, {M[1]})");

        }
    }
}