using System;
using System.Collections.Generic;
using System.Linq;

namespace muayThaiGame
{
    class Program
    {
        static void Main(string[] args)
        {
            


        }
    }

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

    class Trainer
    {
        public string name;
        public int skillRating;

        ////-.-.-.-.-.-.-.-.-.-.-.-.////    

        public Trainer()
        {
        }

        public void trainFighter()
        {

        }


    }

    class Match
    {
        public List<Fighter> matchActual; 
        ////-.-.-.-.-.-.-.-.-.-.-.-.////

        public Match()
        {
        }

        
    }




}   
