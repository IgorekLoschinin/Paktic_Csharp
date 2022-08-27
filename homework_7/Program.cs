using System;


namespace Homework_7 {


    class Homework {

        static void Main () {

            Console.WriteLine("--------===== Decision Task 47 =====--------\n");
            Console.WriteLine("--------===== Create2DArray =====--------\n");
            Task47 task47 = new Task47();

            Console.WriteLine($"Введите количество чисел М: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите количество чисел N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double[,] myArr = task47.Create2DArray(m, n);
            task47.Print2DArray(myArr);

            Console.WriteLine("--------===== Create2DArrayManually =====--------\n");
            myArr = task47.Create2DArrayManually();
            task47.Print2DArray(myArr);



            Console.WriteLine("--------===== Decision Task 52 =====--------\n");
            Console.WriteLine("--------===== Create2DArrayInt =====--------\n");
            Task52 task52 = new Task52();

            Console.WriteLine($"Введите количество чисел М: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите количество чисел N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] myArr = task52.Create2DArray(m, n);
            task52.Print2DArray(myArr);

            Console.WriteLine("--------===== MeanArray =====--------\n");
            myArr = task52.Create2DArrayManually();
            task52.Print2DArray(myArr);

            double[] meanArrCol = task52.MeanArray(myArr, 1);
            Console.WriteLine($"Среднее арифметическое каждого столбца: {string.Join("; ", meanArrCol)}");

            double[] meanArrRow = task52.MeanArray(myArr, 0);
            Console.WriteLine($"Среднее арифметическое каждой строки: {string.Join("; ", meanArrRow)}");



            Console.WriteLine("--------===== Decision Task 50 =====--------\n");            
            Task50 task50 = new Task50();

            Console.WriteLine($"Введите количество чисел М: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите количество чисел N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            task50.Create2DArray(m, n);
            task50.Print2DArray();

            
            Console.WriteLine($"Введите позицию элемента в строке: ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите позицию элемента в столбце: ");
            int col = Convert.ToInt32(Console.ReadLine());
            task50.isElemByPosition(row, col);

            Console.WriteLine($"\nПоиск элемента в массиве");
            Console.WriteLine($"Введите число для поиска: ");
            int findNum = Convert.ToInt32(Console.ReadLine());
            task50.isNumInArray(findNum);
            

        }

    }
}

