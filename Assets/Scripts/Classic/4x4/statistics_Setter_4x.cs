using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace statisticsx
{
    public class statistics_Setter_4x : MonoBehaviour
    {
        Text rightAns,wrongAns;
        public static int correctAnswerCount = 0;
        public Sprite goldMedal;
        public Sprite silverMedal;
        public Sprite bronzeMedal;
        public Sprite sad;
        public Image image;

        // Use this for initialization
        void Start()
        {
            rightAns = GameObject.Find("RightCnt").GetComponent<Text>();
            wrongAns = GameObject.Find("WrongCnt").GetComponent<Text>();
            image = GetComponent<Image>();
         
            rightAns.text = correctAnswerCount.ToString();
            wrongAns.text = (3 - correctAnswerCount).ToString();
            if (correctAnswerCount == 3)
            {
                
                levelProgressX.levelProgressX.CompleteLevel();
                image.sprite = goldMedal;
            }
            else if (correctAnswerCount == 2)
            {
                levelProgressX.levelProgressX.CompleteLevel();
                image.sprite = silverMedal;
            }
            else if (correctAnswerCount == 1)
            {
                levelProgressX.levelProgressX.CompleteLevel();
                image.sprite = bronzeMedal;
            }
            else
            {
                image.sprite = sad;
            }
        }
        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                correctAnswerCount = 0;
                resultDisplayX.Result_displayX.questionCount = 1;
                detectTouchx.Touch_detectX.done = false;
                detectTouchx.Touch_detectX.judjement = true;
                if(chapterNUmber4x2.chapterNumberHolder4x2.chapterNumber4x == 4)
                {
                    Initiate.Fade("chapterScreen4x2", Color.black, 10f);
                    chapterNUmber4x2.chapterNumberHolder4x2.chapterNumber4x = 0;
                }
                else
                    Initiate.Fade("chapterScreen4x", Color.black, 10f);


            }
        }
    }
}