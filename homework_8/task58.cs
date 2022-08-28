namespace Homework_8 {

    class Task58: CommonFunc {

        public void runTask () {

            Console.WriteLine($"Введите количество чисел М Матрица 1: ");
            int m1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите количество чисел N Матрица 1: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Матрица 1: ");
            int[,] mat1 = Create2DArrayInt(m1, n1);
            Print2DArray(mat1);


            Console.WriteLine($"Введите количество чисел М Матрица 2: ");
            int m2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите количество чисел N Матрица 2: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Матрица 2: ");
            int[,] mat2 = Create2DArrayInt(m2, n2);
            Print2DArray(mat2);

            Console.WriteLine($"Результирующая матрица будет: ");
            Print2DArray(MatrixMultipl(mat1, mat2));

        }

        public int[,] MatrixMultipl (int[,] mat1, int[,] mat2) {            

            int[,] multiplMatrix = new int[mat1.GetLength(0), mat2.GetLength(1)];
            
            if (!(mat1.GetLength(0) > mat2.GetLength(1) || mat1.GetLength(0) < mat2.GetLength(1))) {

                for (int i = 0; i < mat1.GetLength(0); i++) {
                    for (int j = 0; j < mat2.GetLength(1); j++) {
                        for (int k = 0; k < mat2.GetLength(1); k++) {

                            multiplMatrix[i,j] += mat1[i,k] * mat2[k,j];

                        }
                    }
                }            

                return multiplMatrix;
            }

            Console.WriteLine($"Произведение двух матриц А and В имеет смысл только в том случае, когда число столбцов матрицы А совпадает с числом строк матрицы В ");
            return multiplMatrix;

        }

        public double[,] MatrixMultipl (double[,] mat1, double[,] mat2) {

            double[,] multiplMatrix = new double[mat1.GetLength(0), mat2.GetLength(1)];

            if (!(mat1.GetLength(0) > mat2.GetLength(1) || mat1.GetLength(0) < mat2.GetLength(1))) {
                for (int i = 0; i < mat1.GetLength(0); i++) {
                    for (int j = 0; j < mat2.GetLength(1); j++) {
                        for (int k = 0; k < mat2.GetLength(0); k++) {

                            multiplMatrix[i,j] += mat1[i,k] * mat2[k,j];

                        }
                    }
                }

                return multiplMatrix;
            }

            Console.WriteLine($"Произведение двух матриц А and В имеет смысл только в том случае, когда число столбцов матрицы А совпадает с числом строк матрицы В ");
            return multiplMatrix;

        }

    }

}