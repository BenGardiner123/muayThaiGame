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

    class Menu
    {
        public Menu()
        {
        }

        ///pick fighter - coose name and speciality

        //choose your gym and trainer

        ///choose how many rounds

        ///fight


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
        public List<string> fightersNameLibrary;

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

    class Gym
    {
        public string gymName;
        public int trainerSkillRating;

        ////-.-.-.-.-.-.-.-.-.-.-.-.////    

        public Gym()
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

        public void FightActual()
        {

        }

    }




}   
