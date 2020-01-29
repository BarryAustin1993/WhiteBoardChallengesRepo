using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteBoardChallenges
{
    class ChallengeFour_CurrentComboNeededCombo_FastestTurnsToReachNeededCombo
    {

        //Member Variables (HAS A)
        readonly string currentLock = "3893";
        readonly string targetLock = "5296";
        int currentLockInt;
        int targetLockInt;
        int leftTurn;
        int rightTurn;
        string message;
        //Constructor

        //Member Methods (CAN DO)
        public void RunChallengeFour()
        {
            DetermineTheCorrectTurn();
        }
        void DetermineTheCorrectTurn()
        {
            for (int i = 0; i < currentLock.Length; i++)
            {
                Int32.TryParse(currentLock[i].ToString(), out currentLockInt);
                Int32.TryParse(targetLock[i].ToString(), out targetLockInt);
                CompareCurrentAndTargetInts();
                Console.WriteLine($"{i}. {message}");
            }
            Console.ReadLine();
        }
        void CompareCurrentAndTargetInts()
        {
            if (currentLockInt > targetLockInt)
            {
                DetermineAmountOfTurnsWhenCurrentLockIsLarger();
            }
            else if (currentLockInt < targetLockInt)
            {
                DetermineAmountOfTurnsWhenCurrentLockIsSmaller();
            }
            else if (currentLockInt == targetLockInt)
            {
                message = "Do not change the lock it is already correct";
            }
        }
        void DetermineAmountOfTurnsWhenCurrentLockIsLarger()
        {
            leftTurn = currentLockInt - targetLockInt;
            rightTurn = 10 - leftTurn;
            TellUserWhichWayAndHowMuchToTurn();
        }
        void DetermineAmountOfTurnsWhenCurrentLockIsSmaller()
        {
            rightTurn = targetLockInt - currentLockInt;
            leftTurn = 10 - rightTurn;
            TellUserWhichWayAndHowMuchToTurn();
        }
        void TellUserWhichWayAndHowMuchToTurn()
        {
            if (leftTurn < rightTurn)
            {
                message = $"Turn left {leftTurn} times.";
            }
            else if (rightTurn < leftTurn)
            {
                message = $"Turn right {rightTurn} times.";
            }
            else
            {
                message = $"Turn either way {rightTurn} times.";
            }
        }
    }
}
