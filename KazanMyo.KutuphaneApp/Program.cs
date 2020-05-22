using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KazanMyo.KutuphaneApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçin");
                    Console.WriteLine("***Kitap Ekleme için 1 ***\n***Kitabevindeki kitapların listesini görüntülemek için 2 ***\n***Uygulamadan çıkmak için 3 ***\nKitap basım tarihini düzgün şekilde girin.\n");

                    Console.Write("Yapmak istediğiniz işlemin numarasını yazın = ");

                    int is_no = int.Parse(Console.ReadLine());

                    if (is_no == 1)
                    {
                        Console.Write("İstediğiniz kitap sayısını yazın = ");
                        int kitapsayisi = int.Parse(Console.ReadLine());
                        Kitap[] Kitaplar = new Kitap[kitapsayisi];
                        int i = 0;
                        do
                        {
                            Kitap kitap = new Kitap();
                            Console.Write("Kitap adını girin = ");
                            kitap.kitapad = Console.ReadLine();
                            Console.Write("Kitap yazarı adını girin = ");
                            kitap.kitapyazar = Console.ReadLine();
                            Console.Write("Kitap basım tarihini girin = ");
                            kitap.kitapbastarih = DateTime.Parse(Console.ReadLine());
                            if (2020 < kitap.kitapbastarih.Year)
                            {
                                Console.WriteLine("Girilen sayı 2020 den büyük olamaz. Sayıyı tekrar girin.");
                                continue;
                            }
                            Console.Write("Kitap türünü girin = ");
                            kitap.kitaptur = Console.ReadLine();

                            Kitaplar[i] = kitap;
                            i++;
                        } while (i < kitapsayisi);
                        Kitap.dosyaekle(Kitaplar);
                        Console.WriteLine("Kitaplarınız eklendi");
                    }
                    else if (is_no == 2)
                    {
                        string dyolu = @"D:\metinbelgesi.txt";
                        string line;
                        StreamReader file = new StreamReader(dyolu);
                        while ((line = file.ReadLine()) != null)
                        {
                            Console.WriteLine(line);
                        }
                        file.Close();
                    }
                    else
                    {
                        Console.WriteLine("Uygulamadan çıkış yaptın.");
                        Environment.Exit(0);
                        break;
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Bir sayı girin \t!");
            }
            catch (Exception)
            {
                Console.WriteLine("Bir hata oluştu !");
            }
            Console.ReadLine();
        }
    }
}