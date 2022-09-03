

namespace Homework_9 {

    class Task64 {

        public void RunTask() {

            Console.WriteLine($"Введите количество чисел М: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите количество чисел N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Все натуральные числа в промежутке от {m} до {n}:");
            Console.WriteLine($"{string.Join(", ", NaturalNum(m , n))}");

        }

        public List<int> NaturalNum(int m, int n) {
            List<int> sequenceOfnumbers = new List<int>();
            
            if (m == 0) {
                Console.WriteLine("Нуль не является натуральным числом!");                
                return sequenceOfnumbers;                             
            }        
            
            for (int i = m; i <= n; i++) {
                sequenceOfnumbers.Add(i);
            }

            return sequenceOfnumbers;
            
        }

    }

}