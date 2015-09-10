﻿
//+---------------------------------------------------------------------------+
/*  Задине 6. Создать класс для работы с двумерным массивом целых чисел.
 *  Разработать следующие члены класса:
 *  1. Поля:
 *  int [,] intArray;
 *  2. Конструктор, позволяющий создать массив размерности n×m.
 *  3. Методы, позволяющие:
 *  · ввести элементы массива с клавиатуры;
 *  · вывести элементы массива на экран;
 *  · вычислить сумму элеметов i-того столбца.
 *  4. Свойство:
 *  · позволяющее вычислить количество нулевых элементов в массиве (доступное
 *  только для чтения);
 *  · позволяющее установить значение всех элементов главной диагонали массива
 *  равное скаляру (доступное только для записи).
 *  5. Двумерный индексатор, позволяющий обращаться к соответствующему элементу
 *  массива.
 *  6. Перегрузку:
 *  · операции ++ (--): одновременно увеличивает (уменьшает) значение всех
 *  элементов массива на 1;
 *  · констант true и false: обращение к экземпляру класса дает значение true, если
 *  двумерный массив является квадратным;
 *  · операции бинарный +: сложить два массива соответсвующих размерностей;
 *  · операции преобразования класса массив в двумерный массив (и наоборот).
 *  Продемонстрировать работу класса.
 */
//+---------------------------------------------------------------------------+



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask___6
{
    class Program
    {
        static void Main(string[] args)
        {
            //ТЕСТИРОВАНИЕ ЧЛЕНОВ КЛАССА:


            //конструктор
            int n = 2;
            int m = 2;
            IntArray array1 = new IntArray(n, m);
            IntArray array2 = new IntArray(n, m);


            //Ввод элементов массива с клавиатуры
            Console.WriteLine("Введите значение массива №1 размерностю " +
            "2*2: ");
            array1.Set();


            //Ввод элементов массива с клавиатуры
            Console.WriteLine("Введите значение массива №2 размерностю " +
            "2*2: ");
            array2.Set();
            Console.WriteLine();


            //Подсчет количества нулевых элементов в массиве 
            Console.WriteLine("Количество нулевых элементов в массиве №1: ");
            Console.WriteLine(array1.Zero);
            Console.WriteLine();


            //Установка всех значений главной диагонали массива равными
            //скалеру
            Console.WriteLine("Установка всех значений главной диагонали "+
                "массива равными 0");
            array1.Scalar = 0;
            array1.Show();
            Console.WriteLine();


            //Вычисление суммы элеметов i-того столбца
            Console.WriteLine("Вычисление суммы элеметов 1-го столбца " + 
                "массива №1: ");
            Console.WriteLine(array1.Sum(0));
            Console.WriteLine();


            //Инкрементирование значений массива
            Console.WriteLine("Инкрементирование значений массива №1:");
            ++array1;
            array1.Show();
            Console.WriteLine();


            //Применение объекта класса в операторах ветвления
            Console.WriteLine("Применение объекта класса в операторах " +
                "ветвления: ");
            Console.WriteLine("(array1)?количество строк и столбцов в " +
                "массиве равно: количество строк и столбцов в массиве не " +
                "равно =>  ответ:" + Environment.NewLine + "\"{0}\"", 
                (array1)?"true":"false");
            Console.WriteLine();


            //Суммирование объектов класса IntArray
            Console.WriteLine("Суммирование объектов класса IntArray");
            Console.WriteLine("array1 + array2");
            Console.WriteLine("Result: ");
            (array1 + array2).Show();
            Console.WriteLine();


            //Преобразование класса IntArray в двумерный массив
            Console.WriteLine("Преобразование класса IntArray в двумерный " +
                "массив");
            int[,] array3 = (int[,])array1;
            for (int i = 0; i < array3.GetLength(0); ++i)
            {
                for (int z = 0; z < array3.GetLength(1); ++z)
                {
                    Console.Write("{0} ", array3[i,z]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            //Преобразование двумерного массива в класс IntArray
            Console.WriteLine("Преобразование двумерного массива в класс " +
                "IntArray");
            int[,] array4 = {{9,8},{7,6}};
            ((IntArray)array4).Show();
            Console.WriteLine();
        }
    }
}