using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using detect_touch;
namespace display_Result
{
    public class Result_display : MonoBehaviour
    {
        public static int questionCount = 1;
               
        // Use this for initialization
        void Start()
        {

        }
        // Update is called once per frame
        void Update()
        {
            // Changes the scene when user touches the back button
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                questionCount = 1;
                statistics.statistics_setter.correctAnswerCount = 0;
                Touch_detect.judjement = true;
                Touch_detect.done = false;
                // Simplify the code by removing the cloned statements
                if(chapterNumber2.chapterNumberHolder2.chapterNumber == 2)
                {
                    statistics.statistics_setter.correctAnswerCount = 0;
                    chapterNumber2.chapterNumberHolder2.chapterNumber = 0;
                    display_Result.Result_display.questionCount = 1;
                    detect_touch.Touch_detect.judjement = true;
                    detect_touch.Touch_detect.done = false;
                    Initiate.Fade("chapterScreen2", Color.black, 10f);
                    chapterNumber2.chapterNumberHolder2.chapterNumber = 0;
                }
                else if(chapterNUmber3.chapterNUmberHolder3.chapterNumber == 3)
                {
                    statistics.statistics_setter.correctAnswerCount = 0;
                    chapterNUmber3.chapterNUmberHolder3.chapterNumber = 0;
                    display_Result.Result_display.questionCount = 1;
                    detect_touch.Touch_detect.judjement = true;
                    detect_touch.Touch_detect.done = false;
                    Initiate.Fade("chapterScreen3", Color.black, 10f);
                    chapterNUmber3.chapterNUmberHolder3.chapterNumber = 0;
                }
                else
                {
                    statistics.statistics_setter.correctAnswerCount = 0;
                    display_Result.Result_display.questionCount = 1;
                    detect_touch.Touch_detect.judjement = true;
                    detect_touch.Touch_detect.done = false;
                    Initiate.Fade("chapterScreen", Color.black, 10f);
                }

            }
            //here user finishes drawing the pattern weather its right or wrong
            if (detect_touch.Touch_detect.done)
            {
                if (detect_touch.Touch_detect.judjement)
                {
                    // If input is correct increment the correct answer count.
                    (statistics.statistics_setter.correctAnswerCount)++;
                }
                // Initializing all variables for next scene
                detect_touch.Touch_detect.done = false;
                detect_touch.Touch_detect.judjement = true;
                // Loading the scene when question count is less than 3
                if (questionCount <= 3)
                {
                    if (chapterNumber2.chapterNumberHolder2.chapterNumber == 2)
                    {
                        Initiate.Fade("gameScreenTest2", Color.black, 5f);
                    }
                    else if (chapterNUmber3.chapterNUmberHolder3.chapterNumber == 3)
                    {
                        Initiate.Fade("gameScreenTest3", Color.black, 5f);
                    }
                    else
                    {
                        Initiate.Fade("gameScreen", Color.black, 5f);
                    }
                }
                else
                {
                    Initiate.Fade("Result", Color.black, 10f);
                }

            }
            
        }
    }
}
