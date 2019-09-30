﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    /**
    * This class represents a dog that can sleep, wake, and make a sound, so it's pretty much like most dogs,
    * with a few essential methods missing. Thankfully.
    */
    public class Dog
    {
        public bool IsSleeping {get;} 
        
        public Dog()
        {

        }

        public string MakeSound()
        {
            if (IsSleeping)
            {
                return "Zzzzz...";
            } 
            else
            {
                return "Woof!";
            }
        }

        public void Sleep() 
        {
            
        }
        public void WakeUp()
        {

        }


    }
}
