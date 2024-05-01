using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP_Assignment_2
{
    internal class Die
    {
        /*
         * The Die class should contain one property to hold the current die value,
         * and one method that rolls the die, returns and integer and takes no parameters.
         */
        public int rollValue { get; private set; }
        //Property
        //Makes a method to roll a dice
        public Die()
        {
            rollValue = 1;
        }
        public void diceRoll()
        {
            //Method
            //Creates a random object called 'random'
            Random random = new Random();
            //gets a random number from 1 to 6 and assigns it to a variable 'diceroll
            rollValue = random.Next(1, 7);
        }
    }
}

