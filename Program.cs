using System;
using System.Collections.Generic;
using Game.Models;

namespace Game {
  public class Program
  {
    public static void Main()
    {
      
      Console.WriteLine("Enter a number:  or enter q to quit");
      string stringNumber = Console.ReadLine();
      if (stringNumber == "q" || stringNumber == "Q") {
        Console.WriteLine("Goodbye");
      } else {
        int number = int.Parse(stringNumber);
        List<string> pongList = PingPong.MakePongList(number);
        foreach (string item in pongList) {
          Console.WriteLine(item);
        }
        Main();
      }
    }
  }
}

