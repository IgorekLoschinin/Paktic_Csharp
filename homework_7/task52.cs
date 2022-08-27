using System;


namespace Homework_7 {

    class Task52 {

        public double[] MeanArray (int[,] arr, int axis = 0) {
            
            double[] mean = new double[0];
            if (axis == 0) {
                mean = MeanInRow(arr);
            }

            if (axis == 1) {
                mean = MeanInCol(arr);
            }

            return mean;
        }

        public double[] MeanInRow (int[,] arr) {
            
            double[] vectMean = new double[arr.GetLength(0)];
            int[] row = new int[arr.GetLength(1)];

            for (int i = 0; i < arr.GetLength(0); i++) {
                for (int j = 0; j < arr.GetLength(1); j++) {
                    row[j] = arr[i, j];
                }
                vectMean[i] = Mean(row);
            }

            return vectMean;

        }

        public double[] MeanInCol (int[,] arr) {
            
            double[] vectMean = new double[arr.GetLength(1)];
            int[] col = new int[arr.GetLength(0)];

            
            for (int i = 0; i < arr.GetLength(1); i++) {
                for (int j = 0; j < arr.GetLength(0); j++) {
                    col[j] = arr[j, i];
                }
                vectMean[i] = Mean(col);
            }

            return vectMean;

        }

        public double Mean (int[] vec) {

            double avg = 0;
            foreach (int item in vec) {
                avg += item;
            }
            avg /= vec.Length;

            return Math.Round(avg,2);
        }

        public int[,] Create2DArray(int m, int n) {
            
            int[,] arr2D = new int[m, n];
            Random randomObj = new Random();

            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    arr2D[i, j] = randomObj.Next(0, 100);
                }
            }

            return arr2D;

        }

        public bool isDigit (string num) {            
            bool digit = Int32.TryParse(num, out _);
            return digit;
        }        

        public int[,] Create2DArrayManually() {

            int m, n;

            Console.WriteLine("Enter size 2d array m x n: ");
            Console.WriteLine($"Enter number rows (m):");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Enter number cols (n):");        
            n = Convert.ToInt32(Console.ReadLine());

            int[,] arr2D = new int[m, n];
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

                    arr2D[i, j] = Convert.ToInt32(numElem);
                }
            }

            return arr2D;
        }

        public void Print2DArray(int[,] arr) {
    
            for (int i = 0; i < arr.GetLength(0); i++) {
                for (int j = 0; j < arr.GetLength(1); j++) {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.Write("\n");
            }

        }

    }

}