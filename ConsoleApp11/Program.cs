using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int grandmother;  //Кол-во бабушек заданые пользователем
            int time = 10;    //Кол-во минут на 1 бабушку
            int hour;         //Кол-во часов
            int minutes;      //Кол-во минут
            int timeWait;     //Итоговое время ожидания
        
            Console.Write("Введите кол-во старушек: ");
            grandmother = Convert.ToInt32(Console.ReadLine());

            timeWait = grandmother * time;
            hour = timeWait / 60;
            minutes = timeWait % 60;

            Console.WriteLine("Вы должны отстоять в очереди " + hour + " часа и " + minutes + " минут.");
        }
    }
}
