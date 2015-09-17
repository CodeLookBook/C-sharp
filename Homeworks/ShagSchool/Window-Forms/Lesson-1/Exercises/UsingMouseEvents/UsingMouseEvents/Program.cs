﻿//+---------------------------------------------------------------------------+
//  УСЛОВИЕ:
/*  
    Создать форму, которая бы взаимодействовала с мышь пользователя следующим
    образом:
    - при зажатии левой кнопки мыши должно выводится соответствующее
    уведомление
    - при зажатии правой кнопки  мыши должно выводится соответствующее
    увведомление
    - при зажатии колесика должно выводится соответствующее уведомление 
*/
//+---------------------------------------------------------------------------+



using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingMouseEvents
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Создание экземпляра класса MyForm и запуск работы
            //обработчика событий приложения.
            Application.Run(new MyForm());
        }
    }
}
