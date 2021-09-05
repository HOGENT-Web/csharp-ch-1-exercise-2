# Chapter 1 - Exercise 2
##  Objectives
- Learn how to create a console application that takes user input
  - Using the `args` of the `Main` method.
  - Using `ReadLine`
- Learm how to use fuctions and control structures.
- Learn how to implement the Fibonnaci sequence.

## [Fibonnaci](https://www.c-sharpcorner.com/UploadFile/d0e913/the-fibonacci-numbers/)
### Definition

The Fibonacci Numbers is a sequence of numbers in the following order: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34... The next number is found by adding up the two numbers before it. The formula for calculating these numbers is:

F(n) = F(n-1) + F(n-2)

where:

F(n) is the term number.
F(n-1) is the previous term (n-1).
F(n-2) is the term before that (n-2). 
By definition, the first two numbers in the Fibonacci Sequence are either 0 and 1, or 1 and 1, depending on the chosen starting point of the sequence and each subsequent number is the sum of the previous two numbers.

### History
<details><summary>Show me the history</summary>
The Fibonacci numbers or Fibonacci sequence is a series of numbers named after a famous mathematician Leonardo Pisano (popularly known as Fibonacci), although he did not discover this sequence but used it as an example in his book Liber Abaci, which means "The Book of Calculations". The Fibonacci series was originally known in Indian Mathematics hundreds of years before he used it in his book.

Fibonacci Numbers in Real life Scenarios

The Fibonacci Numbers play a significant role in real life scenarios. Many of the numbers in the Fibonacci sequence can be related to the things that we see around us. These numbers are well represented in Honeybees. Honeybees, usually, lives in a colony called a Hive and they have a very unusual Family Tree. In a colony of honeybees, they are divided into three categories: 
- Queen: One special female bee in the colony is called the Queen and is the only female that produces eggs.
- Workers: The remaining female bees are workers in the colony and produce no eggs.
- Drones: The male bees do not work and are called Drone Bees.

Male bees are produced by the queen's unfertilized eggs, so they only have a mother but no father. All the female bees are produced when the queen has mated with a male bee and so have both the parents, mother as well as father. Most of the female bees cannot produce eggs and become worker bees but some of the lucky ones grow into queens and go off to start a new colony. So, female bees have two parents, a male and a female whereas male bees have just one parent, a female.

If we follow the family tree of Honeybees, it represents the Fibonacci sequence perfectly. A male bee has 1 parent, a female. He has 2 grandparents, a male and a female since his mother had two parents. He has 3 great-grandparents: his grandmother has two parents but his grandfather had only one."
</details>

> For more information about the Fibonnaci sequence, check out [this TED talk](http://www.ted.com/talks/arthur_benjamin_the_magic_of_fibonacci_numbers)!

## Exercise
- Use a `dotnet` command to create a new console application called `App`
- Do **NOT** remove all the boilerplate in `Program.cs` (you'll need it in the extra)
- Create a new `static` method which returns an `integer` called `CalculateFibonnaci` which takes an `integer` as parameter
- Implement the fibonnaci algorithm in the `CalculateFibonnaci` function. When you provide `5` as a parameter, the fibonnaci number should be returned, `5` in this case. 
- In the `Main` method: 
  - Ask the user to input a number and reading it into a variable using [`Console.ReadLine()`](https://www.geeksforgeeks.org/console-readline-method-in-c-sharp/).
  - Use the `CalculateFibonnaci` function to return the fibonacci number to the user. For example: 5 = 3, since it's the 5th number in the sequence.

### Extra
- Use the first parameters of the [`Main(string[] args)`](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/program-structure/main-command-line) to provide the number from the console. If the collection of arguments is empty, ask the user to provided the number.
> You should be able to use the following command to give the result of 3 : `dotnet run 5`

## Solution
- Use a `dotnet` command to create a new console application called `App`
  ```console
  dotnet new console -o App
  ```
- Do **NOT** remove all the boilerplate in `Program.cs` (you'll need it in the extra)
- Create a new `static` method which returns an `integer` called `CalculateFibonnaci` which takes an `integer` as parameter
  ```cs
  private static int CalculateFibonnaci(int sequence){
    // Implementation...
  }
  ```
- Implement the fibonnaci algorithm in the `CalculateFibonnaci` function. When you provide `5` as a parameter, the fibonnaci number should be returned, `5` in this case. 
  ```cs
  private static int CalculateFibonacci(int sequence)
  {
      int number1 = 0;
      int number2 = 1;
      int number = 0;

      switch (sequence)
      {
          case 0:
              number = number1;
              break;
          case 1:
              number = number2;
              break;
          default:
              {
                  for (int i = 3; i <= sequence; i++)
                  {
                      number = number1 + number2;
                      number1 = number2;
                      number2 = number;
                  }
                  break;
              }
      }
      return number;
  }
  ```
- In the `Main` method: 
  - Ask the user to input a number and reading it into a variable using [`Console.ReadLine()`](https://www.geeksforgeeks.org/console-readline-method-in-c-sharp/).
    ```cs
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the sequence number of the number to be calculated:");
        int sequence = int.Parse(Console.ReadLine());
    }
    ```
  - Use the `CalculateFibonnaci` function to return the fibonacci number to the user. For example: 5 = 3, since it's the 5th number in the sequence.
    ```cs
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Fibonnaci Sequence!");
        Console.WriteLine("Enter the sequence number of the number to be calculated:");
        int sequence = int.Parse(Console.ReadLine());
        Console.WriteLine("The number is {0}", CalculateFibonacci(sequence));
    }
    ```
### Extra
- Use the first parameters of the [`Main(string[] args)`](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/program-structure/main-command-line) to provide the number from the console. If the collection of arguments is empty, ask the user to provided the number.
  > You should be able to use the following command to give the result of 3 : `dotnet run 5`

  ```cs
  public static void Main(string[] args)
  {
      Console.WriteLine("Welcome to Fibonnaci Sequence!");
      if(args.Length == 1)
      {
          int sequence = int.Parse(args[0]);
          Console.WriteLine("The number is {0}", CalculateFibonacci(sequence));
      } else{
          Console.WriteLine("Enter the sequence number of the number to be calculated:");
          int sequence = int.Parse(Console.ReadLine());
          Console.WriteLine("The number is {0}", CalculateFibonacci(sequence));
      }
  }
  ```