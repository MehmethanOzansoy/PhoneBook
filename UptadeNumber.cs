using System;
using System.Collections.Generic;

namespace Telefon
{

    public class Update
    {

        public void UpdateNumber(Dictionary<string, long> dictionary)
        {
            while (true)
            {
                System.Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ve soyadını giriniz:");
                string n = Console.ReadLine();

                if (dictionary.ContainsKey(n))
                {

                    System.Console.WriteLine("İsim ve Soyisim Güncellenmesi için (0) tıklayınız. ");
                    System.Console.WriteLine("Numarayı Güncellemek için (1) tıklayınız. ");
                    System.Console.WriteLine("Her ikisini Güncellemek içic (2) tıklayınız");
                    long value = dictionary[n];
                    int b = int.Parse(Console.ReadLine());

                    if (b == 0)
                    {
                        System.Console.Write("Lütfen isim ve soyisim'i giriniz : ");
                        string name = Convert.ToString(Console.ReadLine());
                        dictionary.Remove(n);
                        dictionary.Add(name, value);
                        System.Console.WriteLine("Güncelleme Başarılı (isim-soyisim)");
                        break;
                    }
                    else if (b == 1)
                    {
                        System.Console.WriteLine("Lütfen Numarayı Giriniz : ");
                        long no = Convert.ToInt64(Console.ReadLine());
                        dictionary[n] = no;
                        System.Console.WriteLine("Güncelleme Başarılı (numara)");
                        break;

                    }
                    else if (b == 2)
                    {
                        System.Console.WriteLine("Lütfen ad, soyad ve numarayı giriniz. ");
                        System.Console.Write("İsim-Soyisim          : ");
                        string nameSurname = Console.ReadLine();
                        System.Console.Write("Telefon numarası  : ");
                        long no1 = Convert.ToInt64(Console.ReadLine());
                        dictionary.Remove(n);
                        dictionary.Add(nameSurname, no1);
                        System.Console.WriteLine("Güncelleme Başarılı (Hepsi)");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Belirtilen anahtar mevcut değil.");
                    }

                }
                else
                {
                    System.Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    System.Console.WriteLine("* Güncellemeyi sonlandırmak için    : (1)");
                    System.Console.WriteLine("* Yeniden denemek için              : (2)");
                    int a = int.Parse(Console.ReadLine());

                    if (a == 1)
                    {
                        System.Console.WriteLine("İşleminiz sonlandırıldı");
                        break;
                    }
                    else if (a == 2)
                    {
                        System.Console.WriteLine("Yeniden deneyiniz. ");
                    }
                    else
                    {
                        throw new Exception("Hatalı değer Girdiniz !!!");
                    }

                }
            }
        }
    }


}