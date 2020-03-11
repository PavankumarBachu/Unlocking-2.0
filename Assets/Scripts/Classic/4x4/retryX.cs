using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class retryX : MonoBehaviour {

    Button retrybtn;
    // Use this for initialization
    void Start()
    {
        retrybtn = GetComponent<Button>();
        retrybtn.onClick.AddListener(Load);

    }

    // Update is called once per frame
    void Load()
    {
        resultDisplayX.Result_displayX.questionCount = 1;
        statisticsx.statistics_Setter_4x.correctAnswerCount = 0;
        detectTouchx.Touch_detectX.judjement = true;
        detectTouchx.Touch_detectX.done = false;
        Initiate.Fade("gameScreen_4x", Color.black, 5f);
    }
}
