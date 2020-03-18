using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrestlingSim.Classes
{
    public enum moveType
    {
        Punch,
        Kick,
        Grapple,
        Toss,
        Submission
    }
    class Move
    {
        public string name { get; private set; }
        public moveType moveType { get; private set; }
        public int damage { get; private set; }
        public int accuracy { get; private set; }

        public Move(string name, moveType moveType, int damage, int accuracy)
        {
            this.name = name;
            this.moveType = moveType;
            this.damage = damage;
            this.accuracy = accuracy;
        }

        public string Attack(Wrestler wrestler, Wrestler opponent, moveType moveType)
        {
            Random rnd = new Random();
            switch (moveType)
            {
                case moveType.Punch:
                    this.damage = rnd.Next(5, 11);
                    this.accuracy = rnd.Next(1, 11);
                    if (this.accuracy > 3)
                    {
                        return wrestler.name + " punches " + opponent.name + " for " + this.damage;
                    }
                    return wrestler.name + " misses the punch!";
                case moveType.Kick:
                    this.damage = rnd.Next(10, 26);
                    this.accuracy = rnd.Next(1, 11);
                    if (this.accuracy > 5)
                    {
                        return wrestler.name + " kicks " + opponent.name + " for " + this.damage;
                    }
                    return wrestler.name + " misses the kick!";
                case moveType.Grapple:
                    this.damage = rnd.Next(20, 31);
                    this.accuracy = rnd.Next(1, 11);
                    if (this.accuracy > 6)
                    {
                        return wrestler.name + " gets " + opponent.name + " to the ground and deals " + this.damage;
                    }
                    return wrestler.name + " misses the grapple!";
                case moveType.Toss:
                    this.damage = rnd.Next(25, 41);
                    this.accuracy = rnd.Next(1, 11);
                    if (this.accuracy > 8)
                    {
                        return wrestler.name + " tosses " + opponent.name + " around and deals " + this.damage;
                    }
                    return wrestler.name + " misses the toss!";
                case moveType.Submission:
                    this.damage = 100;
                    this.accuracy = rnd.Next(1, 11);
                    if (this.accuracy == 10)
                    {
                        return opponent.name + " taps out!";
                    }
                    break;
                default:
                    break;
            }
            return "Move not found!";
        }
    }
}
