using System;
using Cryptography.Ciphers;

namespace Cryptography
{
    class Program
    {
        static void Main(string[] args)
        {
			using System;
			using Cryptography.Ciphers;

namespace Cryptography
	{
		class Program
		{
			////////// laba 2
			//
			//        static public string text = "DOS";
			//        static public long p = 23;
			//
			//        static void Main(string[] args)
			//        {
			//            Console.WriteLine("=====================================================================================================================");
			//            A_Abonent.PrintLog($"Исходное сообщение: {text}", true);
			//
			//            A_Abonent.PrintLog($"Введите Ea, что-бы НОД(Еа, {p - 1}) = 1", true);
			//            A_Abonent.SetP(p);//Передаем p абоненту А
			//            A_Abonent.SetE();//Вводим Еа у абонента А
			//            A_Abonent.SetD();//Формируем D абонента А
			//
			//
			//            B_Abonent.PrintLog($"Введите Eb, что-бы НОД(Еb, {p - 1}) = 1", true);
			//            B_Abonent.SetP(p);//Передаем p абоненту В
			//            B_Abonent.SetE();//Вводим Еа у абонента В
			//            B_Abonent.SetD();//Формируем D абонента В
			//
			//
			//            A_Abonent.PrintE();//Выводим закрытый ключ абонента А
			//            B_Abonent.PrintE();//Выводим закрытый ключ абонента В
			//
			//
			//            A_Abonent.TextToNumberEncrypt(text);//Текст в числовом представлении
			//            A_Abonent.PrintNumberEncrypt();//Вывод текста  в числ. представлении  
			//
			//
			//            long[] C1 = A_Abonent.FirstStepE(A_Abonent.GetNumberEncrypt());////////////////////////////////////////////////////////////////////////
			//            //C1 = new long[] { 1, 2, 3, 5 };
			//            A_Abonent.PrintLog("Текст в числовом представлении C1: " + Shamir.NumberEncryptToString(C1), true);
			//            A_Abonent.PrintLog("Текст в символьном представлении С1: " + Shamir.NumberEncryptToTextWithSpace(C1), true);
			//
			//            long[] C2 = B_Abonent.FirstStepE(C1);
			//            B_Abonent.PrintLog("Текст в числовом представлении C2: " + Shamir.NumberEncryptToString(C2), true);
			//            B_Abonent.PrintLog("Текст в символьном представлении С2: " + Shamir.NumberEncryptToTextWithSpace(C2), true);
			//
			//            long[] C3 = A_Abonent.SecondStepD(C2);
			//            A_Abonent.PrintLog("Текст в числовом представлении C3: " + Shamir.NumberEncryptToString(C3), true);
			//            A_Abonent.PrintLog("Текст в символьном представлении С3: " + Shamir.NumberEncryptToTextWithSpace(C3), true);
			//
			//            long[] C4 = B_Abonent.SecondStepD(C3);
			//            B_Abonent.PrintLog("Текст в числовом представлении C4: " + Shamir.NumberEncryptToString(C4), true);
			//            B_Abonent.PrintLog("Текст в символьном представлении С4: " + Shamir.NumberEncryptToTextWithSpace(C4), true);
			//
			//            B_Abonent.PrintLog($"Полученное сообщение: {Shamir.NumberEncryptToText(C4)}", true);
			//            Console.WriteLine("=====================================================================================================================");
			//
			//        }
			//
			//
			///////////////// laba 3
			///
			//        static void Main(string[] args)
			//        {
			//            RSA algorithmRSA = new RSA(17, 36563, 57731);//Генерируем ключи
			//
			//            algorithmRSA.getPublicKey(out long e, out long n1);//Возврат открытых ключей
			//
			//            string[] rsaEncrypt = algorithmRSA.Encrypt("PUBLIC", e, n1);//Зашифровываем сообщение
			//
			//            algorithmRSA.getPrivateKey(out long d, out long n2);//Возврат открытых ключей
			//
			//            string rsaDecrypt = algorithmRSA.Decrypt(rsaEncrypt, d, n2);//Дешифровываем сообщение
			//
			//
			//            algorithmRSA.CipherLog();
			//        }
			//
			//        
			/////////// laba 4 
			///
			//        static public string text = "CTC";
			//        static public int p = 42467;
			//        static public long[] NumberEncrypt;
			//        
			//        static void Main(string[] args)
			//        {
			//            Console.WriteLine("=====================================================================================================================");
			//            Abonent1.PrintLog($"ИСходное сообщение: {text}", true);
			//        
			//            //Этап 1
			//            Abonent1.SetP(p);//Абонент А выбирает Р
			//            Abonent1.EnterG();//Абонент А вводит G
			//            Abonent1.EnterX();//Абонент A вводит Х
			//            Abonent1.CalculateY();//Высчитываем Y
			//            Abonent1.PrintOpenKeys();//Вывод открытых ключей
			//            Abonent1.PrintPrivateKeys();//Вывод закрытых ключей
			//            Abonent1.SendOpenKeys();//Отправляем абоненту B открытый ключ
			//            //Этап 2
			//            NumberEncrypt = ELGAmal.TextToNumberEncrypt(text);
			//            ELGAmal.PrintNumberEncrypt(NumberEncrypt, true);
			//        
			//            //Этап 3
			//            Abonent1.SignatureGeneration();//Генерация ЭЦП
			//        
			//            //Этап 4
			//            Abonent2.verificationOfDigitalSignature(Abonent1.a, Abonent1.b, NumberEncrypt);
			//            Console.WriteLine("=====================================================================================================================");
			//        }
			//    
		}
	}


}
}
