using System;
using Cryptography.Ciphers;

namespace Cryptography
{
    class Program
    {
        static void Main(string[] args)
        {
            // двойной квадрат
            string key11 = "ключ1";
            string key12 = "ключ2";
            string text11 = "некоторый текст";
            Console.WriteLine("Пример работы шифра Двойной квадрат уинстона");
            Console.WriteLine("Ключ 1 : {0}\nКлюч 2 : {1}", key11, key12);
            Console.WriteLine("Зашифруем фразу : " + text11);

            Wheatstone_Double_Square encodecipher1 =
                new Wheatstone_Double_Square(key11, key12, text11);

            Console.WriteLine("Зашифрованная фраза : " + encodecipher1.Encoded());

            string text12 = "6oчFЙtFQ!.r!БмrФ";
            Console.WriteLine("Расшифруем фразу : " + text12);

            Wheatstone_Double_Square decodecipher1 =
               new Wheatstone_Double_Square(key11, key12, text12);

            Console.WriteLine("Расшифрованная фраза : " + decodecipher1.Decoded());

            // двойная перестановка
            string key21 = "СКАНЕР";
            string key22 = "4123";
            string text21 = "системный пароль изменен";
            Console.WriteLine("\nПример работы шифра двойной перестановки");
            Console.WriteLine("Ключ 1 : {0}\nКлюч 2 : {1}", key21, key22);
            Console.WriteLine("Зашифруем фразу : {0}", text21);

            
            Double_permutation_of_characters encodecipher2 =
                new Double_permutation_of_characters(key21, key22, text21);
            

            Console.WriteLine("Зашифрованная фраза : " + encodecipher2.Encoded());

            string text22 = "ЙЛЕСП ЕЕЫОМИ ЬНТАИНМНРЗС";
            Console.WriteLine("Расшифруем фразу : " + text22);

            Double_permutation_of_characters decodecipher2 =
                new Double_permutation_of_characters(key21, key22, text22);

            Console.WriteLine("Расшифрованная фраза : " + decodecipher2.Decoded());
        }
    }
}
