﻿//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


byte NumberWeek(string message){        //Ввод числа
    System.Console.WriteLine(message);
    string value = Console.ReadLine();
    byte result = byte.Parse(value);
    if (result < 1 || result >7){
        throw new Exception($"Максимум можно ввести 7, а не {result}!!!");
    } else 
        return result;
}
string WeekDay(byte number){     //Проверка выходного дня
    return (number == 6 || number == 7)? "Да" : "Нет";
}
System.Console.WriteLine(WeekDay(NumberWeek("Введите порядковый номер дня недели: ")));