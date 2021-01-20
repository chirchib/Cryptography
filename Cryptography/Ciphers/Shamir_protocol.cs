﻿using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

// lab 2
namespace Cryptography.Ciphers
{
	static class Shamir
	{
		static private string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
		static private long[] numericConversion;
		static private string stringConversion;

		static public void extendedGCD(long a, long b, out long x, out long y, out long d)//Расширенный алгоритм Евклида
		{
			long q, r, x1, x2, y1, y2;


			if (b == 0)
			{
				d = a;
				x = 1;
				y = 0;
				return;
			}
			x2 = 1; y2 = 0;
			x1 = 0; y1 = 1;

			while (b > 0)
			{
				q = a / b; r = a - q * b;
				x = x2 - q * x1; y = y2 - q * y1;
				a = b; b = r;
				x2 = x1; x1 = x; y2 = y1; y1 = y;
			}
			d = a; x = x2; y = y2;
		}

		static public long GCD(long A, long B)//Поиск НОД | Алгоритм Евклида
		{
			while (B != 0)
				(A, B) = (B, A % B);
			return A;
		}

		static public long[] TextToNumberEncrypt(string Text)//Текст в набор чисел
		{
			numericConversion = new long[Text.Length];
			for (int i = 0; i < Text.Length; i++)//Числовой вид сообщения
			{
				for (int j = 0; j < Alphabet.Length; j++)
				{
					if (Text[i] == Alphabet[j])
					{
						numericConversion[i] = j + 1; break;
					}
				}
			}
			return numericConversion;
		}

		static public string NumberEncryptToText(long[] NumberEncrypt)//Набор чисел в текст
		{
			stringConversion = "";
			for (int i = 0; i < NumberEncrypt.Length; i++)
			{
				if (NumberEncrypt[i] == 0) stringConversion += " ";
				else stringConversion += Alphabet[(int)(NumberEncrypt[i] - 1)];
			}
			return stringConversion;
		}

		static public string NumberEncryptToTextWithSpace(long[] NumberEncrypt)//Набор чисел в текст
		{
			stringConversion = "";
			for (int i = 0; i < NumberEncrypt.Length; i++)
			{
				if (NumberEncrypt[i] == 0) stringConversion += " ";
				else stringConversion += Alphabet[(int)(NumberEncrypt[i] - 1)] + " ";
			}
			return stringConversion;
		}

		public static BigInteger reSquaring(BigInteger m, BigInteger e, BigInteger n)//c=m^e(mod n)
		{
			BigInteger E = e;

			long i;
			for (i = 1; E != 1; i++)//Проверка количества элементов
				E = E / 2;

			BigInteger[] bynaryN = new BigInteger[i];

			E = e;
			for (long j = 0; j < i; j++)//Степень в бинарном представлении
			{
				bynaryN[j] = E % 2;
				E = E / 2;
			}

			BigInteger b = m % n;
			for (long j = 1; j < i; j++)//Возведение в степень
			{
				b = BigInteger.ModPow(b, 2, n);
				if (bynaryN[j] == 1)
					m = (m * b) % n;
			}
			return m;
		}

		public static string NumberEncryptToString(long[] NE)
		{
			string str = "";
			foreach (var item in NE)
			{
				str += item + " ";
			}
			return str;
		}
	}

	static class A_Abonent
	{
		static private long[] NumberEncrypt;
		static private long[] FirstNumberEncrypt;
		static private long[] SecondNumberEncrypt;

		static private long E;
		static private long P;
		static private long D;

		static public long[] GetNumberEncrypt()
		{
			return NumberEncrypt;
		}

		static public bool isNormalE(long e)
		{
			if (Shamir.GCD(e, P - 1) == 1)
			{
				E = e;
				return true;
			}
			else return false;
		}

		static public void SetP(long p)
		{
			P = p;
		}

		static public void SetE()
		{
			do
			{
				A_Abonent.PrintLog("Ввод Еa: ", false);
				E = Convert.ToInt64(Console.ReadLine());
			}
			while (!A_Abonent.isNormalE(E));
			//A_Abonent.PrintLog($"E = {E} удовлетворяет условию НОД(Е, Р-1)!", true);
		}

		static public void SetD()
		{
			Shamir.extendedGCD(E, P - 1, out long x, out long y, out long d);
			D = x + (P - 1);
			PrintLog($"D = {D}", true);
		}

		static public void PrintE()
		{
			PrintLog($"Закрытый ключ абонента: E = {E}", true);
		}

		static public void PrintNumberEncrypt()
		{
			PrintLog($"Текст в числовом представлении: ", false);
			foreach (var item in NumberEncrypt)
				Console.Write($"{item} ");
			Console.WriteLine();
		}

		static public void TextToNumberEncrypt(string Text)
		{
			NumberEncrypt = Shamir.TextToNumberEncrypt(Text);
		}

		static public void PrintLog(string str, bool endl)
		{
			if (endl)
				Console.WriteLine("| Абонент A | " + str);
			else
				Console.Write("| Абонент A | " + str);
		}

		static public long[] FirstStepE(long[] C)
		{
			FirstNumberEncrypt = new long[C.Length];
			for (int i = 0; i < C.Length; i++)
			{
				FirstNumberEncrypt[i] = (long)(Shamir.reSquaring(C[i], E, P));//c=m^e(mod n)
			}
			return FirstNumberEncrypt;
		}

		static public long[] SecondStepD(long[] C)
		{
			SecondNumberEncrypt = new long[C.Length];
			for (long i = 0; i < C.Length; i++)
			{
				SecondNumberEncrypt[i] = (long)(Shamir.reSquaring(C[i], D, P));//c=m^e(mod n)
			}
			return SecondNumberEncrypt;
		}
	}

	static class B_Abonent
	{
		static private long[] NumberEncrypt;
		static private long[] FirstNumberEncrypt;
		static private long[] SecondNumberEncrypt;

		static private long E;
		static private long P;
		static private long D;

		static public long[] GetNumberEncrypt()
		{
			return NumberEncrypt;
		}

		static public bool isNormalE(long e)
		{
			if (Shamir.GCD(e, P - 1) == 1)
			{
				E = e;
				return true;
			}
			else return false;
		}

		static public void SetP(long p)
		{
			P = p;
		}

		static public void SetE()
		{
			do
			{
				B_Abonent.PrintLog("Ввод Еb: ", false);
				E = Convert.ToInt64(Console.ReadLine());
			}
			while (!B_Abonent.isNormalE(E));
			//B_Abonent.PrintLog($"E = {E} удовлетворяет условию НОД(Е, Р-1)!",true);
		}

		static public void SetD()
		{
			Shamir.extendedGCD(E, P - 1, out long x, out long y, out long d);
			D = x + (P - 1);
			PrintLog($"D = {D}", true);
		}

		static public void PrintE()
		{
			PrintLog($"Закрытый ключ абонента: E = {E}", true);
		}

		static public void PrintNumberEncrypt()
		{
			PrintLog($"Текст в числовом представлении: ", false);
			foreach (var item in NumberEncrypt)
				Console.Write($"{item} ");
			Console.WriteLine();
		}

		static public void TextToNumberEncrypt(string Text)
		{
			NumberEncrypt = Shamir.TextToNumberEncrypt(Text);
		}

		static public void PrintLog(string str, bool endl)
		{
			if (endl)
				Console.WriteLine("| Абонент B | " + str);
			else
				Console.Write("| Абонент B | " + str);
		}

		static public long[] FirstStepE(long[] C)
		{
			FirstNumberEncrypt = new long[C.Length];
			for (int i = 0; i < C.Length; i++)
			{
				FirstNumberEncrypt[i] = (long)(Shamir.reSquaring(C[i], E, P));//c=m^e(mod n)
			}
			return FirstNumberEncrypt;
		}

		static public long[] SecondStepD(long[] C)
		{
			SecondNumberEncrypt = new long[C.Length];
			for (int i = 0; i < C.Length; i++)
			{
				SecondNumberEncrypt[i] = (long)(Shamir.reSquaring(C[i], D, P));//c=m^e(mod n)
			}
			return SecondNumberEncrypt;
		}
	}
}
