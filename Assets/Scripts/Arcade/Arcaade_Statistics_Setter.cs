using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace arcadestatistics
{
    public class Arcaade_Statistics_Setter : MonoBehaviour
    {

        public static int correctAnswerCount = 0;
        public Text answerCount;
        // Use this for initialization
        void Start()
        {
            answerCount = GetComponent<Text>();
            highScoresetting.highScoreSetter.saveScore();
            answerCount.text = (correctAnswerCount * 100).ToString();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                correctAnswerCount = 0;
                arcadedetecttouch.Arcade_Touch_Detect.input_enabled = false;
                arcadedetecttouch.Arcade_Touch_Detect.judjement = true;
                arcadedetecttouch.Arcade_Touch_Detect.done = false;
                arcadecountdown.Arcade_Countdown_Script.curenttime = 60;
                Initiate.Fade("Arcade_Lvl_Difficulty", Color.gray, 20f);               
            }
        }
    }
}