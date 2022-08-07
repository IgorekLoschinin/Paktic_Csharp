
bool Task_2 = false;
bool Task_4 = true;
bool Task_6 = false;
bool Task_8 = false;

if (Task_2) {
    int a = 5;
    int b = 7;

    if (a > b) {
        Console.WriteLine(a);
    } else {
        Console.WriteLine(b);
    }
}

if (Task_4) {
    int a = 0;
    int b = 1;
    int c = 2;

    if (a > b && a > c) {
        Console.WriteLine(a);
    } else if (b > c && b > a) {
        Console.WriteLine(b);
    } else if (c > a && c > b){
        Console.WriteLine(c);
    }
}

if (Task_6) {
    int a = -3;

    if (a%2 == 0) {
        Console.WriteLine("Yes");
    } else {
        Console.WriteLine("No");
    }
}

if (Task_8) {
    int N = 8;

    int i = 1;
    while (i <= N) {

        if (i%2 == 0) {
            Console.Write(i + " ");
        }

        i++;
    }
}
