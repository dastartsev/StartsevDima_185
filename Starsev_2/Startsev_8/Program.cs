using System;

/*
Дисциплина: "Программирование"
Группа: 185ПИ/1
Студент: Старцев Дмитрий Алексеевич
Вариант: 4
Задача: описать геометрическую прогрессию

Дата: 2018.11.21
*/

namespace Startsev_8
{
    class Program
    {
        static void Main(string[] args)
        {
            GeometricSequence defaultSequence = new GeometricSequence();
            Random rnd = new Random();
            GeometricSequence[] arr = new GeometricSequence[rnd.Next(1,6)];
            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = new GeometricSequence(3.99 - rnd.Next(1, 9), 3.99 - rnd.Next(1, 9));
            }
            Console.WriteLine(arr[0].InstanseInfo());
        }
    }
}
