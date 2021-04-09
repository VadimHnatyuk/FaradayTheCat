using System;
using System.Collections.Generic;
using System.Text;

namespace FaradayTheCat
{
    public class Cat
    {
        public string Name { get; }
        public enum Gender { Male,Female };
        private double _energy;
        public static readonly double MaxEnergy = 20;
        public static readonly double MinEnergy = 0;
        public static readonly double SleepenergyGain = 10;
        public static readonly double JumpEnergyDrain = 0.5;
        
    
        public Gender Gen{ get; }

        public double Energy
        {
            get
            {
                return this._energy;
            }
            private set
            {
                if (value < MinEnergy)
                {
                    Console.WriteLine("Not enough energy to jump");
                    throw new Exception("Not enough energy to jump");
                    
                }else if (value> MaxEnergy)
                {
                    Console.WriteLine("MaxEnergy");
                    throw new Exception("Max energy");
                    _energy = MaxEnergy;
                    
                }
                else
                {
                    _energy = value;
                }
            }
        }

        public Cat(string name,Gender gen) {
            Name = name;
            Gen= gen;
            Energy = MaxEnergy;
        }

        public void Jump()
        {
            Energy -= JumpEnergyDrain;
            Console.WriteLine(_energy);
        }
        public void Sleep()
        {
            Energy+= SleepenergyGain;
            Console.WriteLine(_energy);
        }
    }
}
