using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ciphers
{
    class CaesarCipher
    {
		/// <summary>
		/// Алфавит символов
		/// </summary>
		private static string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyzАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя0123456789.,?!*/+-=_()%;:#";//Набор сиволов

		/// <summary>
		/// Числовой ключ сдвига
		/// </summary>
		private int numberKey;
		/// <summary>
		/// Ключевое слово
		/// </summary>
		private string lineKey;
		/// <summary>
		/// Текст
		/// </summary>
		private string text;

		private string encrypt;
		private string decrypt;

		public CaesarCipher(string LineKey, int NumberKey = 0, string Text = "")
		{
			this.numberKey = NumberKey;
			this.lineKey = LineKey;
			this.text = Text;
		}
		/// <summary>
		/// Вывод
		/// </summary>
		/// <returns></returns>
		private string derivation()
		{
			char[] reserveAlphabet = alphabet.ToCharArray(); 
			 lineKey = new string(lineKey.Distinct().ToArray()).Replace(" ", "");

			numberKey %= reserveAlphabet.Length;
			for (int i = 0, IndexOfKey = 0; i < reserveAlphabet.Length; i++)
			{
				if (IndexOfKey != lineKey.Length)
				{
					if (numberKey == reserveAlphabet.Length)
					{
						numberKey = 0;
					}
					reserveAlphabet[numberKey] = lineKey[IndexOfKey];
					numberKey++; IndexOfKey++;
				}
			}
			string residualAlphabet = alphabet;
			for (int i = 0; i < lineKey.Length; i++)//Алфавит без Ключевого слова
			{
				residualAlphabet = residualAlphabet.Replace(lineKey[i].ToString(), "");
			}

			for (int i = 0, k = 0; i < reserveAlphabet.Length && k < residualAlphabet.Length; i++, k++)
			{
				if (numberKey == reserveAlphabet.Length)
				{
					numberKey = 0;
				}
				reserveAlphabet[numberKey++] = residualAlphabet[k];
			}
			return new string(reserveAlphabet);
		}

		/// <summary>
		/// Шифрование
		/// </summary>
		/// <returns></returns>
		public string Encode()
		{
			string cipher = derivation();
			for (int i = 0; i < text.Length; i++)
			{
				int index = alphabet.IndexOf(text[i]);
				encrypt += (index != -1) ? cipher[index] : text[i];
			}
			return encrypt;
		}

		/// <summary>
		/// Дешифрование
		/// </summary>
		/// <returns></returns>
		public string Decode()
		{
			string сipher = derivation();
			for (int i = 0; i < text.Length; i++)
			{
				int index = сipher.IndexOf(text[i]);
				decrypt += (index != -1) ? alphabet[index] : text[i];
			}
			return decrypt;
		}
	}
}
