using Tyuiu.AlekseevaVA.Sprint2.Task6.V7.Lib;

namespace Tyuiu.AlekseevaVA.Sprint2.Task6.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            

            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Алексеева В. А. | ИИПб-25-1 ";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #7                                                             *");
            Console.WriteLine("* Выполнила: Алексеева В. А. | ИИПб-25-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* С начала 1990 года по некоторый день прошло n месяцев и 2 дня.          *");
            Console.WriteLine("* Определить название месяца (январь, февраль и т. п.) этого дня.         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение переменной StartYear, n");
            int startYear, n;
            startYear = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            var res = ds.FindMonthName(startYear, n);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
        
