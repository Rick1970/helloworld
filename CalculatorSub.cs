using System;

class Subtract
{
  static void Main()
  {
    Console.WriteLine("Lets do some math.  Lets subtract.  Enter your first number");
    string firstNumber = Console.ReadLine();
    int first = int.Parse(firstNumber);
    Console.WriteLine("What is your second number?");
    string secondNumber = Console.ReadLine();
    int second = int.Parse(secondNumber);
    int total = first - second;
    string final = total.ToString();
    Console.WriteLine("Your total is " + final);
  }
}
