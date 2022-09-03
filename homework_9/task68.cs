
namespace Homework_9 {

    class Task68 {

        public void RunTask() {

            Console.WriteLine($"Введите количество чисел М: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите количество чисел N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n}:");
            Console.WriteLine($"A({m}, {n}) = {AckermanFun(m, n)}");

        }

        public int AckermanFun(int m , int n) {

            if (m == 0) {

                return n + 1;

            } else if (m > 0 && n == 0) {

                return AckermanFun(m - 1, 1);

            } else if (m > 0 && n > 0) {

                return AckermanFun(m - 1, AckermanFun(m, n -1));

            }

            return 0;
            
        }

    }

}