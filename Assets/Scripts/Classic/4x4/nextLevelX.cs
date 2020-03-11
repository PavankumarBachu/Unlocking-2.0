using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nextLevelX : MonoBehaviour {

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

        if(levelProgressX.levelProgressX.selectedLevel >= 1 &&
                levelProgressX.levelProgressX.selectedLevel <= 20 && 
                PlayerPrefs.GetInt("mygame_levelx" + levelProgressX.levelProgressX.selectedLevel) >= 1)
        {
            statisticsx.statistics_Setter_4x.correctAnswerCount = 0;
            resultDisplayX.Result_displayX.questionCount = 1;
            ++levelProgressX.levelProgressX.selectedLevel;
            NextLevelSizeSetter.nextLevelQuestionSizeSetter.SetQuestionSize();
            Initiate.Fade("gameScreen_4x", Color.black, 5f);
        }
        
        
    }
}
