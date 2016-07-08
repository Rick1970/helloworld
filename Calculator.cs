using System;

class Calculator
{
  static void Main()
  {
    Console.WriteLine("Lets do some math. Lets add.  Input your first number");
    string firstNumber = Console.ReadLine();
    int first = int.Parse(firstNumber);
    Console.WriteLine("Input your second number.");
    string secondNumber = Console.ReadLine();
    int second = int.Parse(secondNumber);
    int totalNumber = first + second;
    string final = totalNumber.ToString();
    Console.WriteLine("Your total is " + final);


  }
}
