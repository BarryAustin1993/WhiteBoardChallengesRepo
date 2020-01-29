using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteBoardChallenges
{
    public class ChallengeThree_EnterInt_OutputReverseIntsReciprocal
    {

        //Member Variables (HAS A)
        StringBuilder sB = new StringBuilder();
        string userInput;
        string reverseInput;
        double input;
        double final;
        readonly double one = 1;

        //Constructor
        public ChallengeThree_EnterInt_OutputReverseIntsReciprocal()
        {

        }

        //Member Methods (CAN DO)
        public double RunChallengeThree()
        {
            GetUserInput();
            ReverseInput();
            ConvertToInt();
            FinalAnswer();
            return final;
        }
        void GetUserInput()
        {
            Console.WriteLine("Please enter an Integer");
            userInput = Console.ReadLine();
        }
        void ReverseInput()
        {
            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                sB.Append(userInput[i]);
            }
            reverseInput = sB.ToString();
        }
        void ConvertToInt()
        {
            double.TryParse(reverseInput, out input);

        }
        void FinalAnswer()
        {
            final = one / input;
            Console.WriteLine("Your answer is " + final);
            Console.ReadLine();
        }

    }
}
