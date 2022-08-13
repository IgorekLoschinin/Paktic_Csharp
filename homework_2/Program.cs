// Урок 2. Массивы и функции в программировании 

bool Task_10 = false;
bool Task_13 = false;
bool Task_15 = true;

void SecondNumber(int chiclo) {

    // Проверка, что число трехзначное
    if (chiclo >= 100 && chiclo < 1000) {
        Console.WriteLine((chiclo / 10) % 10);
    } else {
        Console.WriteLine("Число не является трехзначным!");
    }
    
}

void ThirdNumber(int chiclo) {

    if (chiclo < 100) {        
        Console.WriteLine("третьей цифры нет");

    } else if (chiclo >= 100 && chiclo < 1000) {        
        Console.WriteLine(chiclo % 10);

    } else if (chiclo >= 1000 && chiclo < 100000) {        
        Console.WriteLine((chiclo / 100) % 10);
    }

}

void dayWeek(int numDay) {
    switch (numDay)     
    {
    case 6:
        Console.WriteLine("YES");
        return;
    case 7:
        Console.WriteLine("YES");
        return;
    default:
        Console.WriteLine("NO");
        return;
    }
}


if (Task_10) {

    int[] numArray = {456, 782, 918, 76576};
    
    foreach (int item in numArray) {
        SecondNumber(item);  
    }    

}

if (Task_13) {

    int[] numArray = {645, 78, 32679};

    foreach (int item in numArray) {
        ThirdNumber(item);  
    }   
    
}

if (Task_15) {

    int[] numArray = {6, 7, 1};

    foreach (int item in numArray) {
        dayWeek(item);  
    }

}


