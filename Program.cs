using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int point = 0;

            Console.WriteLine("Профессор лёг спать в 8 часов," +
                " а встал в 9 часов. Сколько часов проспал профессор?");

            int an1 = Convert.ToInt32(Console.ReadLine());
            point = an1 == 1 ? point + 1 : point + 0;


            Console.WriteLine("На двух руках 10 пальцев. Сколько пальцев на 10?");

            int an2 = Convert.ToInt32(Console.ReadLine());
            point = an2 == 50 ? point + 1 : point + 0;


            Console.WriteLine("Сколько цифр в дюжине?");

            int an3 = Convert.ToInt32(Console.ReadLine());
            point = an3 == 2 ? point + 1 : point + 0;

            Console.WriteLine("Сколько нужно сделать запилов," +
                " чтобы распилить бревно на 12 частей??");

            int an4 = Convert.ToInt32(Console.ReadLine());
            point = an4 == 11 ? point + 1 : point + 0;


            Console.WriteLine("Врач сделал три укола в интервале 30 минут." +
                " Сколько времени он затратил?");

            int an5 = Convert.ToInt32(Console.ReadLine());
            point = an5 == 30 ? point + 1 : point + 0;

            Console.WriteLine("Сколько цифр 9 в интервале 1 100?");

            int an6 = Convert.ToInt32(Console.ReadLine());
            point = an6 == 1 ? point + 1 : point + 0;

            Console.WriteLine("У пастуха было 30 овец. " +
                "Все кроме одной разбежались. Сколько овец осталось?");

            int an7 = Convert.ToInt32(Console.ReadLine());
            point = an7 == 1 ? point + 1 : point + 0;

            if (point == 7)
            {
                Console.WriteLine("Гений");
            }
            else if(point == 6)
            {
                Console.WriteLine("Эрудит");
            }
            else if (point == 5)
            {
                Console.WriteLine("Нормальный");
            }
            else if (point == 4)
            {
                Console.WriteLine("Способности средние");
            }
            else if (point == 3)
            {
                Console.WriteLine("Способности ниже среднего");
            }
            else if (point <= 2)
            {
                Console.WriteLine("Вам надо отдохнуть!");
            }

        }
    }
}
