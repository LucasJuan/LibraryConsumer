
using PasswordGenerator;

var generator = new PassWordGenerator();
generator.Length= 15;
string generatedPassword = generator.PasswordGenerator();
bool isMatch = generator.IsPasswordValid(".H{<>^LCz0o|PIT");

Console.WriteLine($"Password: {generatedPassword}");
Console.WriteLine($"Is Valid? {isMatch}");