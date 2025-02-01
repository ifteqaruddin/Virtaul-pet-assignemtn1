using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Virtaul_pet_assignemtn1
{
    class Pet
    {
        static void Main(string[] args)
        { //  declaration of 3 varialbles
            string petType = " ";
            string petName = " ";
            int hunger = 6;
            int happiness = 4;
            int health = 2;

            //  all method created
            Console.WriteLine("Welcome to Virtual PET Game! ");
            Console.WriteLine("Please select the  pet type: ");
            Console.WriteLine("1. Cat");
            Console.WriteLine("2. Dog");
            Console.WriteLine("3. Rabbit");
            petType = Console.ReadLine();
            if (petType == "1")
            {
                Console.WriteLine("You have opted a Cat, what would you like to name your pet?");
            }
            else if (petType == "2") 
            {Console.WriteLine("You have opted a Dog, what would you like to name your pet?");
            }
            else if (petType == "3")
            {Console.WriteLine("You have  opted a Rabbit, what would you like to name your pet?");
            }
            else
            {
                Console.WriteLine("You have selected invalid option.");
            }
            petName = Console.ReadLine();

            Console.WriteLine("\nWelcome," + " " + petName + "." + "Lets take  care of him");

            //game loop starts
            while (true)
            {
                Console.WriteLine("-**********MENU*****----------");
                Console.WriteLine("             status of "+petName);
                Console.WriteLine("-**********MENU*****----------");
                Console.WriteLine("              Hunger:" + hunger);
                Console.WriteLine("           Happiness:" + happiness);
                Console.WriteLine("              Health:" + health);
                Console.WriteLine("\n");

                //   Action type
                Console.WriteLine("-***//////////////////////*****------");
                Console.WriteLine("              Main Menu                 ");
                Console.WriteLine("-***//////////////////////*****------");
                Console.WriteLine("           1.Feed " + petName);
                Console.WriteLine("           2.Play with " + petName);
                Console.WriteLine("           3.Let " + petName + " Rest");
                Console.WriteLine("           4.Exit");
                Console.WriteLine("-***//////////////////////*****------");
                string petAction = Console.ReadLine();


                if (petAction == "1")
                {
                    if (hunger > 0)
                    {
                        //Feed method
                        hunger -= 2;
                        if (hunger < 0)
                        {
                            hunger = 0;
                        }
                        health += 1;
                        if (health > 10)
                        {
                            health = 10;

                        }

                        Console.WriteLine(petName + " is fed,Hunger decreases and helath shows an increase. ");
                    }
                    else
                    {
                        Console.WriteLine(petName + " cant eat more food as it is full.");
                    }
                }
                //play method

                else if (petAction == "2")
                {

                    happiness += 2;
                    if (happiness > 10)
                    {
                        happiness = 10;
                    }
                    hunger += 1;
                    if (hunger > 10)
                    {
                        hunger = 10;
                    }
                    if (health != 0)
                    {
                        Console.WriteLine(petName + " is happy,increase happines and also hunger increases. ");
                    }


                }
                // Resting method
                else if (petAction == "3")
                {
                    health += 2;
                    if (health > 10)
                    {
                        health = 10;
                    }
                    happiness -= 1;
                    if (happiness < 0)
                    {
                        happiness = 0;
                    }
                    Console.WriteLine(petName + " is resting,helath imporves  but happines decreases. ");
                }
                // Exit method

                else if (petAction == "4")
                {
                    Console.WriteLine("exiting the game!");
                    break;
                }
                else
                {
                    Console.WriteLine("You have selected the wrong option.,please try again.");
                }

                if (health == 0)
                {
                    Console.WriteLine(petName + " PEt has died as health is zero,End of the game.");
                    break;
                }
                else
                {
                    if (happiness == 10)
                    {
                        Console.WriteLine(petName + " PEt has reached highest level of happiness. End of the game.");
                        break;
                    }
                    if (hunger == 10)
                    {
                        health -= 1;
                        if (health < 0)
                        {
                            health = 0;
                        }
                        Console.WriteLine(petName + " health is decreasing as it is very hungry.");
                    }

                    if (happiness == 0)
                    {
                        health -= 1;
                        if (health < 0)
                        {
                            health = 0;
                        }
                        Console.WriteLine(petName + " is  unhappy! ");
                    }
                }
                



            }
        }
    }
}