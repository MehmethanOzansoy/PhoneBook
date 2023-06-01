using System;
using System.Collections.Generic;

namespace Telefon // Note: actual namespace depends on the project name.
{
    public class AddNumbers
    {

        public string name;
        public long number;
        // public string Name { get => name; set => name = value; }
        // public long Number { get => number; set => number = value; }

        public AddNumbers()
        {

        }

        public void createNewNumbers(Dictionary<string, long> ekle)
        {
            System.Console.Write("Lütfen isim ve soyisimi giriniz : ");
            name = Console.ReadLine();
            System.Console.Write("Lütfen telefon numarası giriniz : ");
            number = long.Parse(Console.ReadLine());
            ekle.Add(name, number);
            System.Console.WriteLine("Numaranız Eklendi");
        }

    }
}