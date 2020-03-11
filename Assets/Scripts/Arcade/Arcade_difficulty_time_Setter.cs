using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace arcade_difficulty_setter
{

    public class Arcade_difficulty_time_Setter : MonoBehaviour
    {
        public Button lvlbtn;
        // Use this for initialization
        void Start()
        {
            lvlbtn = GetComponent<Button>();
            lvlbtn.onClick.AddListener(OnMouseDown);
        }
        private void Update()
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                arcadestatistics.Arcaade_Statistics_Setter.correctAnswerCount = 0;
                arcadedetecttouch.Arcade_Touch_Detect.input_enabled = false;
                arcadedetecttouch.Arcade_Touch_Detect.judjement = true;
                arcadedetecttouch.Arcade_Touch_Detect.done = false;
                arcadecountdown.Arcade_Countdown_Script.curenttime = 20;
                Initiate.Fade("HOME", Color.gray, 20f);
            }
        }
        public void OnMouseDown()
        {
            if (lvlbtn.gameObject.name == "easy")
            {
                highScoresetting.highScoreSetter.selectedDifficulty = 1;
                arcadePatternNumberGenerator.Arcade_Program.minsize = 3;
                arcadePatternNumberGenerator.Arcade_Program.maxsize = 6;
                Initiate.Fade("Arcade", Color.gray, 5f);
            }

            if (lvlbtn.gameObject.name == "medium")
            {
                highScoresetting.highScoreSetter.selectedDifficulty = 2;
                arcadePatternNumberGenerator.Arcade_Program.minsize = 5;
                arcadePatternNumberGenerator.Arcade_Program.maxsize = 8;
                Initiate.Fade("Arcade", Color.gray, 5f);
            }
            if (lvlbtn.gameObject.name == "hard")
            {
                highScoresetting.highScoreSetter.selectedDifficulty = 3;
                arcadePatternNumberGenerator.Arcade_Program.minsize = 8;
                arcadePatternNumberGenerator.Arcade_Program.maxsize = 10;
                Initiate.Fade("Arcade", Color.gray, 5f);
            }

        }
    }

}