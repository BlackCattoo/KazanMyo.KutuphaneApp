using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KazanMyo.KutuphaneApp
{
    class Kitap
    {

        public Kitap()
        {

        }

        public string kitapyazar
        {
            get { return kitapyazar; } set { kitapyazar = value; }
        }


        public string kitaptur
        {
            get { return kitaptur; } set { kitaptur = value; }
        }

        public string kitapad
        {
            get { return kitapad; } set { kitapad = value; }
        }

        public DateTime kitapbastarih { get;  set; }

        public Kitap(string kitapad, string kitapyazar, string kitaptur, DateTime kitapbastarih)
        {
            kitapad = kitapad;
            kitapyazar = kitapyazar;
            kitaptur = kitaptur;
            kitapbastarih = kitapbastarih;
        }
        public static void dosyaekle(Kitap[] kitaplar)
        {
            try
            {
                string dyolu = @"D:\metinbelgesi.txt";
                bool varmi = File.Exists(dyolu);
                FileStream fs = new FileStream(dyolu, FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                if (varmi == false) sw.WriteLine("*****Kitap Adı******     *****Kitap Yazarı********     ******Kitap Türü******   ****Kitap Basım Yılı*****");
                foreach (var kitap in kitaplar)
                {
                    sw.Write("\r\nKitap adı : " + kitap.kitapad);
                    sw.Write("\r\nKitabın yazarı : " + kitap.kitapyazar);
                    sw.Write("\r\nKitabın türü : " + kitap.kitaptur);
                    sw.Write("\r\nKitabın basım yılı : " + kitap.kitapbastarih.ToShortDateString() + "\n\n");
                }
                sw.Flush();
                sw.Close();
                fs.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Dosya ekleme sırasında hata oluştu. " + e.Message);
            }
        }
    }
}
