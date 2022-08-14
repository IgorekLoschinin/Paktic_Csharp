using System;


namespace Homework4 {

    class Task25 {

        public void customPow(int a, int b) {               

            int pow = 1;                
            for (int i = 0; i < b; i++) {
                pow *= a;
            }

            Console.WriteLine($"Number {a} to the power {b} - {a}^{b} = {pow};");
            
        }

        public void customPowV2(int a, int b) {               

            double pow = Math.Pow(a, b);

            Console.WriteLine($"Number {a} to the power {b} - {a}^{b} = {pow};");
            
        }

    }

}