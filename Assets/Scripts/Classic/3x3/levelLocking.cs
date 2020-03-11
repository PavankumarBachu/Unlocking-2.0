using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelLocking : MonoBehaviour {
    int i;

    // Use this for initialization
    void Start () {
        Debug.Log(chapterNumber2.chapterNumberHolder2.chapterNumber);
        if (chapterNumber2.chapterNumberHolder2.chapterNumber == 2)
        {

            for (i = 0; i < 20; i++)
            {
                if (PlayerPrefs.GetInt("mygame_level2" + (i + 1)) == 0)
                {
                    break;
                }
            }
            string levl2 = "Level";
            string button2 = "_btn";
            string levelName2;
            for (int j = i + 1; j < 20; j++)
            {
                levelName2 = levl2 + (j + 1) + button2;
                GameObject.Find(levelName2).GetComponent<Button>().interactable = false;
            }
        }
        else if(chapterNUmber3.chapterNUmberHolder3.chapterNumber == 3)
        {
            for (i = 0; i < 20; i++)
            {
                if (PlayerPrefs.GetInt("mygame_level3" + (i + 1)) == 0)
                {
                    break;
                }
            }
            string levl2 = "Level";
            string button2 = "_btn";
            string levelName2;
            for (int j = i + 1; j < 20; j++)
            {
                levelName2 = levl2 + (j + 1) + button2;
                GameObject.Find(levelName2).GetComponent<Button>().interactable = false;
            }
        }
        else 
        {
            
            for (i = 0; i < 20; i++)
            {
                if (PlayerPrefs.GetInt("mygame_level" + (i + 1)) == 0)
                {
                    break;
                }
            }
            string levl = "Level";
            string button = "_btn";
            string levelName;
            for (int j = i + 1; j < 20; j++)
            {
                levelName = levl + (j + 1) + button;
                GameObject.Find(levelName).GetComponent<Button>().interactable = false;
            }
        }
        
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
