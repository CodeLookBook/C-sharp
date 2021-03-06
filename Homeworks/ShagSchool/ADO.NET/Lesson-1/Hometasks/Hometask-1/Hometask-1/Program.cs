﻿//+---------------------------------------------------------------------------+
//УСЛОВИЕ ЗАДАЧИ:
/*
Создайте базу данных Продажи (в качестве формата базы данных можно 
использовать Microsoft Access). Создайте внутри базы данных три таб-
лицы:

a. Таблица Покупатели. Столбцы: идентификатор, имя, фами-
лия;
b. Таблица Продавцы. Столбцы: идентификатор, имя, фамилия;
c. Таблица Продажи. Столбцы: идентификатор сделки, иденти-
фикатор покупателя, идентификатор продавца, сумма сделки, 
дата сделки.

Наполните таблицы данными, задайте правила ссылочной целостности. 
Реализуйте WinForms приложение, позволяющее пользователю выбрать 
название таблицы из базы данных sample.mdb (например, с помощью 
выпадающего списка), в результате выбора таблицы приложение должно 
отображать содержимое данной таблицы на форму.
*/
//+---------------------------------------------------------------------------+



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
            Application.Run(new FormMain());
        }
    }
}
