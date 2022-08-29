//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int Number_3(string message){     //Ввод числа
    System.Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = int.Parse(value);
    return result;
}
string FindNumber3(int number){     //Поиск третьей цифры числа
    int x=number;
    if (number < 100)
        return "Третьей цифры нет!";
    else {
        while (number >1000){
            number = number *10 /100;
        }
        x = number % 10;
        return x.ToString();
    }
}

System.Console.WriteLine(FindNumber3(Number_3("Введите число: ")));