using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class reslut_TO_ChapterScreens : MonoBehaviour {
    Button backbtn;
	// Use this for initialization
	void Start () {
        backbtn = GetComponent<Button>();
        backbtn.onClick.AddListener(goToChapter);
	}
	
	// Update is called once per frame
	void goToChapter() {
        statistics.statistics_setter.correctAnswerCount = 0;
        detect_touch.Touch_detect.judjement = true;
        detect_touch.Touch_detect.done = false;
        display_Result.Result_display.questionCount = 1;
        if (chapterNumber2.chapterNumberHolder2.chapterNumber == 2)
        {
            Initiate.Fade("chapterScreen2", Color.black, 10f);
        }
        if(chapterNUmber3.chapterNUmberHolder3.chapterNumber == 3)
        {
            Initiate.Fade("chapterScreen2", Color.black, 10f);
        }
        else
        {
            Initiate.Fade("chapterScreen", Color.black, 10f);
        }
	}
}
