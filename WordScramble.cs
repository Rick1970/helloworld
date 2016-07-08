using System;

class Scramble
{
  static void Main()
  {
    Console.WriteLine("Please enter a word for scrambalation!!");
    string newWord = Console.ReadLine();
    string scramble = newWord.Replace("e", "qudbtrs");
    Console.WriteLine(scramble);
  }
}
