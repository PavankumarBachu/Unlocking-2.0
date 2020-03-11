using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace NextLevelSizeSetter
{

    public class nextLevelQuestionSizeSetter : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        public static void SetQuestionSize()
        {
            if (level_Progress.LevelProgress.selectedLevel == 1)
            {
                level_Progress.LevelProgress.SelectLevel(1);
                clock_counter.CountdownScript.mainTimer = 3f;
                PatternGameNumberGenerator.Program.fqs = 3;
                PatternGameNumberGenerator.Program.sqs = 3;
                PatternGameNumberGenerator.Program.tqs = 3;
                PatternGameNumberGenerator.Program.disappearTime = PatternGameNumberGenerator.Program.tqs / 3;

            }
            else if (level_Progress.LevelProgress.selectedLevel == 2)
            {
                level_Progress.LevelProgress.SelectLevel(2);
                clock_counter.CountdownScript.mainTimer = 3f;
                PatternGameNumberGenerator.Program.fqs = 3;
                PatternGameNumberGenerator.Program.sqs = 3;
                PatternGameNumberGenerator.Program.tqs = 4;
                PatternGameNumberGenerator.Program.disappearTime = PatternGameNumberGenerator.Program.tqs / 3;
            }
            else if (level_Progress.LevelProgress.selectedLevel == 3)
            {
                level_Progress.LevelProgress.SelectLevel(3);
                clock_counter.CountdownScript.mainTimer = 3f;
                PatternGameNumberGenerator.Program.fqs = 3;
                PatternGameNumberGenerator.Program.sqs = 4;
                PatternGameNumberGenerator.Program.tqs = 4;
                PatternGameNumberGenerator.Program.disappearTime = PatternGameNumberGenerator.Program.tqs / 3;
            }
            else if (level_Progress.LevelProgress.selectedLevel == 4)
            {
                level_Progress.LevelProgress.SelectLevel(4);
                clock_counter.CountdownScript.mainTimer = 3f;
                PatternGameNumberGenerator.Program.fqs = 4;
                PatternGameNumberGenerator.Program.sqs = 4;
                PatternGameNumberGenerator.Program.tqs = 4;
                PatternGameNumberGenerator.Program.disappearTime = PatternGameNumberGenerator.Program.tqs / 3;
            }
            else if (level_Progress.LevelProgress.selectedLevel == 5)
            {
                level_Progress.LevelProgress.SelectLevel(5);
                clock_counter.CountdownScript.mainTimer = 4f;
                PatternGameNumberGenerator.Program.fqs = 4;
                PatternGameNumberGenerator.Program.sqs = 4;
                PatternGameNumberGenerator.Program.tqs = 5;
                PatternGameNumberGenerator.Program.disappearTime = PatternGameNumberGenerator.Program.tqs / 3;
            }

            else if (level_Progress.LevelProgress.selectedLevel == 6)
            {
                level_Progress.LevelProgress.SelectLevel(6);
                clock_counter.CountdownScript.mainTimer = 4f;
                PatternGameNumberGenerator.Program.fqs = 4;
                PatternGameNumberGenerator.Program.sqs = 5;
                PatternGameNumberGenerator.Program.tqs = 5;
                PatternGameNumberGenerator.Program.disappearTime = PatternGameNumberGenerator.Program.tqs / 3;
            }
            else if (level_Progress.LevelProgress.selectedLevel == 7)
            {
                level_Progress.LevelProgress.SelectLevel(7);
                clock_counter.CountdownScript.mainTimer = 4f;
                PatternGameNumberGenerator.Program.fqs = 5;
                PatternGameNumberGenerator.Program.sqs = 5;
                PatternGameNumberGenerator.Program.tqs = 5;
                PatternGameNumberGenerator.Program.disappearTime = PatternGameNumberGenerator.Program.tqs / 3;
            }
            else if (level_Progress.LevelProgress.selectedLevel == 8)
            {
                level_Progress.LevelProgress.SelectLevel(8);
                clock_counter.CountdownScript.mainTimer = 4f;
                PatternGameNumberGenerator.Program.fqs = 5;
                PatternGameNumberGenerator.Program.sqs = 5;
                PatternGameNumberGenerator.Program.tqs = 6;
                PatternGameNumberGenerator.Program.disappearTime = PatternGameNumberGenerator.Program.tqs / 3;
            }
            else if (level_Progress.LevelProgress.selectedLevel == 9)
            {
                level_Progress.LevelProgress.SelectLevel(9);
                clock_counter.CountdownScript.mainTimer = 4f;
                PatternGameNumberGenerator.Program.fqs = 5;
                PatternGameNumberGenerator.Program.sqs = 6;
                PatternGameNumberGenerator.Program.tqs = 6;
                PatternGameNumberGenerator.Program.disappearTime = PatternGameNumberGenerator.Program.tqs / 3;
            }
            else if (level_Progress.LevelProgress.selectedLevel == 10)
            {
                level_Progress.LevelProgress.SelectLevel(10);
                clock_counter.CountdownScript.mainTimer = 5f;
                PatternGameNumberGenerator.Program.fqs = 6;
                PatternGameNumberGenerator.Program.sqs = 6;
                PatternGameNumberGenerator.Program.tqs = 6;
                PatternGameNumberGenerator.Program.disappearTime = PatternGameNumberGenerator.Program.tqs / 3;
            }
            else if (level_Progress.LevelProgress.selectedLevel == 11)
            {
                level_Progress.LevelProgress.SelectLevel(11);
                clock_counter.CountdownScript.mainTimer = 5f;
                PatternGameNumberGenerator.Program.fqs = 6;
                PatternGameNumberGenerator.Program.sqs = 6;
                PatternGameNumberGenerator.Program.tqs = 7;
                PatternGameNumberGenerator.Program.disappearTime = PatternGameNumberGenerator.Program.tqs / 3;
            }
            else if (level_Progress.LevelProgress.selectedLevel == 12)
            {
                level_Progress.LevelProgress.SelectLevel(12);
                clock_counter.CountdownScript.mainTimer = 5f;
                PatternGameNumberGenerator.Program.fqs = 6;
                PatternGameNumberGenerator.Program.sqs = 7;
                PatternGameNumberGenerator.Program.tqs = 7;
                PatternGameNumberGenerator.Program.disappearTime = PatternGameNumberGenerator.Program.tqs / 3;
            }
            else if (level_Progress.LevelProgress.selectedLevel == 13)
            {
                level_Progress.LevelProgress.SelectLevel(13);
                clock_counter.CountdownScript.mainTimer = 5f;
                PatternGameNumberGenerator.Program.fqs = 7;
                PatternGameNumberGenerator.Program.sqs = 7;
                PatternGameNumberGenerator.Program.tqs = 7;
                PatternGameNumberGenerator.Program.disappearTime = PatternGameNumberGenerator.Program.tqs / 3;
            }
            else if (level_Progress.LevelProgress.selectedLevel == 14)
            {
                level_Progress.LevelProgress.SelectLevel(14);
                clock_counter.CountdownScript.mainTimer = 5.5f;
                PatternGameNumberGenerator.Program.fqs = 7;
                PatternGameNumberGenerator.Program.sqs = 7;
                PatternGameNumberGenerator.Program.tqs = 8;
                PatternGameNumberGenerator.Program.disappearTime = PatternGameNumberGenerator.Program.tqs / 3;
            }
            else if (level_Progress.LevelProgress.selectedLevel == 15)
            {
                level_Progress.LevelProgress.SelectLevel(15);
                clock_counter.CountdownScript.mainTimer = 5.5f;
                PatternGameNumberGenerator.Program.fqs = 7;
                PatternGameNumberGenerator.Program.sqs = 8;
                PatternGameNumberGenerator.Program.tqs = 8;
                PatternGameNumberGenerator.Program.disappearTime = PatternGameNumberGenerator.Program.tqs / 3;
            }
            else if (level_Progress.LevelProgress.selectedLevel == 16)
            {
                level_Progress.LevelProgress.SelectLevel(16);
                clock_counter.CountdownScript.mainTimer = 5.5f;
                PatternGameNumberGenerator.Program.fqs = 8;
                PatternGameNumberGenerator.Program.sqs = 8;
                PatternGameNumberGenerator.Program.tqs = 8;
                PatternGameNumberGenerator.Program.disappearTime = PatternGameNumberGenerator.Program.tqs / 3;
            }
            else if (level_Progress.LevelProgress.selectedLevel == 17)
            {
                level_Progress.LevelProgress.SelectLevel(17);
                clock_counter.CountdownScript.mainTimer = 5.5f;
                PatternGameNumberGenerator.Program.fqs = 8;
                PatternGameNumberGenerator.Program.sqs = 8;
                PatternGameNumberGenerator.Program.tqs = 9;
                PatternGameNumberGenerator.Program.disappearTime = PatternGameNumberGenerator.Program.tqs / 3;
            }
            else if (level_Progress.LevelProgress.selectedLevel == 18)
            {
                level_Progress.LevelProgress.SelectLevel(18);
                clock_counter.CountdownScript.mainTimer = 5.5f;
                PatternGameNumberGenerator.Program.fqs = 8;
                PatternGameNumberGenerator.Program.sqs = 9;
                PatternGameNumberGenerator.Program.tqs = 9;
                PatternGameNumberGenerator.Program.disappearTime = PatternGameNumberGenerator.Program.tqs / 3;
            }
            else if (level_Progress.LevelProgress.selectedLevel == 19)
            {
                level_Progress.LevelProgress.SelectLevel(19);
                clock_counter.CountdownScript.mainTimer = 5.5f;
                PatternGameNumberGenerator.Program.fqs = 9;
                PatternGameNumberGenerator.Program.sqs = 9;
                PatternGameNumberGenerator.Program.tqs = 9;
                PatternGameNumberGenerator.Program.disappearTime = PatternGameNumberGenerator.Program.tqs / 3;
            }
            else if (level_Progress.LevelProgress.selectedLevel == 20)
            {
                level_Progress.LevelProgress.SelectLevel(20);
                clock_counter.CountdownScript.mainTimer = 5.5f;
                PatternGameNumberGenerator.Program.fqs = 9;
                PatternGameNumberGenerator.Program.sqs = 9;
                PatternGameNumberGenerator.Program.tqs = 9;
                PatternGameNumberGenerator.Program.disappearTime = PatternGameNumberGenerator.Program.tqs / 3;
            }
        }
    }
}