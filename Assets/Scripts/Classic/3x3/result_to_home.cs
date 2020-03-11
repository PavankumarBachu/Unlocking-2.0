using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class result_to_home : MonoBehaviour {
    public Button retrybtn;
    // Use this for initialization
    void Start()
    {
        retrybtn = GetComponent<Button>();
        retrybtn.onClick.AddListener(gotohome);

    }

    // Update is called once per frame
    void gotohome () {
        display_Result.Result_display.questionCount = 1;
        statistics.statistics_setter.correctAnswerCount = 0;
        Initiate.Fade("Home", Color.black, 10f);
	}
}
