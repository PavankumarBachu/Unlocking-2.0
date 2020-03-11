using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace sizesetter
{
    public class question_sizeSetter : MonoBehaviour
    {

        // Use this for initialization
        public Button lvlbtn;
        void Start()
        {
            lvlbtn = GetComponent<Button>();
            lvlbtn.onClick.AddListener(OnMouseDown);
        }

        // Update is called once per frame
        void Update()
        {

        }
        private void OnMouseDown()
        {
            if (lvlbtn.name == "Level1_btn")
            {
                level_Progress.LevelProgress.SelectLevel(1);
                clock_counter.CountdownScript.mainTimer = 5f;
                PatternGameNumberGenerator.Program.fqs = 3;
                PatternGameNumberGenerator.Program.sqs = 3;
                PatternGameNumberGenerator.Program.tqs = 3;
                PatternGameNumberGenerator.Program.disappearTime = PatternGameNumberGenerator.Program.tqs/3;

            }
            else if (lvlbtn.name == "Level2_btn")
            {
                level_Progress.LevelProgress.SelectLevel(2);
                clock_counter.CountdownScript.mainTimer = 3f;
                PatternGameNumberGenerator.Program.fqs = 3;
                PatternGameNumberGenerator.Program.sqs = 3;
                PatternGameNumberGenerator.Program.tqs = 4;
                PatternGameNumberGenerator.Program.disappearTime = PatternGameNumberGenerator.Program.tqs / 3;
            }
            else if (lvlbtn.name == "Level3_btn")
            {
                level_Progress.LevelProgress.SelectLevel(3);
                clock_counter.CountdownScript.mainTimer = 3f;
                PatternGameNumberGenerator.Program.fqs = 3;
                PatternGameNumberGenerator.Program.sqs = 4;
                PatternGameNumberGenerator.Program.tqs = 4;
                PatternGameNumberGenerator.Program.disappearTime = PatternGameNumberGenerator.Program.tqs / 3;
            }
            else if (lvlbtn.name == "Level4_btn")
            {
                level_Progress.LevelProgress.SelectLevel(4);
                clock_counter.CountdownScript.mainTimer = 3f;
                PatternGameNumberGenerator.Program.fqs = 4;
                PatternGameNumberGenerator.Program.sqs = 4;
                PatternGameNumberGenerator.Program.tqs = 4;
                PatternGameNumberGenerator.Program.disappearTime = PatternGameNumberGenerator.Program.tqs / 3;
            }
            else if (lvlbtn.name == "Level5_btn")
            {
                level_Progress.LevelProgress.SelectLevel(5);
                clock_counter.CountdownScript.mainTimer = 4f;
                PatternGameNumberGenerator.Program.fqs = 4;
                PatternGameNumberGenerator.Program.sqs = 4;
                PatternGameNumberGenerator.Program.tqs = 5;
                PatternGameNumberGenerator.Program.disappearTime = PatternGameNumberGenerator.Program.tqs / 3;
            }

            else if (lvlbtn.name == "Level6_btn")
            {
                level_Progress.LevelProgress.SelectLevel(6);
                clock_counter.CountdownScript.mainTimer = 4f;
                PatternGameNumberGenerator.Program.fqs = 4;
                PatternGameNumberGenerator.Program.sqs = 5;
                PatternGameNumberGenerator.Program.tqs = 5;
                PatternGameNumberGenerator.Program.disappearTime = PatternGameNumberGenerator.Program.tqs / 3;
            }
            else if (lvlbtn.name == "Level7_btn")
            {
                level_Progress.LevelProgress.SelectLevel(7);
                clock_counter.CountdownScript.mainTimer =4f;
                PatternGameNumberGenerator.Program.fqs = 5;
                PatternGameNumberGenerator.Program.sqs = 5;
                PatternGameNumberGenerator.Program.tqs = 5;
                PatternGameNumberGenerator.Program.disappearTime = PatternGameNumberGenerator.Program.tqs / 3;
            }
            else if (lvlbtn.name == "Level8_btn")
            {
                level_Progress.LevelProgress.SelectLevel(8);
                clock_counter.CountdownScript.mainTimer = 4f;
                PatternGameNumberGenerator.Program.fqs = 5;
                PatternGameNumberGenerator.Program.sqs = 5;
                PatternGameNumberGenerator.Program.tqs = 6;
                PatternGameNumberGenerator.Program.disappearTime = PatternGameNumberGenerator.Program.tqs / 3;
            }
            else if (lvlbtn.name == "Level9_btn")
            {
                level_Progress.LevelProgress.SelectLevel(9);
                clock_counter.CountdownScript.mainTimer = 4f;
                PatternGameNumberGenerator.Program.fqs = 5;
                PatternGameNumberGenerator.Program.sqs = 6;
                PatternGameNumberGenerator.Program.tqs = 6;
                PatternGameNumberGenerator.Program.disappearTime = PatternGameNumberGenerator.Program.tqs / 3;
            }
            else if (lvlbtn.name == "Level10_btn")
            {
                level_Progress.LevelProgress.SelectLevel(10);
                clock_counter.CountdownScript.mainTimer = 5f;
                PatternGameNumberGenerator.Program.fqs = 6;
                PatternGameNumberGenerator.Program.sqs = 6;
                PatternGameNumberGenerator.Program.tqs = 6;
                PatternGameNumberGenerator.Program.disappearTime = PatternGameNumberGenerator.Program.tqs / 3;
            }
            else if (lvlbtn.name == "Level11_btn")
            {
                level_Progress.LevelProgress.SelectLevel(11);
                clock_counter.CountdownScript.mainTimer = 5f;
                PatternGameNumberGenerator.Program.fqs = 6;
                PatternGameNumberGenerator.Program.sqs = 6;
                PatternGameNumberGenerator.Program.tqs = 7;
                PatternGameNumberGenerator.Program.disappearTime = PatternGameNumberGenerator.Program.tqs / 3;
            }
            else if (lvlbtn.name == "Level12_btn")
            {
                level_Progress.LevelProgress.SelectLevel(12);
                clock_counter.CountdownScript.mainTimer = 5f;
                PatternGameNumberGenerator.Program.fqs = 6;
                PatternGameNumberGenerator.Program.sqs = 7;
                PatternGameNumberGenerator.Program.tqs = 7;
                PatternGameNumberGenerator.Program.disappearTime = PatternGameNumberGenerator.Program.tqs / 3;
            }
            else if (lvlbtn.name == "Level13_btn")
            {
                level_Progress.LevelProgress.SelectLevel(13);
                clock_counter.CountdownScript.mainTimer = 5f;
                PatternGameNumberGenerator.Program.fqs = 7;
                PatternGameNumberGenerator.Program.sqs = 7;
                PatternGameNumberGenerator.Program.tqs = 7;
                PatternGameNumberGenerator.Program.disappearTime = PatternGameNumberGenerator.Program.tqs / 3;
            }
            else if (lvlbtn.name == "Level14_btn")
            {
                level_Progress.LevelProgress.SelectLevel(14);
                clock_counter.CountdownScript.mainTimer = 5.5f;
                PatternGameNumberGenerator.Program.fqs = 7;
                PatternGameNumberGenerator.Program.sqs = 7;
                PatternGameNumberGenerator.Program.tqs = 8;
                PatternGameNumberGenerator.Program.disappearTime = PatternGameNumberGenerator.Program.tqs / 3;
            }
            else if (lvlbtn.name == "Level15_btn")
            {
                level_Progress.LevelProgress.SelectLevel(15);
                clock_counter.CountdownScript.mainTimer = 5.5f;
                PatternGameNumberGenerator.Program.fqs = 7;
                PatternGameNumberGenerator.Program.sqs = 8;
                PatternGameNumberGenerator.Program.tqs = 8;
                PatternGameNumberGenerator.Program.disappearTime = PatternGameNumberGenerator.Program.tqs / 3;
            }
            else if (lvlbtn.name == "Level16_btn")
            {
                level_Progress.LevelProgress.SelectLevel(16);
                clock_counter.CountdownScript.mainTimer = 5.5f;
                PatternGameNumberGenerator.Program.fqs = 8;
                PatternGameNumberGenerator.Program.sqs = 8;
                PatternGameNumberGenerator.Program.tqs = 8;
                PatternGameNumberGenerator.Program.disappearTime = PatternGameNumberGenerator.Program.tqs / 3;
            }
            else if (lvlbtn.name == "Level17_btn")
            {
                level_Progress.LevelProgress.SelectLevel(17);
                clock_counter.CountdownScript.mainTimer = 5.5f;
                PatternGameNumberGenerator.Program.fqs = 8;
                PatternGameNumberGenerator.Program.sqs = 8;
                PatternGameNumberGenerator.Program.tqs = 9;
                PatternGameNumberGenerator.Program.disappearTime = PatternGameNumberGenerator.Program.tqs / 3;
            }
            else if (lvlbtn.name == "Level18_btn")
            {
                level_Progress.LevelProgress.SelectLevel(18);
                clock_counter.CountdownScript.mainTimer = 5.5f;
                PatternGameNumberGenerator.Program.fqs = 8;
                PatternGameNumberGenerator.Program.sqs = 9;
                PatternGameNumberGenerator.Program.tqs = 9;
                PatternGameNumberGenerator.Program.disappearTime = PatternGameNumberGenerator.Program.tqs / 3;
            }
            else if (lvlbtn.name == "Level19_btn")
            {
                level_Progress.LevelProgress.SelectLevel(19);
                clock_counter.CountdownScript.mainTimer = 5.5f;
                PatternGameNumberGenerator.Program.fqs = 9;
                PatternGameNumberGenerator.Program.sqs = 9;
                PatternGameNumberGenerator.Program.tqs = 9;
                PatternGameNumberGenerator.Program.disappearTime = PatternGameNumberGenerator.Program.tqs / 3;
            }
            else if (lvlbtn.name == "Level20_btn")
            {
                level_Progress.LevelProgress.SelectLevel(20);
                clock_counter.CountdownScript.mainTimer = 5.5f;
                PatternGameNumberGenerator.Program.fqs = 9;
                PatternGameNumberGenerator.Program.sqs = 9;
                PatternGameNumberGenerator.Program.tqs = 9;
                PatternGameNumberGenerator.Program.disappearTime = PatternGameNumberGenerator.Program.tqs / 3;
            }

        }
    }
}

