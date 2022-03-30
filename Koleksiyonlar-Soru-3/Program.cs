using System;
using System.Collections;

namespace AlgoritmaSorulari2
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Bir cümle giriniz: ");
            string[] sentence=Console.ReadLine().Split(' ');
            string[] character = {"a","e","ı","i","o","ö","ü","u"};

            ArrayList vowels =new ArrayList();

            for(int i = 0; i < sentence.Length; i++)
            {
                foreach (var item in character)
                {
                    if(sentence[i].Contains(item))
                    {
                        vowels.Add(item);
                    }
                }  
            }

            Console.WriteLine("Yazılan cümlede kullanılan sesli harfler: ");

            foreach (var item in vowels)
            {
                Console.WriteLine(item);
            }
        }
    }
}
