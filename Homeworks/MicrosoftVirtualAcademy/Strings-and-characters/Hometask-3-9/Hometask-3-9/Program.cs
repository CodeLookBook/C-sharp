﻿//+---------------------------------------------------------------------------+
/*  УСЛОВИЕ ЗАДАЧИ:
 *  Дана строка, в которой содержится осмысленное текстовое сообщение. Слова 
 *  сообщения разделяются пробелами и знаками препинания. Вывести слова 
 *  сообщения в алфавитном порядке. При решении задач из данного пункта 
 *  использовать тип string или StringBuilder. Свой выбор обосновать.
 */
//+---------------------------------------------------------------------------+



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT_3_9
{
    class Program
    {
        static void Main()
        {
            //ОБЪЯВЛЕНИЕ ПЕРЕМЕННЫХ
            //+---------------------------------------------------------------+
            string text = String.Empty;     //текстовая строка



            //ВВОД ДАННЫХ
            //+---------------------------------------------------------------+

            //::ввод пользователем строки произвольного содержания
            Console.Write("Input any string" + Environment.NewLine + "--> ");
            text = Console.ReadLine();



            //РЕШЕНИЕ ЗАДАЧИ
            //+---------------------------------------------------------------+
            
            //::сортировка слов в текстовой строке и вывол полеченного 
            //  результата на экран
            Console.WriteLine(Environment.NewLine + "RESULT: " +
                Environment.NewLine + "Sorted string --> {0}",
                Sort(text));

        }



        //ОБЪЯВЛЕНИЕ МЕТОДОВ
        //+-------------------------------------------------------------------+

        /// <summary>сортировка слов в текстовой строке</summary>
        /// <param name="text">произвольная текстовая строка подлежащая 
        /// редактированию</param>
        /// <returns>строка символов содержащая отсортированную 
        /// последовательность слов</returns>
        public static string Sort(String text)
        {
            string[] subStrings = text.Split();
            Array.Sort(subStrings);
            return string.Join(" ", subStrings);
        }
 
    }
}