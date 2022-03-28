using System;

namespace FunWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            FunWithStringsReverse("Hello from funWithStrings Method.");
            SpaceChar(" The    best  Lorem  Ipsum        Generator in all the  sea!   Heave this   scurvy copyfiller fer yar         next   adventure  and cajol yar clients   into walking the plank with ev'ry layout!    Configure       above, then get yer pirate ipsum...own the high seas,    argh! ");



            Console.ReadLine();
        }

        static void FunWithStringsReverse(string stringFun)
        {
            char[] charArray = stringFun.ToCharArray();


            string reversedString = String.Empty;


            for (int i = charArray.Length - 1; i > -1; i--)
            {


                reversedString += charArray[i];
            }
            Console.WriteLine(reversedString);
        
            int vowel = 0;
            for (int i = 0; i < stringFun.Length; i++)
            {
                if (stringFun[i] == 'a' || stringFun[i] == 'e' || stringFun[i] == 'i' || stringFun[i] == 'o' || stringFun[i] == 'u' || stringFun[i] == 'A' || stringFun[i] == 'E' || stringFun[i] == 'I' || stringFun[i] == 'O' || stringFun[i] == 'U')
                {
                    vowel++;
                }
                else if (stringFun[i] == 0)
                {
                    Console.WriteLine("There are no vowel's in the string");
                }

            }
            Console.WriteLine("The total number of vowel's in the string is" + vowel);


            string reverse = string.Empty;
            int length = stringFun.Length - 1;
            while (length >= 0)
            {
                reverse = reverse + stringFun[length];
                length--;
            }
            if (stringFun == reverse)
            {
                Console.WriteLine($"{stringFun} is a palindrome string");
            }
            else
            {
                Console.WriteLine($"{stringFun} is not a palindrome string");
            }

            stringFun = stringFun + " ";
            int len = stringFun.Length;
            String k = " ", max = " ", min = " ";
            char ch;

            int p, max1 = 0;
            int min1 = len;

            for (int i = 0; i < len; i++)
            {
                ch = stringFun[i];
                if (ch != ' ')
                {
                    k = k + ch;
                }
                else
                {
                    p = k.Length - 1;
                    if (p < min1)
                    {
                        min1 = p;
                        min = k;
                    }
                    if (p > max1)
                    {
                        max1 = p;
                        max = k;
                    }
                    k = " ";
                }
            }
            Console.Write("The shortest word in the string is = " + min + "\n");
            Console.Write("The longest word in the string is = " + max + "\n");

            Console.Write("The count of words is " + stringFun.Length + "\n");

            int[] charCount = new int[256];
            int lengthTwo = stringFun.Length;
            int maxCount = -1;
            char character = ' ';
            for (int i = 0; i < lengthTwo; i++)
            {
                if (maxCount < charCount[stringFun[i]])
                {
                    maxCount = charCount[stringFun[i]];
                    character = stringFun[i];
                }
                
            }
            Console.WriteLine("The most used character in the string is : " + character);

        }

        static string SpaceChar(string str)
        {
            string result = string.Empty;
            char[] strCharArray = str.ToCharArray();
            char prevChar = ' ';
            for (int i = 0; i < strCharArray.Length; i++)
            {
                char current = strCharArray[i];
                if (prevChar == ' ' && current == prevChar)
                    continue;
                else
                    result = result + current;

                prevChar = current;

            }
            Console.WriteLine(result);
            return result;

        }
    }
}


