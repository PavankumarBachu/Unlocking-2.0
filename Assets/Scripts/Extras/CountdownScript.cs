using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace clock_counter
{
    public class CountdownScript : MonoBehaviour
    {
        [SerializeField] private Text uiText;
        [SerializeField] public static float mainTimer;

        public static float timer;
        public static bool canCount = true;
        private bool doOnce = false;

        void Start()
        {
            canCount = true;
            doOnce = false;
            timer = mainTimer;
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                timer = 90999999999;
            }
            if (timer > 0.0f && canCount)
            {
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