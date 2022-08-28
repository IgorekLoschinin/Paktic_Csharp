namespace Homework_8 {

    class Task60: CommonFunc {

        public void runTask () {

            Console.WriteLine($"Введите количество чисел М: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите количество чисел N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите количество чисел K: ");

            int k = Convert.ToInt32(Console.ReadLine());
            int[,,] myArr3D = Create3DArrayInt(m, n, k);
            Print3DArray(myArr3D);

        }

        public double[,,] Create3DArrayDouble(int m, int n, int k) {
            
            double[,,] arr3D = new double[m, n, k];
            Random randomObj = new Random();

            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    for (int l = 0; l < k; l++) {
                        arr3D[i, j, l] = Math.Round(randomObj.NextDouble(), 2);
                    }
                }
            }

            return arr3D;

        } 

        public int[,,] Create3DArrayInt(int m, int n, int k) {
            
            int[,,] arr3D = new int[m, n, k];
            Random randomObj = new Random();

            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    for (int l = 0; l < k; l++) {
                        arr3D[i, j, l] = randomObj.Next(0, 100);
                    }
                }
            }

            return arr3D;

        } 

    }

}