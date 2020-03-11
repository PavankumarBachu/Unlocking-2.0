using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkLevelCompletion : MonoBehaviour {

    // Use this for initialization   
    public Image[] lvlC = new Image[20];
    public Sprite childGold, childSilver, childBronze;
	void Start () {       
        if (chapterNumber2.chapterNumberHolder2.chapterNumber == 2)
        {
            for (int i = 1; i <= 20; i++)
            {
                if (PlayerPrefs.GetInt("mygame_level2" + i) == 3)
                {
                    lvlC[i - 1].sprite = childGold;
                    Debug.Log("You got Gold medal Before");
                }
                if (PlayerPrefs.GetInt("mygame_level2" + i) == 2)
                {
                    lvlC[i - 1].sprite = childSilver;
                    Debug.Log("You got Silver medal Before");
                }
                if (PlayerPrefs.GetInt("mygame_level2" + i) == 1)
                {
                    lvlC[i - 1].sprite = childBronze;
                    Debug.Log("You got Bronze medal Before");
                }
            }
        }
        else if(chapterNUmber3.chapterNUmberHolder3.chapterNumber == 3)
        {
            for (int i = 1; i <= 20; i++)
            {
                if (PlayerPrefs.GetInt("mygame_level3" + i) == 3)
                {
                    lvlC[i - 1].sprite = childGold;
                    Debug.Log("You got Gold medal Before");
                }
                if (PlayerPrefs.GetInt("mygame_level3" + i) == 2)
                {
                    lvlC[i - 1].sprite = childSilver;
                    Debug.Log("You got Silver medal Before");
                }
                if (PlayerPrefs.GetInt("mygame_level3" + i) == 1)
                {
                    lvlC[i - 1].sprite = childBronze;
                    Debug.Log("You got Bronze medal Before");
                }
            }
        }
        else
        {
            for (int i = 1; i <= 20; i++)
            {
                if (PlayerPrefs.GetInt("mygame_level" + i) == 3)
                {
                    lvlC[i - 1].sprite = childGold;
                    Debug.Log("You got Gold medal Before");
                }
                if (PlayerPrefs.GetInt("mygame_level" + i) == 2)
                {
                    lvlC[i - 1].sprite = childSilver;
                    Debug.Log("You got Silver medal Before");
                }
                if (PlayerPrefs.GetInt("mygame_level" + i) == 1)
                {
                    lvlC[i - 1].sprite = childBronze;
                    Debug.Log("You got Bronze medal Before");
                }
            }

        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
