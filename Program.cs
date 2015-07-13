using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nom1._4
{
    class Program
    {
        static void Main()
        {
            string Text1 = Console.ReadLine();
            string Text = "";
            for (int i = 0; i < Text1.Length; i++)
            {
                if (!char.IsDigit(Text1[i]))
                {
                    Text += Text1[i];
                }
            }
            int a = Text.Length;
            for (int i = 0; i < Text.Length; i++)
                if (Text.Substring(i) == "!" || Text.Substring(i) == ";" || Text.Substring(i) == ":" || Text.Substring(i) == "," || Text.Substring(i) == "-"  || Text.Substring(i) == "?")
                    Text = Text.Remove(i, 1);
            Text = System.Text.RegularExpressions.Regex.Replace(Text, " +", " ");
            Text = Text.Trim();

            Console.WriteLine(Text);
            string[] words = Text.Split(' ');
            int n = words[0].Length;
            int Indmax = 0;
            for (int i = 0; i < words.Length; i++)
                if (words[i].Length > n)
                {
                    n = words[i].Length;
                    Indmax = i;
                }
            int nom = Indmax + 1;
            Console.WriteLine("Самое длинное слово: {0}", words[Indmax]);
            Console.WriteLine("Номер этого слова в предложении: {0}", nom);
            Console.ReadLine();
        }
    }
}
