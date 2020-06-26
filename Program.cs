using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kyrs
{
    class Program
    {
        static void Main(string[] args)
        {
            Confer t = new Confer();
            Invol t1 = new Invol();
            Scientist t2 = new Scientist();
            int k = 0;

            Console.Write("Введите количество конференций: ");
            int n = int.Parse(Console.ReadLine());

            while (k < n) 
            {
                Confer.Con();

                Console.Write("Введите количество участников: ");
                int n1 = int.Parse(Console.ReadLine());
                int k1 = 0;

                while (k1 < n1) 
                {
                    Invol.inv();
                    Scientist.scien();
                    k1++;
                }
                k++;
            }

            List<Scientist> scien = new List<Scientist>
            {
                new Scientist("Серов Артем Александрович", "Доктор наук", "Россия", "Ростов-на-Дону", "РКСИ"),
                new Scientist("Дроздов Даниил Сергеевич", "Кандидат наук", "Россия", "Ростов-на-Дону", "РКСИ")
            };

            SaveManager SMComplex = new SaveManager("Ученый.txt");
            foreach (var x in scien)
            {
                SMComplex.WriteObject(x);
            }
            Console.WriteLine("\n");
            //
            List<Invol> invol = new List<Invol>
            {
                new Invol("Доклад", "Экология", "Да", scien[0]),
                new Invol("Выступление", "Окружающая среда", "Нет", scien[1])
            };

            SaveManager SMComp = new SaveManager("Участие.txt");
            foreach (var x in invol)
            {
                SMComp.WriteObject(x);
            }
            Console.WriteLine("\n");
            //
            List<Confer> confer = new List<Confer>
            {
                new Confer("Экология Будущего", "Москва", "01.09.2020"),
                new Confer("Окружающая Среда", "Ростов-на-Дону", "12.10.2021")
            };

            SaveManager SMCom = new SaveManager("Конференция.txt");
            foreach (var x in confer)
            {
                SMCom.WriteObject(x);
            }
            Console.WriteLine("\n");     
        }
    }
}