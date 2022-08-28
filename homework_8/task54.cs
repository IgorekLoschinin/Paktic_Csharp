namespace Homework_8 {

    class Task54: CommonFunc {

        public void runTask () {

            Console.WriteLine($"Введите количество чисел М: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите количество чисел N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] myArr = Create2DArrayInt(m, n);
            Print2DArray(myArr);

            Console.WriteLine($"Сортировка в строках!");
            int[,] sortArrRow = Sort2DArray(myArr, 0);
            Print2DArray(sortArrRow);

            Console.WriteLine($"Сортировка в столбцах!");
            int[,] sortArrCol = Sort2DArray(myArr, 1);
            Print2DArray(sortArrCol);

        }

        public double[,] Sort2DArray (double[,] arr, int axis=0) {

            double[,] sort2Darr = new double[arr.GetLength(0), arr.GetLength(1)];
            if (axis == 0) {
                sort2Darr = SortByRow(arr);
            }

            if (axis == 1) {
                sort2Darr = SortByCol(arr);
            }

            return sort2Darr;

        }

        public int[,] Sort2DArray (int[,] arr, int axis=0) {

            int[,] sort2Darr = new int[arr.GetLength(0), arr.GetLength(1)];
            if (axis == 0) {
                sort2Darr = SortByRow(arr);
            }

            if (axis == 1) {
                sort2Darr = SortByCol(arr);
            }

            return sort2Darr;

        }

        private double[,] SortByRow (double[,] arr) {
            
            double[,] sortArray = new double[arr.GetLength(0), arr.GetLength(1)];
            double[] row = new double[arr.GetLength(1)];

            for (int i = 0; i < arr.GetLength(0); i++) {
                for (int j = 0; j < arr.GetLength(1); j++) {
                    row[j] = arr[i, j];
                }
                
                Array.Sort(row);
                Array.Reverse(row);

                for (int l = 0; l < arr.GetLength(1); l++) {
                    sortArray[i, l] = row[l];
                }

            }

            return sortArray;

        }

        private int[,] SortByRow (int[,] arr) {
            
            int[,] sortArray = new int[arr.GetLength(0), arr.GetLength(1)];
            int[] row = new int[arr.GetLength(1)];

            for (int i = 0; i < arr.GetLength(0); i++) {
                for (int j = 0; j < arr.GetLength(1); j++) {
                    row[j] = arr[i, j];
                }
                
                Array.Sort(row);
                Array.Reverse(row);

                for (int l = 0; l < arr.GetLength(1); l++) {
                    sortArray[i, l] = row[l];
                }

            }

            return sortArray;

        }

        private double[,] SortByCol (double[,] arr) {
            
            double[,] sortArray = new double[arr.GetLength(0), arr.GetLength(1)];
            double[] col = new double[arr.GetLength(0)];

            
            for (int i = 0; i < arr.GetLength(1); i++) {
                for (int j = 0; j < arr.GetLength(0); j++) {
                    col[j] = arr[j, i];
                }
                
                Array.Sort(col);
                Array.Reverse(col);

                for (int l = 0; l < arr.GetLength(0); l++) {
                    sortArray[l, i] = col[l];
                }
            }

            return sortArray;

        }

        private int[,] SortByCol (int[,] arr) {
            
            int[,] sortArray = new int[arr.GetLength(0), arr.GetLength(1)];
            int[] col = new int[arr.GetLength(0)];

            
            for (int i = 0; i < arr.GetLength(1); i++) {
                for (int j = 0; j < arr.GetLength(0); j++) {
                    col[j] = arr[j, i];
                }
                
                Array.Sort(col);
                Array.Reverse(col);

                for (int l = 0; l < arr.GetLength(0); l++) {
                    sortArray[l, i] = col[l];
                }
            }

            return sortArray;

        }

    }

}