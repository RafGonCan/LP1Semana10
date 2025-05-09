using System;
using System.Runtime.CompilerServices;

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

        public override int GetHashCode ()
        {
            return PClass.GetHashCode () ^ Name.GetHashCode ();
        }

        public override bool Equals (object other)
        {
            bool equalsValue;
            Player otherPlayer = other as Player;

            if (otherPlayer == null)
            {
                equalsValue = true;
            }
            else if (PClass == otherPlayer.PClass && Name == otherPlayer.Name)
            {
                equalsValue = true;
            }
            else
            {
                return false;
            }
            
            return equalsValue;
        } 
    }
}