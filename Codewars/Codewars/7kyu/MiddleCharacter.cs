namespace Codewars._7kyu
{
    /// <summary>
    /// https://www.codewars.com/kata/56747fd5cb988479af000028/train/csharp
    /// </summary>
    public class MiddleCharacter
    {
        public static string GetMiddle(string s)
        {
            if (s.Length % 2 == 0) return s.Substring(s.Length / 2 - 1, 2);
            return s[s.Length / 2].ToString();
        }
    }
}
