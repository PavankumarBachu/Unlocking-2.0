using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace resultDisplayX
{
    public class Result_displayX : MonoBehaviour
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
                detectTouchx.Touch_detectX.judjement = true;
                detectTouchx.Touch_detectX.done = false;
                if(chapterNUmber4x2.chapterNumberHolder4x2.chapterNumber4x == 4)
                {
                    Initiate.Fade("chapterScreen4x2", Color.black, 10f);
                    chapterNUmber4x2.chapterNumberHolder4x2.chapterNumber4x = 0;
                }
                else
                    Initiate.Fade("chapterScreen4x", Color.black, 10f);
            }
            if (detectTouchx.Touch_detectX.done)
            {
                if (detectTouchx.Touch_detectX.judjement)
                {
                    (statisticsx.statistics_Setter_4x.correctAnswerCount)++;
                    detectTouchx.Touch_detectX.done = false;
                    detectTouchx.Touch_detectX.judjement = true;
                    if (questionCount <= 3)
                    {
                        //"You Won GG";
                        Initiate.Fade("gameScreen_4x", Color.black, 5f);
                    }
                    else
                    {
                        Initiate.Fade("Result4x", Color.black, 10f);
                    }

                }
                else
                {
                    detectTouchx.Touch_detectX.done = false;
                    detectTouchx.Touch_detectX.judjement = true;
                    if (questionCount <= 3)
                    {
                        //"You Lost Noob";
                        Initiate.Fade("gameScreen_4x", Color.black, 5f);
                    }
                    else
                    {
                        Initiate.Fade("Result4x", Color.black, 10f);
                    }

                }
            }

        }
    }
}