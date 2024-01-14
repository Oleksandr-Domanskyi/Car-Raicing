using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Car_Raicing
{
    public abstract class Car
    {
        protected static int position = 0;
        public int distance = 100;
        public int Speed;

        public delegate void Winner();
        protected Winner _winner;
           public void RegisterWinner(Winner winner)
        {
            _winner = winner;
        }

        public abstract void Driving();
        public abstract bool Finish();
        public static void Win()
        {
            if(position<=3)
            System.Console.WriteLine($"Winner position: {position}");
        }   
    }
    public class Autobas : Car
    {
        public Autobas()
        {
            Speed = 10;
        }
        public override void Driving()
        {
            Speed += 50;
            distance -= Speed;
            if (Finish()) { position++;_winner(); System.Console.WriteLine($"Autobas car rezult: Speed: {Speed}, Distance: 0"); }
            else
            {
                System.Console.WriteLine($"Autobas rezult: Speed: {Speed}, Distance: {distance}");
            }
        }

        public override bool Finish()
        {
            if (distance <= 0) return true;
            return false;
        }
    }
    public class LightCar : Car
    {
        public LightCar()
        {
            Speed = 40;
        }
        public override void Driving()
        {
            Speed += 30;
            distance -= Speed;
            if (Finish()) { position++; _winner(); System.Console.WriteLine($"Light car finished: Speed: {Speed}, Distance: 0"); }
            else
            {
                Console.WriteLine($"LightCar rezult: Speed: {Speed}, Distance: {distance}");
            }
        }

        public override bool Finish()
        {
            if (distance <= 0) { distance = 0; return true; }

            return false;
        }
    }
    public class SportCar : Car
    {
        public SportCar()
        {
            Speed = 50;
        }
        public override void Driving()
        {
            Speed += 40;
            distance -= Speed;
            if (Finish() == true) { position++; _winner(); System.Console.WriteLine($"Sport car finished: Speed: {Speed}, Distance: 0"); }
            else
            {
                System.Console.WriteLine($"Sport car rezult: Speed: {Speed}, Distance: {distance}");
            }
        }

        public override bool Finish()
        {
            if (distance <= 0) { distance = 0; return true; }
            return false;
        }
    }
}