// Задача 2: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.


int Delete_2number(){    
    int number = new Random().Next(100,1000);
    System.Console.WriteLine(number);
    int x = number % 10;
    return number/100 *10 + x;    
}
System.Console.WriteLine(Delete_2number());
