//Напишите программу, которая на вход принимает трехзначное число, и на выходе показывает вторую цифру этого числа.
/*
Console.WriteLine("Введите число:  ");
int number = int.Parse(Console.ReadLine()!);
int num2 = (number/10)%10;
if(number/100 == 0 || number/100 >=10)
{
    Console.WriteLine("Ваше число не трехзначное");
}
else
{
    Console.WriteLine(num2);
}*/

//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
/*
Console.WriteLine("Введите число от 1 до 100000 включительно:  ");
int number = int.Parse(Console.ReadLine()!);
if(number/100 == 0 ) //условие для двухзначного числа
{
    Console.WriteLine("В вашем числе нет третьей цифры");
}
else
{
    if(number/1000 == 0) //условие для трехзначного числа
    {
        int num1 = number%10;
        Console.WriteLine(num1);
    }
    else
    {
        if(number/10000 == 0) //условие для четырехзначного числа
        {
            int num2 = number/10%10;
            Console.WriteLine(num2);
        }
        else
        {
            if(number/100000 == 0) //условие для пятизначного числа
            {
                int num3 = number/100%10;
                Console.WriteLine(num3);
            }
            else
            {
                int num4 = number/1000%10;
                Console.WriteLine(num4);
            }
        }
    }
}
*/

//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
/*
Console.WriteLine("Введите номер дня недели:  ");
int number = int.Parse(Console.ReadLine()!);
if(number < 1 || number > 7)
{
    Console.WriteLine("Такого номера дня недели не существует");
}
else
{
    if(number >= 1 && number <=5)
    {
        Console.WriteLine("Этот день не выходной");
    }
    else
    {
        Console.WriteLine("Этот день выходной");
    }
}
*/