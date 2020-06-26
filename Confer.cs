using System;
using System.Collections.Generic;

namespace Kyrs
{
    class Confer : IWritableObject, IReadbleObject
    {
        string title, mest, dateString;
        List<Invol> invol;

        public Confer(string v1, string v2, string v3)
        {
            this.title = v1;
            this.mest = v2;
            this.dateString = v3;
            invol = new List<Invol>();
        }
        public Confer()
        {
            invol = new List<Invol>();
        }

        static public void Con() {
            DateTime date = new DateTime();

            Console.WriteLine(" ");
            Console.Write("Введите название конференции: ");
            string title = Console.ReadLine();
            
            Console.Write("Введите место проведения: ");
            string mest = Console.ReadLine();

            Console.WriteLine("Введите дату проведения (DD.MM.YYYY): ");
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            date = new DateTime(year, month, day);
            string dateString = String.Format("{0:dd/MM/yyyy}", date);
            
        }

        public void Write(ISaveManager man)
        {
            man.WriteLine($"Название конференции: {title}");
            man.WriteLine($"Место проведения: {mest}");
            man.WriteLine($"Дата проведения: {dateString}");
            man.WriteLine($"Количество: {invol.Count}");
            foreach (Invol i in invol)
            {
                man.WriteObject(i);
            }
        }
    }
}