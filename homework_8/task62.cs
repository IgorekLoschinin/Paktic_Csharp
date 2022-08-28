namespace Homework_8 {

    class Task62: CommonFunc {

        public void runTask () {

            Console.WriteLine($"Введите количество чисел N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] spirArr = SpiralFillArray(n);
            Print2DArray(spirArr);

        }

        public int[,] SpiralFillArray (int N) {

            int[,] spirArr = new int[N, N];                        
            
            int Ibeg = 0, Ifin = 0;  // Точка, с которой начинается движение по часовой стрелке
            int Jbeg = 0, Jfin = 0;  // Точка, на которой заканчивается круг
            
            int i = 0;
            int j = 0;

            for (int k = 1; k <= Math.Pow(N, 2); k++) {
                spirArr[i, j] = k;

                if (i == Ibeg && j < N - Jfin - 1) {                 // Движение вправо
                    j++;
                } else if (j == N - Jfin - 1 && i < N - Ifin - 1) {  // Движение вниз
                    i++;
                } else if (i == N - Ifin - 1 && j > Jbeg) {          // Движение влево
                    j--;
                } else {                                             // Движение вверх
                    i--;
                }

                // Когда движение по кругу замыкается, то есть (i, j = 1, 0) - Хвост, 
                // тогда смещается точка начала и конца, и начивается следующий проход по кругу                
                if ((i == Ibeg + 1) && (j == Jbeg) && (Jbeg != N - Jfin - 1)) {
                    Ibeg++;
                    Ifin++;
                    Jbeg++;
                    Jfin++;
                }
            }
             
            return spirArr;
        }

    }

}