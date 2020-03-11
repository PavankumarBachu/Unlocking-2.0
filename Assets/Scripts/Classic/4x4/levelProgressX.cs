using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace levelProgressX
{
    public class levelProgressX : MonoBehaviour
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
            
                if (PlayerPrefs.GetInt("mygame_levelx" + selectedLevel) <= statisticsx.statistics_Setter_4x.correctAnswerCount)
                {
                    PlayerPrefs.SetInt("mygame_levelx" + selectedLevel, statisticsx.statistics_Setter_4x.correctAnswerCount);
                }
                else
                {
                    PlayerPrefs.SetInt("mygame_levelx" + selectedLevel, PlayerPrefs.GetInt("mygame_levelx" + selectedLevel));
                }
        }
    }
}
