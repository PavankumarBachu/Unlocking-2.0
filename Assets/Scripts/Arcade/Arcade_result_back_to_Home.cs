using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Arcade_result_back_to_Home : MonoBehaviour {

    public Button back_btn;
    // Use this for initialization
    void Start()
    {
        back_btn = GetComponent<Button>();
        back_btn.onClick.AddListener(goToScoreArea);
    }

    // Update is called once per frame
    void goToScoreArea()
    {
        arcadestatistics.Arcaade_Statistics_Setter.correctAnswerCount = 0;
        arcadedetecttouch.Arcade_Touch_Detect.input_enabled = false;
        arcadedetecttouch.Arcade_Touch_Detect.judjement = true;
        arcadedetecttouch.Arcade_Touch_Detect.done = false;
        arcadecountdown.Arcade_Countdown_Script.curenttime = 60;
        Initiate.Fade("HOME", Color.black, 10f);
    }
}
