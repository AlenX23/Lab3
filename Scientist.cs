using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kyrs
{
    class Scientist : IWritableObject, IReadbleObject
    {
        string name, s, country, city, organization;

        public Scientist(string v1, string v2, string v3, string v4, string v5)
        {
            this.name = v1;
            this.s = v2;
            this.country = v3;
            this.city = v4;
            this.organization = v5;
        }
        public Scientist()
        {
        }

        static public void scien()
        {
            Console.Write("Введите Фамилию Имя Отчество : ");
            string name = Console.ReadLine();

            Console.Write("Выберите учёную степень(Кандидат наук/Доктор наук): ");
            string s = Console.ReadLine();

            Console.Write("Введите страну: ");
            string country = Console.ReadLine();

            Console.Write("Введите город: ");
            string city = Console.ReadLine();

            Console.Write("Введите название организации, к которой прикреплен ученый: ");
            string organization = Console.ReadLine();
        }

        public void Write(ISaveManager man)
        {
            man.WriteLine($"Фамилию Имя Отчество: {name}");
            man.WriteLine($"Ученая степень: {s}");
            man.WriteLine($"Страна: {country}");
            man.WriteLine($"Город: {city}");
            man.WriteLine($"Название организации: {organization}");
        }
    }
}