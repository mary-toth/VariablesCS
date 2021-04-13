using System;
using VariablesCS.Models;
using System.Linq;

namespace VariablesCS
{
  class Program
  {
    static void Main(string[] args)
    {
       
      int numberOfCupsOfCoffee = 1;
      string fullName = "Mary Toth";
      var today = DateTime.Now;

      Console.WriteLine($"My name is {fullName} and I drank {numberOfCupsOfCoffee} cup of decaf coffee on {today}.");    
      
      Console.WriteLine("");
    
      Console.Write("Hi, what's your name? ");
      var userName = Console.ReadLine();
      var greeting = "Nice to meet you, " + userName; 

        if (userName == "Alice") {
        Console.WriteLine("Wow, your name is Alice!");
      } else {
        Console.WriteLine(greeting);
      }
        Console.WriteLine("");

        Console.Write("Please enter a number! ");
        var firstNumberAsString = Console.ReadLine();
        var firstOperand = double.Parse(firstNumberAsString);

        Console.Write("Now enter a second number. ");
        var secondNumberAsString = Console.ReadLine();
        var secondOperand = double.Parse(secondNumberAsString);

        Console.WriteLine("");

        Console.WriteLine($"The numbers you entered are {firstNumberAsString} and {secondNumberAsString}. Woohoo!");

        Console.WriteLine("");

        var sum = (firstOperand) + (secondOperand);
        var difference = (firstOperand) - (secondOperand);
        var product = (firstOperand) * (secondOperand);
        var quotient = (firstOperand) / (secondOperand);
        var remainder = (firstOperand) % (secondOperand);
      
        Console.WriteLine($"If you add {firstOperand} and {secondOperand}, you get {sum}.");
        Console.WriteLine($"If you subtract {firstOperand} and {secondOperand}, you get {difference}.");
        Console.WriteLine($"If you multiply {firstOperand} and {secondOperand}, you get {product}.");
        Console.WriteLine($"If you divide {firstOperand} and {secondOperand}, you get {quotient}.");
        Console.WriteLine($"The remainder of these numbers is {remainder}.");









       


    }
  }
}
