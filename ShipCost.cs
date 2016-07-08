using System;

class Shipping
{
  static void Main(){
    Console.WriteLine("This program will calculate your shipping cost.");
    Console.WriteLine("Please answer the following questions");
    Console.WriteLine("How much does the package weigh?");
    string enteredWeight = Console.ReadLine();
    int weight = int.Parse(enteredWeight);
    Console.WriteLine("How many miles is the package traveling?");
    string enteredMiles = Console.ReadLine();
    int miles = int.Parse(enteredMiles);
    int formula = miles / weight;
    int total = (formula / 3);
    string final = total.ToString();
    Console.WriteLine("Your total shipping cost will be " + "$" + final);
  }
}
