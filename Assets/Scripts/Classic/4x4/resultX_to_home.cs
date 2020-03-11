using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class resultX_to_home : MonoBehaviour {

    Button retrybtn;
    // Use this for initialization
    void Start()
    {
        retrybtn = GetComponent<Button>();
        retrybtn.onClick.AddListener(gotohome);
    }

    // Update is called once per frame
    void gotohome()
    {
        resultDisplayX.Result_displayX.questionCount = 1;
        statisticsx.statistics_Setter_4x.correctAnswerCount = 0;
        Initiate.Fade("Home", Color.black, 10f);
    }
}
