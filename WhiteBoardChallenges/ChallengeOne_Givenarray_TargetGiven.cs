using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteBoardChallenges
{
    class ChallengeOne_Givenarray_TargetGiven
    {

        //Member Variables (HAS A)
        int[] addendOne = new int[] { 5, 17, 77, 50 };
        int[] addendTwo = new int[] { 5, 17, 77, 50 };
        int target = 55;
        //Constructor
        ChallengeOne_Givenarray_TargetGiven()
        {

        }

        //Member Methods (CAN DO)
        public int RunChallengeOne()
        {
            for (int i = 0; i < addendOne.Length; i++)
            {
                for (int j = 0; j < addendTwo.Length; j++)
                {
                    int result = addendOne[i] + addendOne[j];
                    if ( i == j)
                    {
                        continue;
                    }  
                    else if (result == target)
                    {
                        return addendOne[i] + addendTwo[j];
                    }

                }
            }
             throw new Exception("Given numbers do not add up to target.");
        } 
    }
}
