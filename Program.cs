using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _4islemPratik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ilkSayi, ikinciSayi, dogruSonuc, girilenSonuc,miktar,puan=0,iter;
            
            Console.WriteLine("Kaç soru çözmek istiyorsunuz?");
            miktar = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<miktar; i++)
            {
                Random random = new Random();
                ilkSayi = random.Next(10,100);
                ikinciSayi = random.Next(10,100);
                Random rand = new Random();
                switch (rand.Next(4))
                {
                    case 0:
                        Console.WriteLine("{0} + {1} = ?", ilkSayi, ikinciSayi);
                        dogruSonuc = ilkSayi + ikinciSayi;
                        girilenSonuc = Convert.ToInt32(Console.ReadLine());
                        if (girilenSonuc == dogruSonuc)
                        {
                            Console.WriteLine("Sonuç Doğru");
                            puan++;
                        }
                        else
                        {
                            Console.WriteLine("Cevap YANLIŞ!\nDoğru Cevap: {0}", dogruSonuc);
                            puan--;
                        }
                        break;
                    case 1:
                        if (ilkSayi < ikinciSayi)
                        {
                            iter = ikinciSayi;
                            ikinciSayi = ilkSayi;
                            ilkSayi = iter;
                        }
                        Console.WriteLine("{0} - {1} = ?", ilkSayi, ikinciSayi);
                        dogruSonuc = ilkSayi - ikinciSayi;
                        girilenSonuc = Convert.ToInt32(Console.ReadLine());
                        if (girilenSonuc == dogruSonuc)
                        {
                            Console.WriteLine("Sonuç Doğru");
                            puan++;
                        }
                        else
                        {
                            Console.WriteLine("Cevap YANLIŞ!\n Doğru Cevap: {0}", dogruSonuc);
                            puan--;
                        }
                        break;
                    case 2:
                        Console.WriteLine("{0} x {1} = ?", ilkSayi, ikinciSayi);
                        dogruSonuc = ilkSayi * ikinciSayi;
                        girilenSonuc = Convert.ToInt32(Console.ReadLine());
                        if (girilenSonuc == dogruSonuc)
                        {
                            Console.WriteLine("Sonuç Doğru");
                            puan++;
                        }
                        else
                        {
                            Console.WriteLine("Cevap YANLIŞ!\n Doğru Cevap: {0}", dogruSonuc);
                            puan--;
                        }
                        break;
                    case 3:
                        if (ilkSayi < ikinciSayi)
                        {
                            iter = ikinciSayi;
                            ikinciSayi = ilkSayi;
                            ilkSayi = iter;
                        }
                            
                        Console.WriteLine("{0} / {1} = ?", ilkSayi, ikinciSayi);
                        dogruSonuc = ilkSayi / ikinciSayi;
                        girilenSonuc = Convert.ToInt32(Console.ReadLine());
                        if (girilenSonuc == dogruSonuc)
                        {
                            Console.WriteLine("Sonuç Doğru");
                            puan++;
                        }
                        else
                        {
                            Console.WriteLine("Cevap YANLIŞ!\n Doğru Cevap: {0}", dogruSonuc);
                            puan--;
                        }
                        break;

                }

            }
            

            Console.WriteLine("PUANINIZ: {0}",puan);
            Console.ReadKey();
        }
    }
}
