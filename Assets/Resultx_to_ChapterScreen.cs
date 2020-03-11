using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Resultx_to_ChapterScreen : MonoBehaviour {

    Button backbtn;
	// Use this for initialization
	void Start () {
        backbtn = GetComponent<Button>();
        backbtn.onClick.AddListener(goToChapter);
	}
	
	// Update is called once per frame
	void goToChapter () {
        statisticsx.statistics_Setter_4x.correctAnswerCount = 0;
        detectTouchx.Touch_detectX.judjement = true;
        detectTouchx.Touch_detectX.done = false;
        resultDisplayX.Result_displayX.questionCount = 1;
        Initiate.Fade("chapterScreen4x", Color.black, 10f);
	}
}

