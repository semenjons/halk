//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1


using static System.Console;
Clear();

WriteLine("Введите положительное целое трехзначное число: ");
int d = Convert.ToInt32(ReadLine());
int nomer = d / 10 % 10; 
WriteLine(nomer); 
