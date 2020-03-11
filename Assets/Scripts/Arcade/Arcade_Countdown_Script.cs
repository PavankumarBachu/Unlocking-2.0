using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace arcadecountdown
{
    public class Arcade_Countdown_Script : MonoBehaviour
    {

        [SerializeField] private Text uiText;
        [SerializeField] public static float mainTimer;

        private float timer;
        public static bool canCount = true;
        private bool doOnce = false;
        public static float curenttime = 60;

        void Start()
        {
            canCount = true;
            doOnce = false;
            mainTimer = curenttime;
            timer = mainTimer;
        }

        void Update()
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                arcadestatistics.Arcaade_Statistics_Setter.correctAnswerCount = 0;
                arcadedetecttouch.Arcade_Touch_Detect.judjement = true;
                arcadedetecttouch.Arcade_Touch_Detect.done = false;
                Initiate.Fade("Arcade_Lvl_Difficulty", new Color(57 / 255, 23 / 255, 59 / 255, 255 / 255), 20f);
                curenttime = 60;
                timer = 60;
            }
            if (timer > 0.0f && canCount)
            {
                curenttime = timer;
                timer -= Time.deltaTime;
                uiText.text = timer.ToString("F");
            }

            else if (timer <= 0.0f && !doOnce)
            {
                canCount = false;
                doOnce = true;
                uiText.text = "0.00";
                timer = 0.0f;
            }
        }
    }
}