using System;


namespace Homework_7 {

    class Task47 {

        public double[,] Create2DArray(int m, int n) {
            
            double[,] arr2D = new double[m, n];
            Random randomObj = new Random();

            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    arr2D[i, j] = Math.Round(randomObj.NextDouble(), 2);
                }
            }

            return arr2D;

        }

        public bool isDigit (string num) {            
            bool digit = Double.TryParse(num, out _);
            return digit;
        }        

        public double[,] Create2DArrayManually() {

            int m, n;

            Console.WriteLine("Enter size 2d array m x n: ");
            Console.WriteLine($"Enter number rows (m):");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Enter number cols (n):");        
            n = Convert.ToInt32(Console.ReadLine());

            double[,] arr2D = new double[m, n];
            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    
                    string numElem;
                    while (true) {
                        Console.WriteLine($"Enter elem arr[{i}][{j}] = ");
                        numElem = Console.ReadLine();
                        if (isDigit(numElem)) {
                            break;
                        } else {
                            Console.WriteLine($"The entered string is not a number = {numElem}.");
                        }
                        Console.WriteLine($"Give it a try!");
                    }

                    arr2D[i, j] = Convert.ToDouble(numElem);
                }
            }

            return arr2D;
        }

        public void Print2DArray(double[,] arr) {
    
            for (int i = 0; i < arr.GetLength(0); i++) {
                for (int j = 0; j < arr.GetLength(1); j++) {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.Write("\n");
            }

        }

    }

}