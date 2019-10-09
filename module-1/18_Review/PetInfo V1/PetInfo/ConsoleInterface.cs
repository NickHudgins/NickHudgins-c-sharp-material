using System;
using System.Collections.Generic;
using System.Text;

namespace PetInfo
{
    public class ConsoleInterface
    {
        private string petType = "";
        private int numberOfPets = 0;
        private List<Pet> pets = new List<Pet>();

        public void Run()
        {
            PrintMenu();
            string selection = Console.ReadLine();

            string petType = "";
            int arraySize = 0;
            string[] pets = { "" };

            while (selection != "5")
            {

                switch (selection)
                {
                    case "1":
                        GetPetType();
                        break;

                    case "2":
                        GetPetCount();
                        break;

                    case "3":
                        EnterPetName();
                        break;
                    case "4":
                        DisplayPetInfo();
                        break;

                    default:
                        EndProgram();
                        break;

                }


                PrintMenu();
                selection = Console.ReadLine();
            }
        }

        private void PrintMenu()
        {
            Console.WriteLine("Please enter a choice:");
            Console.WriteLine("1 - Type of pet");
            Console.WriteLine("2 - Number of pets");
            Console.WriteLine("3 - Enter pet info");
            Console.WriteLine("4 - Show pet info");
            Console.WriteLine("5 - End program");
            return;
        }


        private void GetPetType()
        {
            Console.WriteLine();
            Console.WriteLine("Please enter a type of pet (dog, cat, parrot, etc.)");
            petType = Console.ReadLine();
            Console.WriteLine();
            return;

        }
        private void GetPetCount()
        {
            Console.WriteLine();
            Console.WriteLine("Please enter the number of pets");
            string petCount = Console.ReadLine();
            numberOfPets = int.Parse(petCount);

            Console.WriteLine();
            return;
        }
        private void EnterPetName()
        {
            Console.WriteLine();
            for (int i = 0; i < numberOfPets; i++)
            {
                Pet pet = new Pet();
                Console.WriteLine("Please enter a pet name:");

                pet.Name = Console.ReadLine();

                pets.Add(pet);
            }
            Console.WriteLine();
            return;
        }
        private void DisplayPetInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Pet Type: " + petType);
            Console.WriteLine("Pet Count: " + numberOfPets);
            Console.WriteLine("Please enter a pet name:");
            for (int i = 0; i < pets.Count; i++)
            {
                Console.WriteLine(pets[i]);
            }
            Console.WriteLine();
        }
        private void EndProgram()
        {
            Console.WriteLine();
            Console.WriteLine("Please make a valid selection.");
            Console.WriteLine();
        }
    }
}
