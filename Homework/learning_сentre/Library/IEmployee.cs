using System;
using System.Collections.Generic;
using System.Text;

namespace learning_сentre
{
    public interface IEmployee
    {
        //Расчет зар. платы
        double Calc_salary();
        //Функция учить
        void Teach();
        //Вывод информации  
        void Show();
    }
}
