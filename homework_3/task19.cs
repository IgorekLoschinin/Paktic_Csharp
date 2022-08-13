using System;


namespace homework3 {

    class Task19 {

        public void isPolindromIntNum(int num) {
            
            int number = num;
            int copy_number = num;
            int result = 0;

            while (number != 0) {
                int digit = number % 10;
                result = result*10 + digit;

                number /= 10;
            }

            Console.WriteLine("Result is: ", result);
            if (result==copy_number) {
                Console.WriteLine("Palindrome!");
            } else {
                Console.WriteLine("Not a Palindrome!");
            }                

        }

        public void isPolindromIntNumV1(long num) {
            
            string number = Convert.ToString(num);

            char[] lst_num = Convert.ToString(num).ToCharArray();
            Array.Reverse(lst_num);

            string result = new string(lst_num);

            Console.WriteLine($"Result is: {result}");
            if (result == number) {
                Console.WriteLine("Palindrome!");
            } else {
                Console.WriteLine("Not a Palindrome!");
            } 

        }

        public void isPolindromIntNumV2(long num) {
                        
            List<char> number = Convert.ToString(num).ToList();

            int len_num = Convert.ToString(num).Length;
            int part_len_str = Convert.ToString(num).Length / 2 + 1;

            for (int i=0; i<part_len_str; i++) {
                if (number[i] != number[len_num-1-i]) {
                    Console.WriteLine("Not a Palindrome!");
                    return;
                }
            }

            Console.WriteLine("Palindrome!");

        }
    }

}