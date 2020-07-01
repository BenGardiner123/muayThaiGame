using System.Linq;

namespace muayThaiGame
{
    class Program
    {
        static void Main(string[] args)
        {
            


        }
    }

    class Menu
    {
        public Menu()
        {
            ///this is the construcor
        }

        public void mainMenu()
        {
            
             
            ///think i need to have some kind of condition here to catch the exit button--- so keep coming back to the top here and choosing numbers unitl "5" gets enetered.
            int validInput = 0; // this is going to be the menu num
            while (validInput != 4)
            {
                Console.WriteLine("");
                Console.WriteLine("Welcome to the Muay Thai fighting game");
                Console.WriteLine("1. Create your Fighter");
                Console.WriteLine("2. Fight at a stadium");
                Console.WriteLine("3. Select your Gym and Trainer ");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Please make a selection");

                bool goOn = false; // exit value for my while loop
                while (!goOn)
                {
                    string userInput = Console.ReadLine(); // store the user choice from the menu
                    
                    if (int.TryParse(userInput, out validInput)) /// so this will test whether the input is parsable - if not then it should go to the else and then give them the message and then return to the top
                    {
                        if (validInput >= 0 &&  validInput <= 3) //so here is the first test - need to check that the number is in the range of the menu - so need to set something at the top.
                        {
                          goOn = true;
                        }    
                        else // if it comes here that means that the result was not greater than 0... so a -1 etc... we cant have that so
                        {
                            Console.WriteLine (  " Only numbers please " + " Please choose a number from the menu.. try again");
                        }

                    }
                    else
                    {
                        Console.WriteLine(" .... really? " + " Please enter just a number.. no words .. try again"); /// again thsi catches the non - numercial input.
                    }

                }
                
                if (validInput == 1)
                {
                  createFighterMenu();
                    
                }
                else if (validInput == 2)
                {
                   fightCondtitionsMenu(); 
                }
                /// 4.	Upon pressing “3” user is prompted to enter numbers one by one to check if they have been drawn
                else if (validInput == 3)
                {
                   chooseGymandTrainerMenu();
                }                
                else if (validInput == 4)
                {
                     Environment.Exit(0); 
                }

            }


        }
    

        public void createFighterMenu()
        {

            bool menuCheck = false; // again set up the exit trigger
            
            while (!menuCheck)
            {
                
                Console.WriteLine("1. Create your Fighter");
                Console.WriteLine("2. View your Fighter Attributes");
                Console.WriteLine("3. Veiw your Fighters record and belts");
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
                        createFighter();
                    }
                    if (result == 2)
                    {
                        viewFighterAttributes();
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


        public void chooseGymandTrainerMenu(){

        }  

        public void fightCondtitionsMenu(){

        }  


        public void letsActuallyFight(){

        }  


     


    }




}   
