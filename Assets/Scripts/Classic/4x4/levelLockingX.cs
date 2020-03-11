using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelLockingX : MonoBehaviour {
    int i;
    // Use this for initialization
    void Start () {
        Debug.Log(chapterNUmber4x2.chapterNumberHolder4x2.chapterNumber4x);
        if(chapterNUmber4x2.chapterNumberHolder4x2.chapterNumber4x == 4)
        {
            for (i = 0; i < 20; i++)
            {
                if (PlayerPrefs.GetInt("mygame_levelx2" + (i + 1)) == 0)
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
        else{
            for (i = 0; i < 20; i++)
            {
                if (PlayerPrefs.GetInt("mygame_levelx" + (i + 1)) == 0)
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
