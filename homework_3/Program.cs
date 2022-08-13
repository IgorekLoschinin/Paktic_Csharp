// Урок 3. Массивы и функции в программировании

namespace homework3 {
    
    class homework {

        static void Main(string[] args) {

            Console.WriteLine("--------===== Decision Task 19 =====--------\n");
            Console.WriteLine("\t--------===== isPolindromIntNumV =====--------\n");       
            Task19 task19 = new Task19();
            task19.isPolindromIntNum(14212);
            task19.isPolindromIntNum(12821);
            task19.isPolindromIntNum(23432);            
            Console.WriteLine("\t--------===== isPolindromIntNumV1 =====--------\n");  
            task19.isPolindromIntNumV1(14212);
            task19.isPolindromIntNumV1(12821);
            task19.isPolindromIntNumV1(23432);
            task19.isPolindromIntNumV1(12767536721);
            Console.WriteLine("\t--------===== isPolindromIntNumV2 =====--------\n");
            task19.isPolindromIntNumV2(14212);
            task19.isPolindromIntNumV2(12821);
            task19.isPolindromIntNumV2(23432);
            task19.isPolindromIntNumV2(12767536721);  


            Console.WriteLine("\n--------===== Decision Task 21 =====--------\n"); 
            Point1 pointA1 = new Point1(3,6,8);
            Point2 pointB1 = new Point2(2,1,-7);
            Task21 task211 = new Task21();
            task211.distancePoint3D(pointA1, pointB1);

            Point1 pointA2 = new Point1(7,-5, 0);
            Point2 pointB2 = new Point2(1,-1,9);
            Task21 task212 = new Task21();
            task212.distancePoint3D(pointA2, pointB2);

            
            Console.WriteLine("\n--------===== Decision Task 21 =====--------\n"); 
            Task23 task23 = new Task23();
            task23.cubeNum(3);
            task23.cubeNum(5);
            task23.cubeNum(7);
            task23.cubeNum(9);

            Console.WriteLine("\n--------===== END =====--------\n");

        }

    }

}