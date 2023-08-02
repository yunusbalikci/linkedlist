using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Liste liste = new Liste();
         

            Console.WriteLine("Başa eklemek istediğiniz değerleri girin:");
            int degisken;
            degisken = Convert.ToInt32(Console.ReadLine());
         
            Console.WriteLine("-----------------------------------");
            liste.basaEkle(degisken);
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Araya eklemek istediğiniz verileri giriniz:");

            int aradegisken2;
            aradegisken2 = aradegisken2 = Convert.ToInt32(Console.ReadLine());
            liste.arayaEkle(aradegisken2);

            int ara_degisken;
            ara_degisken = Convert.ToInt32(Console.ReadLine());
            liste.arayaEkle(ara_degisken);

            Console.WriteLine("Sona eklenecek veriyi girin. ");
            int degisken2;
            degisken2 = Convert.ToInt32(Console.ReadLine());


            liste.sonaEkle(degisken2);

            Console.WriteLine("İlk eklenen node değeri: " + liste.head.data);
            Console.WriteLine("Son eklenen node değeri:" + liste.head.next.next.data);
           // liste.bastanSil();
            liste.yazdir();
            Console.WriteLine("Güncel ilk node: " + liste.head.data);

            Console.WriteLine("Baştan Sayı Silmek için 'd' tuşuna basınız");
      
            string bastanSayiSil;   
            bastanSayiSil = Console.ReadLine();
            if(bastanSayiSil == "d")
            {
                liste.bastanSil();
                Console.WriteLine("Baştaki sayı silindi.");
                Console.WriteLine("Güncel Liste:");
                liste.yazdir();
            }
            

            Console.ReadKey();



        }
    }
}
