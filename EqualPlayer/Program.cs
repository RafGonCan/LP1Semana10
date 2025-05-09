using System;
using System.Collections.Generic;

namespace EqualPlayer
{
    public class Program
    {
        private static void Main(string[] args)
        {
            HashSet<Player> setOfPlayers = new HashSet<Player> ()
            {
                new Player(PLayerClass.Tank, "Ana"),
                new Player(PLayerClass.Slayer, "Paulo"),
                new Player(PLayerClass.Tank, "Ana")
            };

            foreach (Player p in setOfPlayers)
            {
                Console.WriteLine($"{p.Name} is a {p.PClass}");
            }
        }
    }
}
