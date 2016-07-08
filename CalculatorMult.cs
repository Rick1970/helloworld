using System;

class Multiply
{
  static void Main()
  {
    Console.WriteLine("Lets do some math.  We will multiply.  Enter your first number");
    string firstNumber = Console.ReadLine();
    int first = int.Parse(firstNumber);
    Console.WriteLine("Enter your second number.");
    string secondNumber = Console.ReadLine();
    int second = int.Parse(secondNumber);
    int total = first * second;
    string final = total.ToString();
    Console.WriteLine("You total is " + final);
  }
}
