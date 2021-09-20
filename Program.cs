using System;
using System.Collections.Generic;
using Game.Models;

namespace Game {
  public class Program
  {
    public static void Main()
    {
      
      Console.WriteLine("Enter a number:  [or enter q to quit]");
      string stringNumber = Console.ReadLine();
      int number;
      if (stringNumber == "q" || stringNumber == "Q") {
        Console.WriteLine("Goodbye");
      } else if (int.TryParse(stringNumber, out number) && int.Parse(stringNumber) > 0) {
        List<string> pongList = PingPong.MakePongList(number);
        foreach (string item in pongList) {
          Console.WriteLine(item);
        }
        Main();
      } else {
        Console.WriteLine("Sorry, cannot read input. Please enter a positive integer or q to quit");
        Main();
      }
    }
  }
}

