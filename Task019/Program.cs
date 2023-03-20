// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.WriteLine("Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом");
Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (9999 < number && number < 100000) 
{
    string str = Convert.ToString(number);
    int number0 = Convert.ToInt32(str[0]);
    int number1 = Convert.ToInt32(str[1]);
    int number2 = Convert.ToInt32(str[2]);
    int number3 = Convert.ToInt32(str[3]);
    int number4 = Convert.ToInt32(str[4]);
    string result = number0 == number4 ? result = "Да" : result = "Нет";
    result = number1 == number3 ? result = "Да" : result = "Нет";
    Console.WriteLine(result);
}
else Console.WriteLine("Число не является пятизначным!");