
bool Task_2 = false;
bool Task_4 = false;
bool Task_6 = false;
bool Task_8 = true;

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
    int a = 5;
    int b = 44;
    int c = 78;

    if (a > b) {
        Console.WriteLine(a);
    } else if (b > c) {
        Console.WriteLine(b);
    } else {
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
