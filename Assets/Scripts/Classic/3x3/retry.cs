using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
public class retry : MonoBehaviour {
    Button retrybtn;
	// Use this for initialization
	void Start () {
        retrybtn = GetComponent<Button>();
        retrybtn.onClick.AddListener(Load);
        
    }
	
	// Update is called once per frame
	void Load () {
        display_Result.Result_display.questionCount = 1;
        statistics.statistics_setter.correctAnswerCount = 0;
        detect_touch.Touch_detect.judjement = true;
        detect_touch.Touch_detect.done = false;
        if (chapterNumber2.chapterNumberHolder2.chapterNumber == 2)
            Initiate.Fade("gameScreenTest2", Color.black, 5f);
        else if (chapterNUmber3.chapterNUmberHolder3.chapterNumber == 3)
            Initiate.Fade("gameScreenTest3", Color.black, 5f);
        else
            Initiate.Fade("gameScreen", Color.black, 5f);
    }
}
