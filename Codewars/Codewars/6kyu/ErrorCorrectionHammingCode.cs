using System;
using System.Collections.Generic;
using System.Text;

namespace Codewars._6kyu
{
    /// <summary>
    /// https://www.codewars.com/kata/5ef9ca8b76be6d001d5e1c3e/train/csharp
    /// </summary>
    public class CodeWars
    {
        public static string encode(string text)
        {
            List<int> ASCIIvalues = new List<int>();
            List<int> binary = new List<int>();

            foreach (char singleChar in text)
            {
                ASCIIvalues.Add((int)singleChar);
            }

            foreach (int ASCIIvalue in ASCIIvalues)
            {
                int value = ASCIIvalue;
                binary.Add(value / 128);
                value = value % 128;
                binary.Add(value / 64);
                value = value % 64;
                binary.Add(value / 32);
                value = value % 32;
                binary.Add(value / 16);
                value = value % 16;
                binary.Add(value / 8);
                value = value % 8;
                binary.Add(value / 4);
                value = value % 4;
                binary.Add(value / 2);
                value = value % 2;
                binary.Add(value);
            }

            StringBuilder bits = new StringBuilder();
            foreach (int b in binary)
            {
                bits.Append(new string(char.Parse(b.ToString()), 3));
            }

            return bits.ToString();
        }

        public static string decode(string bits)
        {
            List<int> correctedBits = new List<int>();
            List<int> ASCIIvalues = new List<int>();

            for (int i = 0; i < bits.Length; i = i + 3)
            {
                var triplesFirst = Int32.Parse(bits[i].ToString());
                var triplesSecound = Int32.Parse(bits[i+1].ToString());
                var triplesThird = Int32.Parse(bits[i+2].ToString());

                var sum = triplesFirst + triplesSecound + triplesThird;

                if (sum == 0 || sum == 1) correctedBits.Add(0);
                if (sum == 2 || sum == 3) correctedBits.Add(1);
            }

            for (int i = 0; i < correctedBits.Count; i = i + 8)
            {
                int ASCIIvalue = correctedBits[i] * 128
                                    + correctedBits[i + 1] * 64
                                    + correctedBits[i + 2] * 32
                                    + correctedBits[i + 3] * 16
                                    + correctedBits[i + 4] * 8
                                    + correctedBits[i + 5] * 4
                                    + correctedBits[i + 6] * 2
                                    + correctedBits[i + 7] * 1;
                ASCIIvalues.Add(ASCIIvalue);
            }

            StringBuilder text = new StringBuilder();
            foreach (int ASCIIvalue in ASCIIvalues)
            {
                text.Append((char)ASCIIvalue);
            }

            return text.ToString();
        }
    }
}
