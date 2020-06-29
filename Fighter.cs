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
        public List<string> fightersNameLibrary;
        public List<string> fightRecord; // wins and losses stored here

        ////-.-.-.-.-.-.-.-.-.-.-.-.////

        public Fighter()
        {
        }



        public void randomSkillGenerator()
        {

        }

        public string fighterNameGenerator()
        {
            return "";
        }





    }




}   
