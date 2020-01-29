using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteBoardChallenges
{
    public class ChallengeTwo_Input_BoolIfPalindrome
    {
        //Member Variables (HAS A)
        StringBuilder sB = new StringBuilder();
        string userInput;
        string reverseInput;
        //Constructor
        public ChallengeTwo_Input_BoolIfPalindrome()
        {

        }

        //Member Methods (CAN DO)
        public bool RunChallengeTwo()
        {
            GetUserInput();
            GetRidOfSpace();
            BuildReverseWord();
            return CompareInputToReverse();
        }
        void GetUserInput()
        {
            Console.WriteLine("Please enter a word or Phrase.");
            userInput = Console.ReadLine();
        }
        void GetRidOfSpace()
        {
            for (int i = 0; i > userInput.Length; i++)
            {
                char character = userInput[i];
                if (character.Equals(" "))
                {
                    continue;
                }
                else
                {
                    sB.Append(character);
                }
            }
            userInput = sB.ToString();
        }
        void BuildReverseWord()
        {
            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                sB.Append(userInput[i]);
            }
            reverseInput = sB.ToString();
        }
        bool CompareInputToReverse()
        {
            if (userInput == reverseInput)
            {
                Console.WriteLine("True");
                Console.ReadLine();
                return true;
            }
            Console.WriteLine("False");
            Console.ReadLine();
            return false;
        }
    }
}
