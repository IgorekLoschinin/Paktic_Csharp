using System.Linq;

namespace Homework_8 {

    class Task56: CommonFunc {

        public void runTask () {

            Console.WriteLine($"Введите количество чисел М: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите количество чисел N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] myArr = Create2DArrayInt(m, n);
            Print2DArray(myArr);
            
            Console.WriteLine($"Строка {SmallestSumOfElements(myArr)} с наименьшей суммой!");

        }

        public int SmallestSumOfElements (int[,] arr) {
            
            int[] sumElemInRow = SumOfElementsRow(arr);

            return sumElemInRow.ToList().IndexOf(sumElemInRow.Min());

        }

        public double SmallestSumOfElements (double[,] arr) {
            
            double[] sumElemInRow = SumOfElementsRow(arr);

            return sumElemInRow.ToList().IndexOf(sumElemInRow.Min());

        }

        private int[] SumOfElementsRow (int[,] arr) {
            
            int[] sumElemInRow = new int[arr.GetLength(0)];                  
            int[] row = new int[arr.GetLength(1)];

            for (int i = 0; i < arr.GetLength(0); i++) {

                for (int j = 0; j < arr.GetLength(1); j++) {
                    row[j] = arr[i, j];
                }

                int sR = row.Sum();
                Console.WriteLine($"Sum elements in row[{i}] = {sR}");

                sumElemInRow[i] = sR;

            }

            return sumElemInRow;

        }

        private double[] SumOfElementsRow (double[,] arr) {
            
            double[] sumElemInRow = new double[arr.GetLength(0)];                  
            double[] row = new double[arr.GetLength(1)];

            for (int i = 0; i < arr.GetLength(0); i++) {

                for (int j = 0; j < arr.GetLength(1); j++) {
                    row[j] = arr[i, j];
                }

                double sR = row.Sum();
                Console.WriteLine($"Sum elements in row[{i}] = {sR}");

                sumElemInRow[i] = sR;

            }

            return sumElemInRow;

        }

    }

}