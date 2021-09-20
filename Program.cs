using System;
using System.Collections.Generic;
using Game.Models;

namespace Game {
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a number: ");
      string stringNumber = Console.ReadLine();
      int number = int.Parse(stringNumber);
      List<string> pongList = PingPong.MakePongList(number);
      foreach (string item in pongList) {
        Console.WriteLine(item);
      }
    }
  }
}

