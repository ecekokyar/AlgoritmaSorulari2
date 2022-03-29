using System;
using System.Collections;
using System.Collections.Generic;

namespace AlgortimaSorulari2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)
           
            int[] numbers = new int[20];
            ArrayList bigNumbers=new ArrayList();
            ArrayList smallNumbers=new ArrayList();
            
            //20 Adet Sayı Yazdırma
            Console.WriteLine("20 Adet sayı giriniz: ");
            for (int i = 0; i <20; i++)
            {
                Console.Write($"{i+1}.sayı: ");
                int num=Convert.ToInt32(Console.ReadLine());
                numbers[i]=num;  
            }

            //Küçük sayılar için sıralama
            Array.Sort(numbers);
            double sum1=0;
            for (int i = 0; i<3; i++)
            {
               smallNumbers.Add(numbers[i]);
               sum1+=numbers[i];
               
            }
            //Büyük sayılar için tersten sıralama
            Array.Reverse(numbers);
            double sum2=0;
            for (int i = 0; i<3; i++)
            {
               bigNumbers.Add(numbers[i]);
               sum2+=numbers[i];
            }

            Console.WriteLine("******************");
            Console.WriteLine("Yazdığınız en küçük 3 sayı: ");
            foreach (var item in smallNumbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Yazdığınız en büyük 3 sayı: ");
            foreach (var item in bigNumbers)
            {
               Console.WriteLine(item);
            }

            //Küçük sayıların ortalaması
            double smallAverage=Average(sum1,3);
            Console.WriteLine($"Yazılan en küçük 3 sayının ortalaması:{smallAverage} ");
            
            //Büyük sayıların ortalaması
            double bigAverage=Average(sum2,3);
            Console.WriteLine($"Yazılan en büyük 3 sayının ortalaması:{bigAverage} ");

        }
        public static double Average(double sum,double numbersCount)
        {
            double average=sum/numbersCount;
            return average;
        }
    }
}
