using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chapterLock : MonoBehaviour {
    // Used to calculate number of golds per chapter
    int chapter1Golds = 0;
    int chapter2Golds = 0;
    int chapter3Golds = 0;
    int i;
    Image lockButton;
    public Sprite lockSymbol;
    // Used to get reference of the chapter button
    Button chapterButton;
    // Use this for initialisation
    void Start()
    {
        // Count number of golds in chapter one
        for(i = 1; i <= 20; i++)
        {
            if(PlayerPrefs.GetInt("mygame_level" + i) == 3)
            {
                ++chapter1Golds;
            }
            if(PlayerPrefs.GetInt("mygame_level2" + i) == 3)
            {
                ++chapter2Golds;
            }
            if(PlayerPrefs.GetInt("mygame_level3"+i) == 3)
            {
                ++chapter3Golds;
            }
        }
        // 2, 3, 4 chapters locking
        if(chapter1Golds < 18)
        {
            chapterButton = GameObject.Find("3x2").GetComponent<Button>();
            chapterButton.interactable = false;
            chapterButton = GameObject.Find("3x3").GetComponent<Button>();
            chapterButton.interactable = false;
            chapterButton = GameObject.Find("4x1").GetComponent<Button>();
            chapterButton.interactable = false;
            // Displaying the lock button
            lockButton = GameObject.Find("3x2_lock").GetComponent<Image>();
            lockButton.sprite = lockSymbol;
            lockButton = GameObject.Find("3x3_lock").GetComponent<Image>();
            lockButton.sprite = lockSymbol;
            lockButton = GameObject.Find("4x1_lock").GetComponent<Image>();
            lockButton.sprite = lockSymbol;

        }
        // 3, 4 chapter locking
        else if(chapter1Golds >= 18 && chapter2Golds < 15)
        {
            chapterButton = GameObject.Find("3x3").GetComponent<Button>();
            chapterButton.interactable = false;
            chapterButton = GameObject.Find("4x1").GetComponent<Button>();
            chapterButton.interactable = false;
            // Displaying the lock button
            lockButton = GameObject.Find("3x2_lock").GetComponent<Image>();
            lockButton.gameObject.SetActive(false);
            lockButton = GameObject.Find("3x3_lock").GetComponent<Image>();
            lockButton.sprite = lockSymbol;
            lockButton = GameObject.Find("4x1_lock").GetComponent<Image>();
            lockButton.sprite = lockSymbol;
        }
        // 4 chapter locking
        else if(chapter1Golds >= 18 && chapter2Golds >=15 && chapter3Golds < 15)
        {
            chapterButton = GameObject.Find("4x1").GetComponent<Button>();
            chapterButton.interactable = false;
            // Displaying the lock button
            lockButton = GameObject.Find("4x1_lock").GetComponent<Image>();
            lockButton.sprite = lockSymbol;
            lockButton = GameObject.Find("3x2_lock").GetComponent<Image>();
            lockButton.gameObject.SetActive(false);
            lockButton = GameObject.Find("3x3_lock").GetComponent<Image>();
            lockButton.gameObject.SetActive(false);
        }
    }

}
