using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nextLevel : MonoBehaviour
{
    Button nextbtn;
    // Use this for initialization
    void Start()
    {
        nextbtn = GetComponent<Button>();
        nextbtn.onClick.AddListener(movetoNextLevel);
        
    }

    // Update is called once per frame
    void movetoNextLevel()
    {
        if (chapterNumber2.chapterNumberHolder2.chapterNumber == 2)
        {
            if (level_Progress.LevelProgress.selectedLevel >= 1 &&
                level_Progress.LevelProgress.selectedLevel < 20 && 
                PlayerPrefs.GetInt("mygame_level2" + level_Progress.LevelProgress.selectedLevel) >= 1 )
            {
                statistics.statistics_setter.correctAnswerCount = 0;
                display_Result.Result_display.questionCount = 1;
                ++level_Progress.LevelProgress.selectedLevel;
                NextLevelSizeSetter.nextLevelQuestionSizeSetter.SetQuestionSize();
                Initiate.Fade("gameScreenTest2", Color.black, 5f);
            }
        }
        else if (chapterNUmber3.chapterNUmberHolder3.chapterNumber == 3)
        {
            if (level_Progress.LevelProgress.selectedLevel >= 1 &&
                level_Progress.LevelProgress.selectedLevel < 20 && 
                PlayerPrefs.GetInt("mygame_level3" + level_Progress.LevelProgress.selectedLevel) >= 1 )
            {
                statistics.statistics_setter.correctAnswerCount = 0;
                display_Result.Result_display.questionCount = 1;
                ++level_Progress.LevelProgress.selectedLevel;
                NextLevelSizeSetter.nextLevelQuestionSizeSetter.SetQuestionSize();
                Initiate.Fade("gameScreenTest3", Color.black, 5f);
            }
        }
        else
        {
            if (level_Progress.LevelProgress.selectedLevel >= 1 &&
                level_Progress.LevelProgress.selectedLevel < 20 && 
                PlayerPrefs.GetInt("mygame_level" + level_Progress.LevelProgress.selectedLevel) >= 1 )
            {
                statistics.statistics_setter.correctAnswerCount = 0;
                display_Result.Result_display.questionCount = 1;
                ++level_Progress.LevelProgress.selectedLevel;
                NextLevelSizeSetter.nextLevelQuestionSizeSetter.SetQuestionSize();
                Initiate.Fade("gameScreen", Color.black,5f);
            }
        }
                
    }
}