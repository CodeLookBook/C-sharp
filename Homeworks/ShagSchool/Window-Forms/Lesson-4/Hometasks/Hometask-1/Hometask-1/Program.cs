﻿//+-------------------------------------------------------------------------------------+
//УСЛОВИЕ ЗАДАЧИ:
/*
1. Разработать текстовый редактор, организовать открытие \ сохранение
текстовых файлов.
а. В панели инструментов расположить кнопки ( Открыть, сохранить, 
новый документ, копировать, вырезать, вставить, отменить, кнопка
настройки редактора (цвет шрифта, цвет фона, ШРИФт)). 
б. Меню должно дублировать панель инструментов (+ выделить всё, + 
сохранить как).
в. В Заголовке окна находиться полный путь к файлу.
г. Организовать контекстное меню для окна редактора ( Копировать, 
Вырезать, Вставить, Отменить).
*/
//+-------------------------------------------------------------------------------------+

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hometask_1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.FormMain());
        }
    }
}
