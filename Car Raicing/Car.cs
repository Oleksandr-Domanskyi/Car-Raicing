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
        protected int distance = 100;
        protected int Speed;
        public abstract void Driving();
        public abstract bool Finish();
    }
    public class Autobas : Car
    {
        public Autobas()
        {
            Speed = 10;
        }
        public override void Driving()
        {
            Speed += 10;
            distance -= Speed;
            if (Finish()) { System.Console.WriteLine($"Sport car rezult: Speed: {Speed}, Distance: 0"); }

            System.Console.WriteLine($"Autobas rezult: Speed: {Speed}, Distance: {distance}");
        }

        public override bool Finish()
        {
            if (distance <= 0) { System.Console.WriteLine($"Autobus is finished\t Total speed: {Speed}"); return true; }
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
            if (Finish()) { System.Console.WriteLine($"Sport car rezult: Speed: {Speed}, Distance: 0"); }

            Console.WriteLine($"LightCar rezult: Speed: {Speed}, Distance: {distance}");
        }

        public override bool Finish()
        {
            if (distance <= 0) { Console.WriteLine($"Light Car is finished\t Total speed: {Speed}"); return true; }
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
            if (Finish() == true) { System.Console.WriteLine($"Sport car rezult: Speed: {Speed}, Distance: 0"); }

            System.Console.WriteLine($"Sport car rezult: Speed: {Speed}, Distance: {distance}");
        }

        public override bool Finish()
        {
            if (distance <= 0) { distance = 0; System.Console.WriteLine($"Sport Car is finished\t Total speed: {Speed}"); return true; }
            distance = 0;
            return false;
        }
    }
}