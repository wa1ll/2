using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTaskClassLibrary
{
    public class Geometry
    {
        public string Func(List<double> l)
        {
            double min1, min2, max1, max2;
            min1 = 30000;
            min2 = min1;
            max1 = -30000;
            max2 = max1;


            string ret = "";// то, что будет возвращать
            int listCount = l.Count;
            if (listCount == 0) // ... (пусто)
            {
                return "Последовательность пуста";
            }
            else if (l[0] == 0 && listCount == 1) // когда просто 0
            {
                return "Последовательность пуста";
            }
            else if (l[1] == 0 && listCount == 2)
            {
                return "Единичная последовательность";
            }
            else
            if (listCount != 0) // длинна массива не 0
            {
                if (listCount != 1) // длинна массива не 1
                {
                    for (int i = 0; i < l.Count; i++) // основна
                    {
                        if (l[i] != 0)
                        {
                            if (l[i] < min1)
                            {
                                min1 = l[i];
                            }
                            if (l[i] > max1)
                            {
                                max1 = l[i];
                            }
                        }
                        else break;
                    }
                    l.Remove(min1);
                    l.Remove(max1);

                    for (int i = 0; i < l.Count; i++)
                    {
                        if (l[i] != 0)
                        {
                            if (l[i] < min2)
                            {
                                min2 = l[i];
                            }
                            if (l[i] > max2)
                            {
                                max2 = l[i];
                            }
                        }
                        else break;
                    }

                    if (listCount == 3) // длинна массива 3 (учитывая 0)
                    {
                        ret += "Введена максимально короткая последовательность. ";
                        if (max1 == min1) // 1 1 0 и т.п.
                        {
                            ret += "В последовательности отсутствуют минимальные и максимальные элементы";
                        }
                        else
                        {
                            ret += $"Минимальный элемент равен { min1 }. Максимальный элемент равен { max1 }";
                        }
                    }
                    else
                    {
                        if (max1 == min1) // тоже самое что выше, но длинна массива >3
                        {
                            ret += "В последовательности отсутствуют минимальные и максимальные элементы";
                        }
                        else
                        {
                            ret += $"Наибольших: { max2 + max1 }" + "; " + $"Наименьших: { min2 + min1}";
                        }
                    }
                }
                else
                {
                    ret += "Единичная последовательность";
                }
            }
            else
            {
                ret += "Последовательность пуста";
            }
            return ret;
        }
    }
}