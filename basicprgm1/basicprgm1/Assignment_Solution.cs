using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicprgm1
{
    internal class Animals
    {
        private int chickens;
        private int cows;
        private int pigs;

        public Animals(int chickens, int cows, int pigs)
        {
            this.Chickens = chickens;
            this.Cows = cows;
            this.Pigs = pigs;
        }

        public int Chickens { get => chickens; set => chickens = value; }
        public int Cows { get => cows; set => cows = value; }
        public int Pigs { get => pigs; set => pigs = value; }

        public int count_legs()
        {
            int result = (this.Chickens * 2) + (this.Cows * 4) + (this.Pigs * 4);
            return result;
        }
    }


    internal class Football
    {
        private int wins;
        private int draws;
        private int losses;

        public int Wins { get => wins; set => wins = value; }
        public int Draws { get => draws; set => draws = value; }
        public int Losses { get => losses; set => losses = value; }

        public int FootballPoints(int wins, int draws, int losses)
        {
            int result = (wins * 3) + (draws * 1) + (losses * 0);
            return result;
        }
    }


    internal class program
    {
        private double prob;
        private int prize;
        private int pay;

        public double Prob { get => prob; set => prob = value; }
        public int Prize { get => prize; set => prize = value; }
        public int Pay { get => pay; set => pay = value; }

        public bool Programs (double prob, int prize, int pay)
        {
            if (prob * prize > pay)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }


    internal class Box
    {
        private int number;

        public int Number { get => number; set => number = value; }

        public int StackBoxes(int number)
        {
            return number * number;
        }
    }



    internal class Bartender
    {
        private int age;
        private bool breaktime;

        public int Age { get => age; set => age = value; }
        public bool Breaktime { get => breaktime; set => breaktime = value; }

        public bool ShouldServeDrinks(int age, bool breaktime)
        {
            if ((age >= 18) && (breaktime == false))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }



    internal class Coffee
    {
        private int cups;

        public int Cups { get => cups; set => cups = value; }

        public int TotalCups(int cups)
        {
            int total_cups = (cups / 6) + cups;
            return total_cups;
        }
    }



    internal class AddingString
    {
        public void Addstring(string[] words, string addon)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i] + addon;
            }

            for (int i = 0; i < words.Length; i++)
            {
                Console.Write(words[i] + " ");
            }
        }
    }



    internal class Arrange
    {
        public int PosCom(int number)
        {
            return (int)Math.Pow(5, number);
        }
    }



}
