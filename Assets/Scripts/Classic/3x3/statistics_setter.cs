using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace statistics
{
    public class statistics_setter : MonoBehaviour
    {
        Text rightAns, wrongAns;
        public static int correctAnswerCount=0;
        public Sprite Gold;
        public Sprite Silver;
        public Sprite Bronze;
        public Sprite Wrong;
        public Image image;
        // Use this for initialization
        void Start()
        {
            rightAns = GameObject.Find("RightCnt").GetComponent<Text>();
            wrongAns = GameObject.Find("WrongCnt").GetComponent<Text>();
            rightAns.text = correctAnswerCount.ToString();
            wrongAns.text = (3 - correctAnswerCount).ToString();
            image = GetComponent<Image>();
            if (correctAnswerCount == 3)
            {
                level_Progress.LevelProgress.CompleteLevel();
                image.sprite = Gold;
            }
            else if (correctAnswerCount == 2)
            {
                level_Progress.LevelProgress.CompleteLevel();
                image.sprite = Silver;

            }
            else if (correctAnswerCount == 1)
            {
                level_Progress.LevelProgress.CompleteLevel();
                image.sprite = Bronze;
            }
            else
            {
                image.sprite = Wrong;
            }
        }
        
        // Update is called once per frame
        void Update()
        {
            if(Input.GetKeyDown(KeyCode.Escape))
            {
                if (chapterNumber2.chapterNumberHolder2.chapterNumber == 2)
                {
                    correctAnswerCount = 0;
                    chapterNumber2.chapterNumberHolder2.chapterNumber = 0;
                    display_Result.Result_display.questionCount = 1;
                    detect_touch.Touch_detect.judjement = true;
                    detect_touch.Touch_detect.done = false;
                    Initiate.Fade("chapterScreen2", Color.black, 10f);
                    
                }
                else if(chapterNUmber3.chapterNUmberHolder3.chapterNumber == 3)
                {
                    correctAnswerCount = 0;
                    chapterNUmber3.chapterNUmberHolder3.chapterNumber = 0;
                    display_Result.Result_display.questionCount = 1;
                    detect_touch.Touch_detect.judjement = true;
                    detect_touch.Touch_detect.done = false;
                    Initiate.Fade("chapterScreen3", Color.black, 10f);
                }
                else
                {
                    
                    correctAnswerCount = 0;
                    display_Result.Result_display.questionCount = 1;
                    detect_touch.Touch_detect.judjement = true;
                    detect_touch.Touch_detect.done = false;
                    Initiate.Fade("chapterScreen", Color.black, 10f);
                } 
            }
        }
    }
}

