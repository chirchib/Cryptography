using System;
using Cryptography.Ciphers;

namespace Cryptography
{
    class Program
    {
        static void Main(string[] args)
        {
            //   Console.WriteLine("Пример работы шифра Двойной квадрат уинстона");
            //   Console.WriteLine("Зашифруем фразу : ПРИЛЕТАЮ ШЕСТОГО ");
            //   Wheatstone_Double_Square cipher1 = new Wheatstone_Double_Square();

            string key1 = "СКАНЕР";
            string key2 = "4123";
            string text1 = "системный пароль изменен";
            Console.WriteLine("\nПример работы шифра двойной перестановки");
            Console.WriteLine("Ключ 1 : {0}\nКлюч 2 : {1}", key1, key2);
            Console.WriteLine("Зашифруем фразу : {0}", text1);
            

            Double_permutation_of_characters encodecipher2 =
                new Double_permutation_of_characters(key1, key2, text1);
            

            Console.WriteLine("Зашифрованная фраза : " + encodecipher2.Encoded());

            string text2 = "ЙЛЕСП ЕЕЫОМИ ЬНТАИНМНРЗС";
            Console.WriteLine("Расшифруем фразу : " + text2);

            Double_permutation_of_characters decodecipher2 =
                new Double_permutation_of_characters(key1, key2, text2);

            Console.WriteLine("Расшифрованная фраза : " + decodecipher2.Decoded());
        }
    }
}
