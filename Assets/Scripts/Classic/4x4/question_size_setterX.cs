using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class question_size_setterX : MonoBehaviour {

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
            levelProgressX.levelProgressX.SelectLevel(1);
            clock_counter.CountdownScript.mainTimer = 6.5f;
            PatternNumberGenerator4x.Programx.fqs = 3;
            PatternNumberGenerator4x.Programx.sqs = 4;
            PatternNumberGenerator4x.Programx.tqs = 5;
        }
        else if (lvlbtn.name == "Level2_btn")
        {
            levelProgressX.levelProgressX.SelectLevel(2);
            clock_counter.CountdownScript.mainTimer = 6.5f;
            PatternNumberGenerator4x.Programx.fqs = 3;
            PatternNumberGenerator4x.Programx.sqs = 4;
            PatternNumberGenerator4x.Programx.tqs = 5;
        }
        else if (lvlbtn.name == "Level3_btn")

        {
            levelProgressX.levelProgressX.SelectLevel(3);
            clock_counter.CountdownScript.mainTimer = 6.5f;
            PatternNumberGenerator4x.Programx.fqs = 3;
            PatternNumberGenerator4x.Programx.sqs = 4;
            PatternNumberGenerator4x.Programx.tqs = 5;
        }
        else if (lvlbtn.name == "Level4_btn")
        {
            levelProgressX.levelProgressX.SelectLevel(4);
            clock_counter.CountdownScript.mainTimer = 6;
            PatternNumberGenerator4x.Programx.fqs = 3;
            PatternNumberGenerator4x.Programx.sqs = 4;
            PatternNumberGenerator4x.Programx.tqs = 5;
        }
        else if (lvlbtn.name == "Level5_btn")
        {
            levelProgressX.levelProgressX.SelectLevel(5);
            clock_counter.CountdownScript.mainTimer = 6;
            PatternNumberGenerator4x.Programx.fqs = 3;
            PatternNumberGenerator4x.Programx.sqs = 4;
            PatternNumberGenerator4x.Programx.tqs = 5;
        }

        else if (lvlbtn.name == "Level6_btn")
        {
            levelProgressX.levelProgressX.SelectLevel(6);
            clock_counter.CountdownScript.mainTimer = 6f;
            PatternNumberGenerator4x.Programx.fqs = 4;
            PatternNumberGenerator4x.Programx.sqs = 5;
            PatternNumberGenerator4x.Programx.tqs = 6;
        }
        else if (lvlbtn.name == "Level7_btn")
        {
            levelProgressX.levelProgressX.SelectLevel(7);
            clock_counter.CountdownScript.mainTimer = 5.5f;
            PatternNumberGenerator4x.Programx.fqs = 4;
            PatternNumberGenerator4x.Programx.sqs = 5;
            PatternNumberGenerator4x.Programx.tqs = 6;
        }
        else if (lvlbtn.name == "Level8_btn")
        {
            levelProgressX.levelProgressX.SelectLevel(8);
            clock_counter.CountdownScript.mainTimer = 5.5f;
            PatternNumberGenerator4x.Programx.fqs = 4;
            PatternNumberGenerator4x.Programx.sqs = 5;
            PatternNumberGenerator4x.Programx.tqs = 6;
        }
        else if (lvlbtn.name == "Level9_btn")
        {
            levelProgressX.levelProgressX.SelectLevel(9);
            clock_counter.CountdownScript.mainTimer = 5.5f;
            PatternNumberGenerator4x.Programx.fqs = 4;
            PatternNumberGenerator4x.Programx.sqs = 5;
            PatternNumberGenerator4x.Programx.tqs = 6;
        }
        else if (lvlbtn.name == "Level10_btn")
        {
            levelProgressX.levelProgressX.SelectLevel(10);
            clock_counter.CountdownScript.mainTimer = 5.5f;
            PatternNumberGenerator4x.Programx.fqs = 5;
            PatternNumberGenerator4x.Programx.sqs = 6;
            PatternNumberGenerator4x.Programx.tqs = 7;
        }
        else if (lvlbtn.name == "Level11_btn")
        {
            levelProgressX.levelProgressX.SelectLevel(11);
            clock_counter.CountdownScript.mainTimer = 5.5f;
            PatternNumberGenerator4x.Programx.fqs = 5;
            PatternNumberGenerator4x.Programx.sqs = 6;
            PatternNumberGenerator4x.Programx.tqs = 7;
        }
        else if (lvlbtn.name == "Level12_btn")
        {
            levelProgressX.levelProgressX.SelectLevel(12);
            clock_counter.CountdownScript.mainTimer = 5;
            PatternNumberGenerator4x.Programx.fqs = 5;
            PatternNumberGenerator4x.Programx.sqs = 6;
            PatternNumberGenerator4x.Programx.tqs = 7;
        }
        else if (lvlbtn.name == "Level13_btn")
        {
            levelProgressX.levelProgressX.SelectLevel(13);
            clock_counter.CountdownScript.mainTimer = 5;
            PatternNumberGenerator4x.Programx.fqs = 5;
            PatternNumberGenerator4x.Programx.sqs = 6;
            PatternNumberGenerator4x.Programx.tqs = 7;
        }
        else if (lvlbtn.name == "Level14_btn")
        {
            levelProgressX.levelProgressX.SelectLevel(14);
            clock_counter.CountdownScript.mainTimer = 5;
            PatternNumberGenerator4x.Programx.fqs = 6;
            PatternNumberGenerator4x.Programx.sqs = 7;
            PatternNumberGenerator4x.Programx.tqs = 8;
        }
        else if (lvlbtn.name == "Level15_btn")
        {
            levelProgressX.levelProgressX.SelectLevel(15);
            clock_counter.CountdownScript.mainTimer = 4.5f;
            PatternNumberGenerator4x.Programx.fqs = 6;
            PatternNumberGenerator4x.Programx.sqs = 7;
            PatternNumberGenerator4x.Programx.tqs = 8;
        }
        else if (lvlbtn.name == "Level16_btn")
        {
            levelProgressX.levelProgressX.SelectLevel(16);
            clock_counter.CountdownScript.mainTimer = 4.5f;
            PatternNumberGenerator4x.Programx.fqs = 6;
            PatternNumberGenerator4x.Programx.sqs = 7;
            PatternNumberGenerator4x.Programx.tqs = 8;
        }
        else if (lvlbtn.name == "Level17_btn")
        {
            levelProgressX.levelProgressX.SelectLevel(17);
            clock_counter.CountdownScript.mainTimer = 4;
            PatternNumberGenerator4x.Programx.fqs = 6;
            PatternNumberGenerator4x.Programx.sqs = 7;
            PatternNumberGenerator4x.Programx.tqs = 8;
        }
        else if (lvlbtn.name == "Level18_btn")
        {
            levelProgressX.levelProgressX.SelectLevel(18);
            clock_counter.CountdownScript.mainTimer = 4;
            PatternNumberGenerator4x.Programx.fqs = 7;
            PatternNumberGenerator4x.Programx.sqs = 8;
            PatternNumberGenerator4x.Programx.tqs = 9;
        }
        else if (lvlbtn.name == "Level19_btn")
        {
            levelProgressX.levelProgressX.SelectLevel(19);
            clock_counter.CountdownScript.mainTimer = 4;
            PatternNumberGenerator4x.Programx.fqs = 7;
            PatternNumberGenerator4x.Programx.sqs = 8;
            PatternNumberGenerator4x.Programx.tqs = 9;
        }
        else if (lvlbtn.name == "Level20_btn")
        {
            levelProgressX.levelProgressX.SelectLevel(20);
            clock_counter.CountdownScript.mainTimer = 4;
            PatternNumberGenerator4x.Programx.fqs = 7;
            PatternNumberGenerator4x.Programx.sqs = 8;
            PatternNumberGenerator4x.Programx.tqs = 9;
        }

    }
}
