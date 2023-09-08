using System.Runtime.CompilerServices;

namespace PasswordGenerator
{
    public class PassWordGenerator
    {
        public string? Password { get; set; }
        public int Length { get; set; } = 8;

        const string Numbers = "0123456789";
        const string SpecialCharacters = @"~!@#$%^&*():;[]{}<>,.?/\|";
        const string UpperCaseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string LowerCaseLetters = "abcdefghijklmnopqrstuvwxyz";

        public string PasswordGenerator()
        {
           var allowed = Numbers + SpecialCharacters + UpperCaseLetters + LowerCaseLetters;

            var random = new Random();

            var shuffledChars = new string(allowed.ToCharArray().OrderBy(c => random.Next()).ToArray());

            Password = new string(shuffledChars.Take(Length).ToArray());

            return Password;
        }
        public bool IsPasswordValid(string passwordToCheck)
        {
            if (string.IsNullOrEmpty(passwordToCheck) || passwordToCheck.Length < 8)
                return false;

            return Numbers.Any(n => passwordToCheck.Contains(n) &&
            SpecialCharacters.Any(s => passwordToCheck.Contains(s)) &&
            UpperCaseLetters.Any(u=> passwordToCheck.Contains(u)) &&
            LowerCaseLetters.Any(l=> passwordToCheck.Contains(l)) &&
            passwordToCheck.Length>=8);
        }
    }
}