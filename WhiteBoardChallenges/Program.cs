using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteBoardChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            ChallengeOne_Givenarray_TargetGiven challengeOne = new ChallengeOne_Givenarray_TargetGiven();
            challengeOne.RunChallengeOne();
            ChallengeTwo_Input_BoolIfPalindrome challengeTwo = new ChallengeTwo_Input_BoolIfPalindrome();
            challengeTwo.RunChallengeTwo();
            ChallengeThree_EnterInt_OutputReverseIntsReciprocal challengeThree = new ChallengeThree_EnterInt_OutputReverseIntsReciprocal();
            challengeThree.RunChallengeThree();
            ChallengeFour_CurrentComboNeededCombo_FastestTurnsToReachNeededCombo challengeFour = new ChallengeFour_CurrentComboNeededCombo_FastestTurnsToReachNeededCombo();
            challengeFour.RunChallengeFour();
        }
    }
}
