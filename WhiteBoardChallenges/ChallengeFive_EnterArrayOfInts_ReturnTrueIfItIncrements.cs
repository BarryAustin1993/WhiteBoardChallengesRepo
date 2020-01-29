using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteBoardChallenges
{

    public class ChallengeFive_EnterArrayOfInts_ReturnTrueIfItIncrements
    {
        //Member Variables (HAS A)
        List<int> caseOne = new List<int> { 5, 7, 3, 8, 6 };
        List<int> caseTwo = new List<int> { 17, 15, 20, 19, 21, 16, 18 };
        int originalDifference;
        //Constructor
        public ChallengeFive_EnterArrayOfInts_ReturnTrueIfItIncrements()
        {

        }

        //Member Methods (CAN DO)
        public bool RunChallengeFive()
        {
            SortArratInNumericalOrder();
            bool confirmed = CompareNextIntForDifference();
            if (confirmed == true)
            {
                Console.WriteLine("It is true");
                Console.ReadLine();
                return true;
            }
            Console.WriteLine("It is not true");
            Console.ReadLine();
            return false;
        }
        void SortArratInNumericalOrder()
        {
            caseTwo.Sort();
        }
        bool CompareNextIntForDifference()
        {
            originalDifference = caseTwo[2] - caseTwo[1];
            for (int i = 0; i < caseTwo.Count - 1; i++)
            {
              int currentDifference = caseTwo[i + 1] - caseTwo[i];
                if (currentDifference != originalDifference)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
