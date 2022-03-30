using System;
using System.Collections;
using System.Collections.Generic;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)

        {
            
            //Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

            // Negatif ve numeric olmayan girişleri engelleyin.
            // Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
            // Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
            ArrayList primeNumber = new ArrayList(); 
            ArrayList nonPrimeNumber = new ArrayList();
            double primeNumberSum = 0;
            double nonPrimeNumberSum = 0;
            
            Console.WriteLine("20 Adet pozitif sayı giriniz: ");
            for (int i = 0; i <20; i++)
            {
                Console.Write($"{i+1}.sayı: ");
                int num=Convert.ToInt32(Console.ReadLine());
                if(num>0)
                {
                    if (isPrime(num) && num!=1)
                    {
                        primeNumber.Add(num);
                        primeNumberSum+=num;
                    }
                    else
                    {
                        nonPrimeNumber.Add(num);
                        nonPrimeNumberSum+=num;
                    }
                }
                else
                {
                    Console.WriteLine("Girdiğiniz sayı pozitif değil.");
                }
               
            }
                //Asal Sayıları Yazdırma
                Console.WriteLine("***** Asal Sayılar*****");
                primeNumber.Sort();
                foreach (var item in primeNumber)
                {
                    Console.WriteLine(item);
                }

                //Asal Olmayan Sayıları Yazdırma
                Console.WriteLine("***** Asal Olmayan Sayılar*****");
                nonPrimeNumber.Sort();
                foreach (var item in nonPrimeNumber)
                {
                    Console.WriteLine(item);
                }

                //Asal Sayıların Ortalaması
                double primeAverage=primeNumberSum/primeNumber.Count;
                Console.WriteLine($"Asal Sayıların Ortalaması:{primeAverage}");

                //Asal Olmayan Sayıların Ortalaması
                double nonPrimeAverage=nonPrimeNumberSum/nonPrimeNumber.Count;
                Console.WriteLine($"Asal Olmayan Sayıların Ortalaması:{nonPrimeAverage}");

            }

        public static bool isPrime(int num )
        {
            int count=0;
            int i = 2;
            while (i < num)
            {
               if (num % i == 0)
               count++;
               i++;
            }

            if (count != 0)
                return false;
            else
                return true;
        }
    }
}
