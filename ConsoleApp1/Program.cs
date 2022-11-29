using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte ogrenciSayisi = 0;
            int gecenSayisi = 0;

            sayiGirme:
            try
            {
                Console.Write("Öğrenci Sayısını Giriniz : ");
                ogrenciSayisi = Convert.ToByte(Console.ReadLine());
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Lütfen Sayı Giriniz !\n-----------------------");
                goto sayiGirme;
            }

            string gecti_kaldi;
            string[] isimler = new string[ogrenciSayisi];
            byte[] notlar = new byte[ogrenciSayisi];

            for (int i = 0; i < isimler.Length; i++)
            {
                Console.Write($"--------------------------------------------\n{i+1}. Öğrenci Adını Giriniz : ");
                isimler[i] = Console.ReadLine();

                notGirme:
                try
                {
                    Console.Write($"{isimler[i]} Adlı Öğrencinin Din Kültürü Ve Ahlak Bilgisi Notunu Giriniz : ");
                    notlar[i] = Convert.ToByte(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Lütfen Not Giriniz !\n-----------------------");
                    goto notGirme;
                }
            }

            Console.Clear();
            Console.WriteLine("Öğrenci Adları Ve Notları\n");

            for(int i = 0; i < isimler.Length; i++)
            {
                if (notlar[i] >= 50)
                {
                    gecti_kaldi = "Dersten Geçti";
                    gecenSayisi++;
                }
                else
                {
                    gecti_kaldi = "Dersten Kaldı";
                }

                Console.WriteLine($"----------------------------\n{isimler[i]} Adlı Öğrenci Din Kültürü Ve Ahlak Biligisi Dersinden {notlar[i]} Aldı. {gecti_kaldi}");
            }

            Console.WriteLine($"\nGeçen Öğrenci Sayısı : {gecenSayisi} \nKalan Öğrenci Sayısı : {ogrenciSayisi-gecenSayisi}");

            Console.ReadKey();
        }
    }
}
