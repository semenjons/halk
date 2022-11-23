 //Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

using static System.Console; 
Clear();

WriteLine("Введите число");
int n = Convert.ToInt32(ReadLine()); 
int nnomer(int d)
        {
            int result = -1; 
            {
                while (d > 999) 
                {
                    d = d / 10; 
                }
                result = d % 10; 
            }
            return result; 
        }
if (nnomer(n) == -1) 
Console.WriteLine("Третьей цифры нет");
else 
Console.WriteLine($"Третья цифра это: {nnomer(n)}"); 

