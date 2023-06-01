using System;
using System.Collections.Generic;

namespace Telefon // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, long> numberNames = new Dictionary<string, long>();

            numberNames.Add("Ali Aydın", 01234567891);
            numberNames.Add("Murat Yaşar", 01234567899);

            numberNames.Add("Zeynep Aydın", 01234567891);
            numberNames.Add("Kaan Yaşar", 01234567899);

            numberNames.Add("Vural Şahin", 01234567891);
            numberNames.Add("Buse Arslan", 01234567899);


            AddNumbers addNumbers = new AddNumbers();
            TelefonRehberi telefonRehberi = new TelefonRehberi();
            Delete delete = new Delete();
            Update update = new Update();


            while (true)
            {
                System.Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
                System.Console.WriteLine("******************************************* ");
                System.Console.WriteLine("(1) Yeni Numara Kaydetmek ");
                System.Console.WriteLine("(2) Varolan Numarayı Silmek");
                System.Console.WriteLine("(3) Varolan Numarayı Güncelleme");
                System.Console.WriteLine("(4) Rehberi Listelemek");
                System.Console.WriteLine("(5) Rehberde Arama Yapmak");
                System.Console.WriteLine("(6) Çıkış Yap");

                int n = int.Parse(Console.ReadLine());
                System.Console.WriteLine("Seçiminiz {0} ",n);

                if (n == 1)
                {
                    addNumbers.createNewNumbers(numberNames);
                }
                else if (n == 2)
                {
                    delete.del(numberNames);
                }
                else if (n == 3)
                {
                    update.UpdateNumber(numberNames);
                }
                else if (n == 4)
                {
                    telefonRehberi.getGuide(numberNames);
                }
                else if (n == 5)
                {   
                    telefonRehberi.getUser(numberNames);
                }
                else if (n == 6)
                {

                    System.Console.WriteLine("Kullandığınız için teşekkür ederiz");
                    break;
                }

                else
                {
                    throw new Exception("Hatalı numara girdiniz lütfen tekrar giriniz (0-6)");
                }
            }
        }
    }
}