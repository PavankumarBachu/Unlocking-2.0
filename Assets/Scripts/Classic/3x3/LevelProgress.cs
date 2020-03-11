using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace level_Progress
{
    public class LevelProgress : MonoBehaviour
    {

        public static int selectedLevel;
        public void Start()
        {

        }

        public static void SelectLevel(int level)
        {
            selectedLevel = level;
        }

        public static void CompleteLevel()
        {
            if(chapterNumber2.chapterNumberHolder2.chapterNumber == 2)
            {
                if (PlayerPrefs.GetInt("mygame_level2" + selectedLevel) <= statistics.statistics_setter.correctAnswerCount)
                {
                    PlayerPrefs.SetInt("mygame_level2" + selectedLevel, statistics.statistics_setter.correctAnswerCount);
                }
                else
                {
                    PlayerPrefs.SetInt("mygame_level2" + selectedLevel, PlayerPrefs.GetInt("mygame_level2" + selectedLevel));
                }
            }
            else if(chapterNUmber3.chapterNUmberHolder3.chapterNumber ==3)
            {
                if (PlayerPrefs.GetInt("mygame_level3" + selectedLevel) <= statistics.statistics_setter.correctAnswerCount)
                {
                    PlayerPrefs.SetInt("mygame_level3" + selectedLevel, statistics.statistics_setter.correctAnswerCount);
                }
                else
                {
                    PlayerPrefs.SetInt("mygame_level3" + selectedLevel, PlayerPrefs.GetInt("mygame_level3" + selectedLevel));
                }
            }
            else
            {
                if (PlayerPrefs.GetInt("mygame_level" + selectedLevel) <= statistics.statistics_setter.correctAnswerCount)
                {
                    PlayerPrefs.SetInt("mygame_level" + selectedLevel, statistics.statistics_setter.correctAnswerCount);
                }
                else
                {
                    PlayerPrefs.SetInt("mygame_level" + selectedLevel, PlayerPrefs.GetInt("mygame_level" + selectedLevel));
                }

            }
        }
    }
}