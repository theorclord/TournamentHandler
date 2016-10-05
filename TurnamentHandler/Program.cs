using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnamentHandler
{
  class Program
  {
    static void Main(string[] args)
    {
      Random ran = new Random();
      int numPlayers = 15;
      List<string> tournamentPlayers = new List<string>();

      for(int i = 0; i< numPlayers; i++)
      {
        tournamentPlayers.Add("P"+i);
      }
      
      // Shuffle players
      for(int i = 0; i < tournamentPlayers.Count; i++)
      {
        int pos = ran.Next(tournamentPlayers.Count);
        string tempPerson = tournamentPlayers[i];
        tournamentPlayers[i] = tournamentPlayers[pos];
        tournamentPlayers[pos] = tempPerson;
      }

      // set tournament line up
      for(int j = 0; j < tournamentPlayers.Count / 2; j++)
      {
        Console.WriteLine(tournamentPlayers[j * 2] + " - " + tournamentPlayers[j * 2 + 1]);
        if(tournamentPlayers.Count % 2 != 0 && j == tournamentPlayers.Count / 2-1)
        {
          Console.WriteLine(tournamentPlayers[(j+1)*2]);
        }
      }

      Console.ReadLine();
    }
  }
}
