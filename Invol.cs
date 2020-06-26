using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kyrs
{
    class Invol : IWritableObject, IReadbleObject
    {
        string invo, theme, l;
        Scientist person;

        public Invol(string v1, string v2, string v3, Scientist p)
        {
            this.invo = v1;
            this.theme = v2;
            this.l = v3;
            person = p;
        }
        public Invol()
        {
        }

        static public void inv()
        {
            Console.WriteLine(" ");
            Console.Write("Тип участия: ");
            string invo = Console.ReadLine();
            Invol.proverka(invo);

            Console.Write("Тема доклада: ");
            string theme = Console.ReadLine();
            Invol.proverka(theme);

            Console.Write("Публикация(Да-1/Нет-0): ");
            int a = int.Parse(Console.ReadLine());

            string l = (a == 1) ? ("Да") : ("Нет");
        }

        static public void proverka(string s)
        {
            while (String.IsNullOrWhiteSpace(s))
            {
                Console.WriteLine("Error! Введите снова:");
                string inv = Console.ReadLine();
                s = inv;
            }
        }

        public void Write(ISaveManager man)
        {
            man.WriteLine($"Тип участия: {invo}");
            man.WriteLine($"Тема доклада: {theme}");
            man.WriteLine($"Публикация: {l}");
            man.WriteObject(person);
        }
    }
}