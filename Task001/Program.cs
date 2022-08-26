// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.WriteLine("Введите 5-ти значное число: ");
string number = Console.ReadLine();

if (number.Length == 5)
{
    Palindrome(number);
}
else
{
    System.Console.WriteLine("Введите верное число!");
}
void Palindrome(string number)
{
    if (number[0] == number[4] || number[1] == number[3])
    System.Console.WriteLine($"{number} → да");
    else
    System.Console.WriteLine($"{number} → нет");
}