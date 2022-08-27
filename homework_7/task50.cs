using System;


namespace Homework_7 {

    class Task50 {

        private double[,] array2D;


        public bool isNumInArray (double num) {
            
            int countNum = 0;
            foreach (double item in array2D) {
                if (item == num) {
                    countNum++;
                }
            }

            if (countNum != 0) {
                Console.WriteLine($"Число {num} есть в массиве!");
                return true;
            }

            Console.WriteLine($"Такого числа ({num}) в массиве нет!");
            return false;

        }

        public bool isElemByPosition (int row, int col) {

            int sizeRow = array2D.GetLength(0);
            int sizeCol = array2D.GetLength(1);

            if (row >= sizeRow || col >= sizeCol) {
                Console.WriteLine($"Элемента в позиции arr[{row}][{col}] NOT!");
                return false;
            }

            Console.WriteLine($"Элемента в позиции arr[{row}][{col}] = {array2D[row, col]}!");
            return true;

        }

        public void Create2DArray(int m, int n) {
            
            array2D = new double[m, n];
            Random randomObj = new Random();

            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    array2D[i, j] = randomObj.Next(0, 100);
                }
            }

        }       

        public void Print2DArray() {
    
            for (int i = 0; i < array2D.GetLength(0); i++) {
                for (int j = 0; j < array2D.GetLength(1); j++) {
                    Console.Write($"{array2D[i, j]} ");
                }
                Console.Write("\n");
            }

        }

    }

}