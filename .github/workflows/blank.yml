using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;

namespace TodoList
{
    class Program
    {


        static List<string> gorevler = new List<string>();
        static List<bool> tamamlananGorevler = new List<bool>();


        static void Main(string[] args)

        {

            while (true)
            {

                Console.Clear();
                MenuGoster();
                string secim = Console.ReadLine();

                switch (secim)
                {

                    case "1":
                        GorevEkle();
                        break;

                    case "2":
                        GorevleriListele();
                        break;

                    case "3":
                        GorevTamamla();
                        break;
                    case "4":
                        GorevSil();
                        break;
                    case "5":
                        Console.WriteLine("Programdan Çıkılıyor");
                        return;
                    default:
                        Console.WriteLine("Geçersiz bir seçim uyguladınız. Devam etmek için bir tuşa basın");
                        Console.ReadKey();
                        break;


                }
            }
        }


        static void MenuGoster()
        {
            Console.WriteLine("== Kişisel Görev Listesi ==");
            Console.WriteLine("1.Görev Ekle");
            Console.WriteLine("2. Görevleri Listele");
            Console.WriteLine("3. Görev Tamamla");
            Console.WriteLine("4. Görev Sil");
            Console.WriteLine("5. Çıkış");
            Console.Write("Seçiminizi (Tuşlayıp Enterlayınız): ");

        }

        static void GorevEkle()
        {
            Console.Write("Yeni görev: ");
            string yeniGorev = Console.ReadLine();
            gorevler.Add(yeniGorev);  
            tamamlananGorevler.Add(false); 
        }

        static void GorevleriListele()
        {
            Console.WriteLine("=== Görev Listesi ===");
            for (int i = 0; i < gorevler.Count; i++)
            {
                string durum = tamamlananGorevler[i] ? "[Tamamlandı]" : "[Bekliyor]";
                Console.WriteLine($"{i + 1}. {durum} {gorevler[i]}");
            }
            Console.WriteLine("Devam etmek için bir tuşa basın...");
            Console.ReadKey();
        }

        static void GorevTamamla()
        {
            Console.Write("Tamamlanan görevin numarasını girin: ");
            if (int.TryParse(Console.ReadLine(), out int numara) && numara <= gorevler.Count && numara > 0)
            {
                tamamlananGorevler[numara - 1] = true;
                Console.WriteLine("Görev tamamlandı! Devam etmek için bir tuşa basın...");
            }
            else
            {
                Console.WriteLine("Geçersiz görev numarası! Devam etmek için bir tuşa basın...");
            }
            Console.ReadKey();
        }


        static void GorevSil()
        {
            Console.Write("Silmek istediğiniz görevin numarasını girin: ");
            if (int.TryParse(Console.ReadLine(), out int numara) && numara <= gorevler.Count && numara > 0)
            {
                gorevler.RemoveAt(numara - 1);
                tamamlananGorevler.RemoveAt(numara - 1);
                Console.WriteLine("Görev silindi! Devam etmek için bir tuşa basın...");
            }
            else
            {
                Console.WriteLine("Geçersiz görev numarası! Devam etmek için bir tuşa basın...");
            }
            Console.ReadKey();
        }
    }
}
