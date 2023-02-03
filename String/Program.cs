using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = true;
            while (exit)
            {
                Console.Write("Введите задание, которое хотите проверить (от 8 до 15, для выхода нажмите 0) -> ");
                string test = Console.ReadLine();

                if(test == "0")
                {
                    exit = false;
                }
                if (test == "8")
                {
                    StringBuilder s = new StringBuilder("Реализовать удаление из строки символа с заданным номером");
                    Console.WriteLine(s);

                    Console.Write("Введите номер символа, который хотите удалить -> ");
                    int num = Convert.ToInt32(Console.ReadLine());

                    s = s.Remove(num - 1, 1);
                    Console.WriteLine(s);
                }
                if (test == "9")
                {
                    string str = "Реаллизовать удаление из строки все вхождения в нее задонного символа";
                    StringBuilder s = new StringBuilder(str);
                    Console.WriteLine(str);
                    Console.Write("Введите символ, который хотите удалить -> ");
                    char k = Console.ReadKey().KeyChar;

                    char[] mass = str.ToCharArray();

                    for (int i = 0; i < s.Length; i++)
                    {
                        if (k == s[i])
                        {
                            s = s.Remove(i, 1);
                            i--;
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine(s);

                }
                if (test == "10")
                {
                    string str = "Написать метод, который вставляет в строку указанную позицию (заданный символ)";

                    Console.WriteLine(str);

                    Console.Write("Введите номер позиции в которую хотите вставить символ -> ");
                    int num = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Введите строку, который хотите вставить -> ");
                    string k = Console.ReadLine();

                    string modified = str.Insert(num, k);
                    Console.WriteLine(modified);
                }
                if (test == "11")
                {
                    Console.Write("Введите слово -> ");
                    string str = Console.ReadLine();

                    char[] First = str.ToCharArray();
                    char[] Second = str.ToCharArray();

                    bool Palindrome = true;

                    int j = Second.Length - 1;
                    for (int i = 0; i < First.Length; i++, j--)
                    {
                        if (First[i] != Second[j])
                        {
                            Palindrome = false;
                            break;
                        }
                    }

                    if (Palindrome == true)
                    {
                        Console.WriteLine($"Слово {str} является палиндромом");
                    }
                    else
                    {
                        Console.WriteLine($"Слово {str} не является палиндромом");
                    }
                    Console.WriteLine();
                }
                if (test == "12")
                {
                    Console.Write("Введите предложение -> ");
                    string[] str = Console.ReadLine().Split(new char[] { ' ', '\n', '\t', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);

                    Console.WriteLine($"Количество слов в предложении -> {str.Length}");
                }
                if (test == "13")
                {
                    Console.Write("Введите предложение -> ");
                    string str = Console.ReadLine();

                    Console.Write("Введите строку для поиска -> ");
                    string finde = Console.ReadLine();

                    Console.Write("Введите строку для замены -> ");
                    string change = Console.ReadLine();

                    string modified = str.Replace(finde, change);
                    Console.WriteLine($"Предложение после замены -> {modified}");
                }
                if(test == "14")
                {

                }
            }
        }
    }
}
