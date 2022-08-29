int Numberss(string message){     //Ввод трехзначного числа
    System.Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = int.Parse(value);
    if (result < 100 || result > 999){
        throw new Exception("Нужно трехзначное");
    } else 
        return result;
}
int Number_2( int result){      //Поиск второй цифры числа
    int num_2 = result/10 % 10;
    return num_2;
}

System.Console.WriteLine(Number_2(Numberss("Введите число: ")));
