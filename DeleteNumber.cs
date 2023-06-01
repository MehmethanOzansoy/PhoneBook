using System;
using System.Collections.Generic;

namespace Telefon // Note: actual namespace depends on the project name.
{

    public class Delete
    {
        public void del(Dictionary<string, long> kullanıcılar)
        {
            System.Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ve soyadını giriniz: 5 Hakkınız var");
            while (true)
            {
                string name = Console.ReadLine();
                if (kullanıcılar.ContainsKey(name))
                {
                    System.Console.WriteLine("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
                    char a;
                    a = Console.ReadLine()[0];

                    if (a == 'y')
                    {
                        kullanıcılar.Remove(name);
                        System.Console.WriteLine("Kullaıcı silindi !!!");
                    }
                    else if (a == 'n')
                    {
                        System.Console.WriteLine("Çıkış Yapıldı");
                        break;
                    }
                    else
                    {
                        throw new Exception("Hatalı değer girdiniz: ");
                    }
                }
                else
                {

                    System.Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    System.Console.WriteLine(" * Silmeyi sonlandırmak için : (1)");
                    System.Console.WriteLine(" * Yeniden denemek için      : (2)");
                    int n = int.Parse(Console.ReadLine());

                    if (n == 1)
                    {
                        System.Console.WriteLine("İşleminiz durduruldu");
                        break;
                    }
                    else if (n == 2)
                    {
                        System.Console.WriteLine("Devam ediniz");
                    }
                    else
                    {
                        throw new Exception("Hatalı Kodlama yaptınız");
                    }
                }

            }



        }
    }

}