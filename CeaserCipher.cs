using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTasks
{
    internal class CeaserCipher
    {
        internal string Code(string s, int slide)
        {
            string code = "";
            int a;

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLetter(s[i]))
                {
                    if (char.IsUpper(s[i]))
                    {
                        a = ((s[i] + slide) - 65) % 26 + 65;
                        code += (char)a;
                    }

                    else if (char.IsLower(s[i]))
                    {
                        a = ((s[i] + slide) - 97) % 26 + 97;
                        code += (char)a;
                    }
                }

                else
                    code += s[i];
            }

            return code;
        }

        internal string DeCode(string s, int slide)
        {
            string decode = "";
            int a;
            slide = slide % 26;

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLetter(s[i]))
                {
                    if (char.IsUpper(s[i]))
                    {
                        a = ((s[i] - slide) - 65 + 26) % 26 + 65;
                        decode += (char)a;
                    }

                    else if (char.IsLower(s[i]))
                    {
                        a = ((s[i] - slide) - 97 + 26) % 26 + 97;
                        decode += (char)a;
                    }
                }

                else
                    decode += s[i];
            }

            return decode;

        }

        internal void Print(string a)
        {
            Console.WriteLine(a);
        }
    }
}

