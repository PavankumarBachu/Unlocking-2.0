using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chapter_to_classic : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(chapterNumber2.chapterNumberHolder2.chapterNumber == 2)
            {
                chapterNumber2.chapterNumberHolder2.chapterNumber = 0;
            }
            else if(chapterNUmber3.chapterNUmberHolder3.chapterNumber == 3)
            {
                chapterNUmber3.chapterNUmberHolder3.chapterNumber = 0;
            }
            Initiate.Fade("Classic_screen",Color.black, 10f);
        }
    }
}
