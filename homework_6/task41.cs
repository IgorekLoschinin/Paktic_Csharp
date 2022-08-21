

namespace Homework_6 {

    class Task41 {

        public int CountNumGreaterZero () {

            int size = Convert.ToInt32(Console.ReadLine());
            int count = 0;
                        
            if (size <= 0) {
                Console.WriteLine($"Введенное количество чисел М ({size}) не верно! Повторите:");
                return CountNumGreaterZero();                
            }

            
            int i = 0;
            while (i < size) {
                Console.WriteLine($"Число arr[{i}]: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num > 0) {count++;}

                i++;
            }

            return count;
        }

    }

}