using System;
using System.Collections.Generic;
using System.Text;

namespace Ciphers
{
    class AffineCaesarCipher
    {
		private static string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyzАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя0123456789.,?!*/+-=_()%;:#";//Набор сиволов
		private string newAlphabet;

		private int[] arrNumber = new int[alphabet.Length];//Массив чисел, соответствующих алфавиту
		private int[] newArrNumber = new int[alphabet.Length];//Зашифрованный массив чисел

		private string encrypt = "";
		private string decrypt = "";

		private string text;//Входной текст

		private int alphabetLength = alphabet.Length;//Количество элементов в алфавите
		private int firstKey;//Первый ключ
		private int secondKey;//Второй ключ

		public AffineCaesarCipher(int keyA, int keyB, string text)
		{
			if (Gcd(keyA, alphabetLength) != 1)
				throw new Exception($"Первый ключ должен быть взаимно простым с числом {alphabetLength}!");
			if (keyA < 0 || keyB < 0)
				throw new Exception($"Ключи должны быть положительными!");
			this.firstKey = keyA;
			this.secondKey = keyB;
			this.text = text;
		}
		/// <summary>
		/// Заполнить численный алфавит ArrNumber значениями от 0 до конца алфавита
		/// </summary>
		private void alphabetNumber()
		{
			for (int i = 0; i < alphabetLength; i++)
				arrNumber[i] = i;
		}

		/// <summary>
		/// Зашифровать численный алфавит NewArrNumber
		/// </summary>
		private void newAlphabetNumber()
		{
			for (int i = 0; i < alphabetLength; i++)
			{
				newArrNumber[i] = (firstKey * arrNumber[i] + secondKey) % alphabetLength;
			}
		}

		private string cipherDerivation()
		{
			alphabetNumber();//Заполнить численный алфавит ArrNumber значениями от 0 до конца алфавита
			newAlphabetNumber();//Зашифровать численный алфавит NewArrNumber
			for (int i = 0; i < alphabetLength; i++)
			{
				newAlphabet += alphabet[newArrNumber[i]];
			}
			return newAlphabet;
		}


		public string Encode()//Зашифрованный Алфавит
		{
			string Cipher = cipherDerivation();
			for (int i = 0; i < text.Length; i++)
			{
				int index = alphabet.IndexOf(text[i]);
				encrypt += (index != -1) ? Cipher[index] : text[i];
			}
			return encrypt;
		}

		public string Decode()//Расшированный текст
		{
			string Cipher = cipherDerivation();
			for (int i = 0; i < text.Length; i++)
			{
				int index = Cipher.IndexOf(text[i]);
				decrypt += (index != -1) ? alphabet[index] : text[i];
			}
			return decrypt;
		}
		private int Gcd(int A, int B)
		{
			if (A == B)
				return A;
			if (A > B)
				(A, B) = (B, A);
			return Gcd(A, B - A);
		}
	}
}
