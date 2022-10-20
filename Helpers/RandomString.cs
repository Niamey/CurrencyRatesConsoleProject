using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Helpers
{
    public static class RandomString
    {
        private static readonly Random Random = new Random();
        private const string AlphanumericAndSpecialCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789*$-+?_&=!%{}/ ";
        private const string AlphanumericAndSpecialWithoutSpaceCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789*$-+?_&=!%{}/";
        private const string AlphanumericCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        private const string NumericCharacters = "0123456789";
        public static string GetAlphanumericAndSpecialCharactersRandomString(int length)
        {
            return new string(Enumerable.Repeat(AlphanumericAndSpecialCharacters, length)
                .Select(s => s[Random.Next(s.Length)]).ToArray());
        }

        public static string GetAlphanumericAndSpecialCharactersWithoutSpaceRandomString(int length)
        {
            return new string(Enumerable.Repeat(AlphanumericAndSpecialWithoutSpaceCharacters, length)
                .Select(s => s[Random.Next(s.Length)]).ToArray());
        }

        public static string GetAlphanumericRandomString(int length)
        {
            return new string(Enumerable.Repeat(AlphanumericCharacters, length)
                .Select(s => s[Random.Next(s.Length)]).ToArray());
        }

        public static string GetNumericRandomString(int length)
        {
            return new string(Enumerable.Repeat(NumericCharacters, length)
                .Select(s => s[Random.Next(s.Length)]).ToArray());
        }
    }
}


