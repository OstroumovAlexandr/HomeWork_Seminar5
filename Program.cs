// HomeWork Seminar 5
// Task 1
/*
Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine()!);
if((number<100) || (number>999)) {
    Console.WriteLine($"Надо было ввести число в диапазоне от 100 до 999: ");
}
   else{Console.WriteLine($"В числе {number} вторая цифра это {(number / 10)%10}");
   }

*/





// Task 2
/*
Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
if((number<100)) {
    Console.WriteLine($"В числе {number} увы, но третьей цифры нет");
}
   else
    if ((number >= 100) && (number <= 999)) {
        Console.WriteLine($"В числе {number} третья цифра это {number % 10}");
   }
    if ((number >= 1000) && (number <= 9999)) {
        Console.WriteLine($"В числе {number} третья цифра это {(number / 10) % 10}");
   }
   if ((number >= 10000) && (number <= 99999)) {
        Console.WriteLine($"В числе {number} третья цифра это {(number / 100) % 10}");
   }
   if (number == 100000) {
        Console.WriteLine($"В числе {number} третья цифра это 0");
   }

   */




   // Task 4
/*
Console.Clear();
Console.WriteLine("Введите число, обозначающее номер дня недели: ");
int number = int.Parse(Console.ReadLine()!);
if((number<1) || (number>7)) {
    Console.WriteLine($"В неделе всего 7 дней!!! ");
}
   else
    if((number == 6) || (number ==7)){
        Console.WriteLine($"УРАААА!!!!      Это выходной день.");
   }
   else {
    Console.WriteLine($"Это рабочий день.");
    }

    */