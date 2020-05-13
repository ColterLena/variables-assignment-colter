using System;

namespace variables_assignment_colter
{
  class Program
  {
    static void Main(string[] args)
    {
      int numberOfCupsOfCoffee = 1;
      string fullName = "Colter Lena";
      string today = "May 12, 2020";
      var combinedVariables = $"{numberOfCupsOfCoffee}, {fullName}, and {today}";
      Console.WriteLine (combinedVariables);

      Console.WriteLine ("What is you name? ");
      var userName = Console.ReadLine();

      var greeting = $"It's a pleasure to meet you, {userName}.";
      Console.WriteLine(greeting);

      Console.WriteLine ("Please pick a number between 1 and 100. ");
      var firstNumberAsString = Console.ReadLine();

      double firstOperand = double.Parse(firstNumberAsString);

      Console.WriteLine ("Please pick another number between 1 and 100. ");
      var secondNumberAsString = Console.ReadLine();

      double secondOperand = double.Parse(secondNumberAsString);

      var sum = $"{firstOperand + secondOperand}";
      
      var difference = $"{firstOperand - secondOperand}";

      var product = $"{firstOperand * secondOperand}";

      var quotient = $"{firstOperand / secondOperand}";

      var remainder = $"{firstOperand % secondOperand}";

      var mathCalculations = $"The sum of {firstOperand} and {secondOperand} is {sum}. The difference of {firstOperand} and {secondOperand} is {difference}. The product of {firstOperand} and {secondOperand} is {product}. The quotient of {firstOperand} and {secondOperand} is {quotient}. The remainder when {firstOperand} is divided by {secondOperand} is {remainder}.";

      Console.WriteLine (mathCalculations);
    }
  }
}
