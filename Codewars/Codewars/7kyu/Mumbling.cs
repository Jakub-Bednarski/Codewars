using System;
using System.Text;

namespace Codewars._7kyu
{
    /// <summary>
    /// https://www.codewars.com/kata/5667e8f4e3f572a8f2000039/train/csharp
    /// </summary>
    public class Mumbling
    {
        public static String Accum(string s)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                result.Append(s[i].ToString().ToUpper() + new string(s[i], i).ToLower());
                if (i < s.Length - 1) result.Append("-");
            }

            return result.ToString();
        }
    }
}
