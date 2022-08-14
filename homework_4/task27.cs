using System;


namespace Homework4 {

    class Task27 {

        public void SumDigitINNumber (int num) {               

            int sum = 0;
            int number = num;           
            
            while (number > 0) {
                sum += number % 10;                
                number /= 10;
            }

            Console.WriteLine($"Sum of number in {num} = {sum}");
        }

        public void SumDigitINNumberV2 (int num) {

            char[] number = Convert.ToString(num).ToCharArray();

            int sum = 0;
            foreach (char i in number) {
                sum += Convert.ToInt32(Convert.ToString(i));                
            }

            Console.WriteLine($"Sum of number in {num} = {sum}");
        }

    }

}