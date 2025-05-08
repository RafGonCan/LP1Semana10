using System;

namespace EqualPlayer
{
    public class Player
    {
        public PLayerClass PClass {get;}
        public string Name {get;}
        public Player (PLayerClass pClass, string name)
        {
            PClass = pClass;
            Name = name;
        }
    }
}