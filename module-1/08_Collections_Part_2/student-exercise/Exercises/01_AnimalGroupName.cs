using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given the name of an animal, return the name of a group of that animal
         * (e.g. "Elephant" -> "Herd", "Rhino" - "Crash").
         *
         * The animal name should be case insensitive so "elephant", "Elephant", and
         * "ELEPHANT" should all return "herd".
         *
         * If the name of the animal is not found, null, or empty, return "unknown".
         *
         * Rhino -> Crash
         * Giraffe -> Tower
         * Elephant -> Herd
         * Lion -> Pride
         * Crow -> Murder
         * Pigeon -> Kit
         * Flamingo -> Pat
         * Deer -> Herd
         * Dog -> Pack
         * Crocodile -> Float
         *
         * AnimalGroupName("giraffe") → "Tower"
         * AnimalGroupName("") -> "unknown"
         * AnimalGroupName("walrus") -> "unknown"
         * AnimalGroupName("Rhino") -> "Crash"
         * AnimalGroupName("rhino") -> "Crash"
         * AnimalGroupName("elephants") -> "unknown"
         *
         */
        public string AnimalGroupName(string animalName)
        {
          
            Dictionary<string, string> animalGroups = new Dictionary<string, string>();

            animalGroups.Add("Rhino", "Crash");
            animalGroups.Add("Giraffe", "Tower");
            animalGroups.Add("Elephant", "Herd");
            animalGroups.Add("Lion", "Pride");
            animalGroups.Add("Crow", "Murder");
            animalGroups.Add("Pigeon", "Kit");
            animalGroups.Add("Flamingo", "Pat");
            animalGroups.Add("Deer", "Herd");
            animalGroups.Add("Dog", "Pack");
            animalGroups.Add("Crocodile", "Float");

            foreach (KeyValuePair<string, string> keyValuePair in animalGroups)
            {
                if(keyValuePair.Key.ToLower() == animalName.ToLower())
                {
                    return keyValuePair.Value;
                }
            }

            return "unknown";
        }
        

    }
}
