using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AlekseevaVA.Sprint2.Task5.V10.Lib
{
    public class DataService : ISprint2Task5V10
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            switch (n)
            {
                case 1: // Если первый день месяца
                    switch (m)
                    {
                        case 1: // Если январь - переход на предыдущий год
                            g--; m = 12; n = 31;
                            break;
                        default: // Другие месяцы - переход на предыдущий месяц
                            m--;
                            switch (m) // Определяем количество дней в предыдущем месяце
                            {
                                case 2: n = 28; break;      // Февраль
                                case 4: case 6: case 9: case 11: n = 30; break; // 30-дневные месяцы
                                default: n = 31; break;     // 31-дневные месяцы
                            }
                            break;
                    }
                    break;
                default: // Обычный день - просто уменьшаем день
                    n--;
                    break;
            }

            return $"{(n < 10 ? "0" + n : n)}.{(m < 10 ? "0" + m : m)}.{g}";
        }
    }

      
}
