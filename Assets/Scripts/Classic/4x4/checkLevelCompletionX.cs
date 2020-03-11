using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class checkLevelCompletionX : MonoBehaviour {

    // Use this for initialization
    public Image[] lvlC = new Image[20];
    public Sprite childGold, childSilver, childBronze;
    void Start()
    {
        if (chapterNUmber4x2.chapterNumberHolder4x2.chapterNumber4x == 4)
        {
            for (int i = 1; i <= 20; i++)
            {
                if (PlayerPrefs.GetInt("mygame_levelx2" + i) == 3)
                {
                    lvlC[i - 1].sprite = childGold;
                    Debug.Log("You got Gold medal Before");
                }
                if (PlayerPrefs.GetInt("mygame_levelx2" + i) == 2)
                {
                    lvlC[i - 1].sprite = childSilver;
                    Debug.Log("You got Silver medal Before");
                }
                if (PlayerPrefs.GetInt("mygame_levelx2" + i) == 1)
                {
                    lvlC[i - 1].sprite = childBronze;
                    Debug.Log("You got Bronze medal Before");
                }
            }
        }
        else{
            for (int i = 1; i <= 20; i++)
            {
                if (PlayerPrefs.GetInt("mygame_levelx" + i) == 3)
                {
                    lvlC[i - 1].sprite = childGold;
                    Debug.Log("You got Gold medal Before");
                }
                if (PlayerPrefs.GetInt("mygame_levelx" + i) == 2)
                {
                    lvlC[i - 1].sprite = childSilver;
                    Debug.Log("You got Silver medal Before");
                }
                if (PlayerPrefs.GetInt("mygame_levelx" + i) == 1)
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
