using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace highScoresetting
{

    public class highScoreSetter : MonoBehaviour
    {

        public  Text easyscoreArea;
        public  Text mediumscoreArea;
        public  Text hardscoreArea;
        public static int selectedDifficulty;
        // Use this for initialization
        void Start()
        {
            Debug.Log(PlayerPrefs.GetInt("highScore1"));
            Debug.Log(PlayerPrefs.GetInt("highScore2"));
            Debug.Log(PlayerPrefs.GetInt("highScore3"));
            easyscoreArea.text = PlayerPrefs.GetInt("highScore1").ToString();
            mediumscoreArea.text = PlayerPrefs.GetInt("highScore2").ToString();
            hardscoreArea.text = PlayerPrefs.GetInt("highScore3").ToString();
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        public static void saveScore()
        {
            if (PlayerPrefs.GetInt("highScore" + selectedDifficulty) <= arcadestatistics.Arcaade_Statistics_Setter.correctAnswerCount * 100)
            {
                PlayerPrefs.SetInt("highScore" + selectedDifficulty, arcadestatistics.Arcaade_Statistics_Setter.correctAnswerCount * 100);
            }       
           
            else
            {
                PlayerPrefs.SetInt("highScore" + selectedDifficulty, PlayerPrefs.GetInt("highScore" + selectedDifficulty));
            }
                
        }
    }
}