using System;
using System.Collections.Generic;

namespace Game.Models {

  public class PingPong
  {
    public static List<string> MakePongList(int number)
    {
      List<string> pongList = new List<string> {};
      for (int i = 1; i <= number; i++) {
        if (i % 3 == 0 && i % 5 == 0) {
          pongList.Add("ping-pong");
        } else if (i % 3 == 0) {
        pongList.Add("ping");
          } else if (i % 5 == 0) {
            pongList.Add("pong");
          } else {
            pongList.Add(i.ToString());
          }
        }
      return pongList;
    }
  }
}



