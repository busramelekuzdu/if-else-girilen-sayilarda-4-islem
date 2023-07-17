using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elseif
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sayi1, sayi2, sonuc = 0;
            Console.Write("birinci sayıyı giriniz:");
            sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("ikinci sayıyı giriniz:");
            sayi2= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("toplama için---> t \n çıkarma işlemi---> ç \n çarpma işlemi---> x \n bölme işlemi---> b tuşuna basınız");
            string islem= Console.ReadLine();
            if (islem == "t")
                sonuc = sayi1 + sayi2;
            else if (islem == "ç")
                sonuc = sayi1 - sayi2;
            else if (islem == "x")
                sonuc = sayi1 * sayi2;
            else if (islem == "b")
                sonuc = sayi1 / sayi2;
            else // elseden sonra boşluk bırakılmaz. işlemi hatalı verir.
                Console.WriteLine("yanlış bir tuşa bastınız");
            Console.WriteLine("işlemin sonucu:" +sonuc);
            Console.ReadKey();  








        }
    }
}
