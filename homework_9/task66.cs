namespace Homework_9 {

    class Task66 {

        public void RunTask() {

            Console.WriteLine($"Введите количество чисел М: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите количество чисел N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n}:");
            Console.WriteLine($"Sum = {SumNaturalNum(m, n)}");

        }

        public int SumNaturalNum(int m, int n) {

            Task64 objNatElem = new Task64();

            int sumSequenceOfnumbers = 0;

            foreach (int itemSeq in objNatElem.NaturalNum(m, n)) {
                sumSequenceOfnumbers = sumSequenceOfnumbers + itemSeq;
            }

            return sumSequenceOfnumbers;
            
        }

    }

}