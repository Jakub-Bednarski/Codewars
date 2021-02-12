using System.Text.RegularExpressions;

namespace Codewars._6kyu
{
    /// <summary>
    /// https://www.codewars.com/kata/517abf86da9663f1d2000003/train/csharp
    /// </summary>
    public class CamelCase
    {
        public static string ToCamelCase(string str)
        {
            if (str == "" || str == null) return str;
            var strWithSpaces = Regex.Replace(str, "(-)|(_)", " ");
            var strList = Regex.Split(strWithSpaces, " ");

            if (strList.Length > 0)
            {
                for (int i = 1; i < strList.Length; i++)
                {
                    strList[i] = strList[i][0].ToString().ToUpper() + strList[i].Substring(1, strList[i].Length - 1);
                }
            }

            return string.Join("", strList);
        }
    }
}
