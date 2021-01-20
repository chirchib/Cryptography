using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Cryptography.Ciphers
{
	static class ELGAmal
	{
		static private string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
		static private long[] numericConversion;

		static public bool IsPrimeNumber(long n)//Проверка на простоту
		{
			bool result = true;

			if (n > 1)
			{
				for (var i = 2u; i < n; i++)
				{
					if (n % i == 0)
					{
						result = false;
						break;
					}
				}
			}
			else
			{
				result = false;
			}
			return result;
		}

		static public BigInteger reSquaring(BigInteger m, BigInteger e, BigInteger n)//c=m^e(mod n)
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

		static public long Mod(long a, long b)
		{
			if (a < 0)
			{
				a *= -1;
				a = a % b;
				a = b - a;
				a = a % b;
				return a;
			}
			else
			{
				return a % b;
			}
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

		static public void PrintNumberEncrypt(long[] NumberEncrypt, bool Abonent)
		{
			if (Abonent)
				A_Abonent.PrintLog($"Текст в числовом представлении: ", false);
			else
				B_Abonent.PrintLog($"Текст в числовом представлении: ", false);
			foreach (var item in NumberEncrypt)
				Console.Write($"{item} ");
			Console.WriteLine();
		}

		static public long GCD(long A, long B)//Поиск НОД | Алгоритм Евклида
		{
			while (B != 0)
				(A, B) = (B, A % B);
			return A;
		}

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
	}

	static class Abonent1
	{
		static private long g;
		static private long p;
		static private long x;
		static private long y;
		static private long k;

		static public long a;
		static public long[] b;

		static public long KeyAbonentY;
		static public long KeyAbonentG;
		static public long KeyAbonentP;

		static public void EnterG()
		{
			do
			{
				PrintLog($"Введите g (g < {p}): ", false);
				g = Convert.ToInt32(Console.ReadLine());
			}
			while (!(ELGAmal.IsPrimeNumber(g) && (g < p)));
		}

		static public void EnterX()
		{
			do
			{
				PrintLog($"Введите x (x < {p}): ", false);
				x = Convert.ToInt32(Console.ReadLine());
			}
			while (!(ELGAmal.IsPrimeNumber(x) && (x < p)));
		}

		static public void SetP(int P)
		{
			p = P;
		}

		static public void CalculateY()
		{
			y = (long)ELGAmal.reSquaring(g, x, p);
		}

		static public void PrintOpenKeys()
		{
			PrintLog($"Открытый ключ: (y,g,p) = ({y},{g},{p}).", true);
		}

		static public void PrintPrivateKeys()
		{
			PrintLog($"Закрытый ключ: х = {x}.", true);
		}

		static public void SendOpenKeys()
		{
			Abonent2.KeyAbonentY = y;
			Abonent2.KeyAbonentG = g;
			Abonent2.KeyAbonentP = p;
		}

		static public void PrintLog(string str, bool endl)
		{
			if (endl)
				Console.WriteLine("| Абонент A | " + str);
			else
				Console.Write("| Абонент A | " + str);
		}

		static public bool isNormalE(long e)
		{
			return (ELGAmal.GCD(k, p - 1) == 1) ? true : false;
		}

		static public void EnterK()
		{
			do
			{
				Abonent1.PrintLog("Введите k: ", false);
				k = Convert.ToInt64(Console.ReadLine());
			}
			while (!Abonent1.isNormalE(k));
		}

		static public void FindFirstPart()
		{
			a = (long)ELGAmal.reSquaring(g, k, p);
			PrintLog($"а = {a}", false);
		}

		static public void PrintB(long[] b)
		{
			Console.Write("\tb[] = ");
			foreach (var item in b)
			{
				Console.Write(item + " ");
			}
			Console.WriteLine();
		}

		static public void FindSecondPart()
		{
			b = new long[Program.NumberEncrypt.Length];
			ELGAmal.extendedGCD(k, p - 1, out long t1, out long t2, out long d);
			for (int i = 0; i < b.Length; i++)
			{
				long firstPart = t1 + p - 1;
				long secondPart = ELGAmal.Mod(Program.NumberEncrypt[i] + 1 - x * a, p - 1);
				//Console.WriteLine(firstPart + " " + secondPart);

				b[i] = ELGAmal.Mod(firstPart * secondPart, p - 1);

				//Console.WriteLine(b[i]);
			}
			PrintB(b);
		}

		static public void SignatureGeneration()
		{
			EnterK();
			FindFirstPart();
			FindSecondPart();
		}
	}

	static class Abonent2
	{
		static private long g;
		static private long p;
		static private long x;
		static private long y;
		static private long k;

		static public long KeyAbonentY;
		static public long KeyAbonentG;
		static public long KeyAbonentP;

		static public void EnterG()
		{
			do
			{
				PrintLog($"Введите g (g < {p}): ", false);
				g = Convert.ToInt32(Console.ReadLine());
			}
			while (!(ELGAmal.IsPrimeNumber(g) && (g < p)));
		}

		static public void EnterX()
		{
			do
			{
				PrintLog($"Введите x (x < {p}): ", false);
				x = Convert.ToInt32(Console.ReadLine());
			}
			while (!(ELGAmal.IsPrimeNumber(x) && (x < p)));
		}

		static public void SetP(int P)
		{
			p = P;
		}

		static public void CalculateY()
		{
			y = (long)ELGAmal.reSquaring(g, x, p);
		}

		static public void PrintOpenKeys()
		{
			PrintLog($"Открытый ключ: (y,g,p) = ({y},{g},{p}).", true);
		}

		static public void PrintPrivateKeys()
		{
			PrintLog($"Закрытый ключ: х = {x}.", true);
		}

		static public void SendOpenKeys()
		{
			Abonent1.KeyAbonentY = y;
			Abonent1.KeyAbonentG = g;
			Abonent1.KeyAbonentP = p;
		}

		static public void PrintLog(string str, bool endl)
		{
			if (endl)
				Console.WriteLine("| Абонент B | " + str);
			else
				Console.Write("| Абонент B | " + str);
		}

		static public bool isNormalE(long e)
		{
			return (ELGAmal.GCD(k, p - 1) == 1) ? true : false;
		}

		static public void SignatureGeneration()
		{
			do
			{
				Abonent1.PrintLog("Введите k: ", false);
				k = Convert.ToInt64(Console.ReadLine());
			}
			while (!Abonent1.isNormalE(k));
		}

		static public void verificationOfDigitalSignature(long a, long[] b, long[] NumberEncrypt)
		{
			long[] LeftPart = new long[b.Length];//Левая часть
			long[] RightPart = new long[b.Length];//Правая часть

			PrintLog("Левая часть: ", false);
			for (int i = 0; i < b.Length; i++)
			{
				RightPart[i] = (long)ELGAmal.reSquaring(KeyAbonentG, NumberEncrypt[i], KeyAbonentP);
				Console.Write(RightPart[i] + " ");
			}
			Console.WriteLine();

			PrintLog("Правая часть: ", false);
			for (int i = 0; i < b.Length; i++)
			{
				long temp = (long)(ELGAmal.reSquaring(KeyAbonentY, a, KeyAbonentP) * ELGAmal.reSquaring(a, b[i], KeyAbonentP));
				LeftPart[i] = ELGAmal.Mod(temp, KeyAbonentP);
				Console.Write(RightPart[i] + " ");
			}
			Console.WriteLine("\nПроверка показала идентичность ЭЦП и открытой подписи!");
		}
	}
}
