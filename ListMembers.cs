using System;
using System.Collections.Generic;
using System.Linq;

namespace Telefon // Note: actual namespace depends on the project name.
{

    class TelefonRehberi
    {
        public TelefonRehberi()
        {

        }

        public void getGuide(Dictionary<string, long> dic)
        {
            System.Console.WriteLine("Telefon Rehberi");
            System.Console.WriteLine(" ********************************************** ");
            System.Console.WriteLine();

            foreach (var item in dic)
            {
                System.Console.Write("isim Soyisim        : " + item.Key);
                System.Console.WriteLine();
                System.Console.Write("Telefon Numarası    : " + item.Value);
                System.Console.WriteLine();
                System.Console.WriteLine("-");

            }
        }


        public void getUser(Dictionary<string, long> dic)
        {

            System.Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            System.Console.WriteLine("**********************************************");
            System.Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            System.Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            System.Console.Write("Seçiminiz:  ");
            int n = int.Parse(Console.ReadLine());

            if (n == 1)
            {
                System.Console.Write("İsim ve soyisim'i giriniz     : ");
                string name = Console.ReadLine();

                if (dic.ContainsKey(name))
                {
                    var uygunİsim = dic.FirstOrDefault(kvp => kvp.Key == name);
                    System.Console.WriteLine("---------------------------------------");
                    System.Console.WriteLine("İsim Soyisim          :" + uygunİsim.Key);
                    System.Console.WriteLine("Telefon Numarası      :" + uygunİsim.Value);
                    System.Console.WriteLine("---------------------------------------");
                }
            }
            else if (n == 2)
            {
                System.Console.Write("Telefon numarsını giriniz     : ");
                long l = Convert.ToInt64(Console.ReadLine());

                if (dic.ContainsValue(l))
                {
                    var uygunNumara = dic.Where(kvp => kvp.Value == l);

                    foreach (var item in uygunNumara)
                    {
                        System.Console.WriteLine("---------------------------------------");
                        System.Console.WriteLine("İsim Soyisim          :" + item.Key);
                        System.Console.WriteLine("Telefon Numarası      :" + item.Value);
                        System.Console.WriteLine("---------------------------------------");
                    }

                }

            }

        }


    }

}
