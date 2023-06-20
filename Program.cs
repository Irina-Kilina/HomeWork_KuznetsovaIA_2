
//Задача 10.Напишите программу, которая принимает на вход трёхзначное число и 
//на выходе показывает вторую цифру этого числа.

/*Console.WriteLine("Введите ваше число: ");
int num = Convert.ToInt32(Console.ReadLine());
    int num1 = num/100;
    int num2 = num%100;
    int num3 = num%10;
    int num4 = (num2-num3)/10;
    
    Console.WriteLine ("result is - " + num4);
    */

//Задача 13. Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.

/*Console.WriteLine("Введите ваше число: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = num%10;
int result2 = (num/10)%10;
int result3 = (num/100)%10;

    if (num < 1000)
    {
    Console.WriteLine("Your number is " + result);
    }
    if (num < 10000 && num > 999)
    {
        Console.WriteLine("Your number is " + result2);
    }
    if (num < 100000 && num > 9999)
    {
        Console.WriteLine("Your number is " + result3); 
    }
    if (num < 100)
    {
        Console.WriteLine("Третьей цифры нет");
    }
*/
//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

/*Console.WriteLine("Введите ваше число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 5 && num <= 7)
{
    Console.WriteLine("Да, выходной");
}
else
{
    Console.WriteLine("нет, не выходной");
}
*/
