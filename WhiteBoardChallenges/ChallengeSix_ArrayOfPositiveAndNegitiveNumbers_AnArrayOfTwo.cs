using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteBoardChallenges
{
    public class ChallengeSix_ArrayOfPositiveAndNegitiveNumbers_AnArrayOfTwo
    {

        //Member Variables (HAS A)
        List<double> caseOne = new List<double> {7, 9, -3, -32, 107, -1, 36, 95, -14, -99, 21};
        double[] result = new double[2];
        double positives;
        double negitives;
        //Constructor
        public ChallengeSix_ArrayOfPositiveAndNegitiveNumbers_AnArrayOfTwo()
        {

        }


        //Member Methods (CAN DO)
        public void RunChallengeSix()
        {
            TallyTheIntsOfAGivenList();
            CreateResultsArray();
            ShowArray();
        }
        void TallyTheIntsOfAGivenList()
        {
            for (int i = 0; i < caseOne.Count; i++)
            {
                if(caseOne[i] < 0)
                {
                    negitives += caseOne[i];
                }
                else if (caseOne[i] > 0)
                {
                    positives++;
                }
                else
                {
                    continue;
                }
            }
        }
        void CreateResultsArray()
        {
            result[0] = positives;
            result[1] = negitives;
        }
        void ShowArray()
        {
            foreach (double item in result)
            {
                Console.WriteLine(item);   
            }
            Console.ReadLine();
        }

    }
}
