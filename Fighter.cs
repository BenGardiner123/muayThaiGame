using System;
using System.Collections.Generic;

namespace muayThaiGame
{
    class Fighter
    {
        public string firstName;
        public string lastName;
        public string weight;
        public string height;
        public int power;
        public int kick;
        public int punch;
        public int knee;
        public int elbow;
        public int clinch;
        Random skillGenerator = new System.Random();
        public List<KeyValuePair<string, int>> fightersAttribute;
        public List<string> fighterstFirstNameLibrary;
        public List<string> fighterstLastNameLibrary;
        
        public List<KeyValuePair<string, int>> fightRecord; // wins and losses stored here

        ////-.-.-.-.-.constructor-.-.-.-.-.-.-.////

        public Fighter(string fName, string lName)
        {
          this.firstName = fName;
          this.lastName = lName;


        fighterstFirstNameLibrary.AddRange(new string[]
        {
        "Diesel",
        "Samart",
        "Namsaknoi",
        "Sangtiennoy",
        "Jomjod",
        "Tongchai",
        "Pen Ake",
        "Baukaw",
        "Singmanee",
        "Khem",
        "Seanchai"
        });
        

        fighterstLastNameLibrary.AddRange(new string[]
        {
        "Sitsongpeenong",
        "Payakaroon",
        "Kiatmoo",
        "Eminent-Air",
        "Silachai", 
        "Sitnumnoi",
        "Sor.Vorapin",
        "Fairtex",
        "Sor. Kingstar",
        "Sitboonmee"
        });
        
        }

        public void randomSkillGenerator()
        {

        }

        public void userFighterName()
        {
        
            Console.WriteLine("Please enter your fighters first name...");
            string userFirstName = Console.ReadLine();
            Console.WriteLine("Please enter your fighters last name...");
            string userLastName = Console.ReadLine();
            
            userFirstName= this.firstName;
            userLastName = this.lastName;
           
        }

        public void randomNameGenerator()
        {
                fighterstFirstNameLibrary.AddRange(new string[]
                {
                "Jenna Doe",
                "Another Doe"
                });
           
        }

        
        public void createFighter()
        {
            bool menuCheck = false; // again set up the exit trigger
           
            while (!menuCheck)
            {
                
                Console.WriteLine("1. Choose you fighters name");
                Console.WriteLine("2. Auto select a name");
                Console.WriteLine("3. Generate you abilities");
                Console.WriteLine("4. Exit to main menu");
                string userChoice = Console.ReadLine(); // need to try parse

                int result = 0;
                if (int.TryParse(userChoice, out result)) //so if the user input is parseable its a number
                {
                    
                    if (result <= 0)
                    {
                        Console.WriteLine (userChoice + "....oh.... thats not a valid input" + " Only the numbers 1, 2 or 3 - please... try again");
                    }
                    if (result == 1)
                    {
                        Fighter f1 = new Fighter("", "");
                        userFighterName();


                    }
                    if (result == 2)
                    {
                        ();
                    }
                    else if (result == 3)
                    {
                        viewFighterRecord();
                    }
                    else if (result == 4)
                    {
                        menuCheck = true;
                        mainMenu();
                    }


                }
                else /// so if the parse fails it must be letters or something else
                {
                    Console.WriteLine (userChoice + "....oh.... thats not a valid input" + " only input the number 1, 2 or 3 - please... try again");
                }




            }
        }
        

        public void viewFighterAttributes()
        {

        }

        public void viewFighterRecord()
        {

        }



    }




}   
