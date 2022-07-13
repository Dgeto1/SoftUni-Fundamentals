using System;

namespace _05_DigitsLettersAndOthers
{
    class Program
    {
        static void Main(string[] args)
        {
            string st = Console.ReadLine();
            string numbers = string.Empty;
            string letters = string.Empty;
            string chars = string.Empty;
            for(int i=0; i<st.Length;i++)
            {
                if (char.IsDigit(st[i]))
                {
                    numbers += st[i];
                }
                else if (char.IsLetter(st[i]))
                {
                    letters += st[i];
                }
                else
                {
                    chars += st[i];
                }
            }
            Console.WriteLine(numbers);
            Console.WriteLine(letters);
            Console.WriteLine(chars);
        }
    }
}

