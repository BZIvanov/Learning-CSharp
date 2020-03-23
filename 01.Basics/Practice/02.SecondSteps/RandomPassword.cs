using System;

namespace SecondSteps
{
  class RandomPassword
  {
    static void Main(string[] args)
    {
      var random = new Random();
        const int PasswordLength = 10;
        var buffer = new char[PasswordLength];

        for (var i = 0; i < PasswordLength; i++)
        {
          buffer[i] = (char)('a' + random.Next(0, 26));
        }

        var password = new string(buffer);
        Console.WriteLine(password);
    }
  }
}
