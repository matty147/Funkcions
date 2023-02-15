using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
	internal class Program
	{
		static void PickAFunction()
		{
			Console.WriteLine("Please pick a funkcion");
			Console.WriteLine("Your options:");
			Console.WriteLine("Number 1-10 or The names of the function");
			string input = Console.ReadLine();;
			if (input == "n")
			{
				//close
			} else if (input == "1" || input == "Plus")
			{
				Plus();
				Console.WriteLine(Plus());
				Console.ReadKey();
				PickAFunction();
			}
			else if (input == "2" || input == "Slice")
			{
				Slice();
				Console.ReadKey();
				PickAFunction();
			}
			else if (input == "3" || input == "Multiple")
			{
				multiple();
				Console.ReadKey();
				PickAFunction();
			}
			else if (input == "4" || input == "IsEven")
			{
				int Enput = int.Parse(Console.ReadLine());
				bool even = IsEven(Enput);
				Console.WriteLine($"{Enput} is even:{even}");
				IsEven(Enput);
				Console.ReadKey();
				PickAFunction();
			}
			else if (input == "5" || input == "Dividers")
			{
				dividers();
				Console.ReadKey();
				PickAFunction();
			}
			else if (input == "6" || input == "Averige")
			{
				Averige();
				Console.ReadKey();
				PickAFunction();
			}
			else if (input == "7" || input == "Lenght")
			{
				Lenght();
				Console.ReadKey();
				PickAFunction();
			}
			else if (input == "8" || input == "Greaterthen")
			{
				Greaterthen();
				Console.ReadKey();
				PickAFunction();
			}
			else if (input == "9" || input == "StartwithA")
			{
				StartwithA();
				Console.ReadKey();
				PickAFunction();
			}
			else if (input == "10" || input == "Contains The Letter E")
			{
				ContainsTheLetterE();
				Console.ReadKey();
				PickAFunction();
			}
		}
		static bool IsEven(int i)
		{
			return i % 2 == 0;
		}
		static int Plus()
		{
			Console.WriteLine("Please enter two whole numbers");
			int input1 = int.Parse(Console.ReadLine());
			int input2 = int.Parse(Console.ReadLine());
			return input1 + input2;
		}
		static void Slice()
		{
			string Sinput = "12.421.245.54.5.0.-1";
			List<int> List1 = Sinput.Split('.', ',').Select(s => Int32.Parse(s)).ToList();
			foreach (int a in List1)
			{
				Console.WriteLine(a);
			}
			return;
		}
		static void multiple()
		{
			int multiple = 24;
			for (int i = 1; i <= 10; i++)
			{
				Console.WriteLine(multiple);
				multiple += multiple / i;
			}
		}
		static void dividers()
		{
			float dividers = 189;
			for (float i = 1; i < dividers; i++)
			{
				float div = dividers / i;
				if (div % 1 == 0)
				{
					Console.WriteLine(div); // forgets 1
				}
			}
			return;
		}

		static void Averige()
		{
			List<int> List = new List<int>();
			List.Add(1);
			List.Add(5);
			List.Add(3);
			List.Add(2);
			List.Add(4);
			List.Add(4);
			float diameter = 0;
			int dia = 0;
			foreach (int a in List)
			{
				diameter += a;
				dia++;
			}
			Console.WriteLine(diameter / dia);
		}
		static void Lenght()
		{
			/*
			string[] Words = {"a", "ab", "abc", "abcd", "abcdef", "f", "ab", "abcdefgh", "v" };
			string LongestWord = Words[0];
			foreach (string a in Words)
			{
				if (a.Length > LongestWord.Length)
				{
					LongestWord = a;
				}
			}
			Console.WriteLine(LongestWord);
			*/
			Console.Write("Enter a list of words: ");
			string input = Console.ReadLine();
			string[] words = input.Split(',', ' ');

			string longestWord = words[0];
			foreach (string word in words)
			{
				if (word.Trim().Length > longestWord.Trim().Length)
				{
					longestWord = word.Trim();
				}
			}

			Console.WriteLine($"The longest word is '{longestWord}'.");
		}
		static void Greaterthen()
		{
			int[] Numb = {1, 5, 8, 11, 10, -10, 0};
			foreach(int a in Numb)			
			{
				if (a > 10)
				{
					Console.WriteLine(a);
				}
			}
		}
		static void StartwithA()
		{
			string input = Console.ReadLine();
			string[] Words = input.Split(',', ' ');
			foreach (string a in Words)
			{
				if (a.StartsWith("a"))
				{
					Console.WriteLine(a);
				}				
			}
		}
		static void ContainsTheLetterE()
		{
			string input = Console.ReadLine();
			string[] Words = input.Split(',', ' ');
			foreach (string e in Words)
			{
				if (e.Contains("e"))
				{
					Console.WriteLine(e);
				}
			}
		}
		static void Main(string[] args)
		{
			//PickAFunction();
			//first challenge
			Console.WriteLine(Plus());
			Console.WriteLine("------------");
			//second challenge
			Slice();
			Console.WriteLine("------------");
			//third challenge
			multiple();
			//fourth challenge
			int input = int.Parse(Console.ReadLine());
			bool even = IsEven(input);
			Console.WriteLine($"{input} is even:{even}");
			Console.WriteLine("------------");
			//fifth challenge
			dividers();
			Console.WriteLine("------------");
			//six challenge
			Averige();
			Console.WriteLine("------------");
			//seven challenge
			Lenght();
			//eight challenge
			Console.WriteLine("------------");
			Greaterthen();
			//nine challenge
			Console.WriteLine("------------");
			StartwithA();
			Console.WriteLine("------------");
			ContainsTheLetterE();
			Console.ReadKey();
		}
	}
}
