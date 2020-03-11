using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace chaptertoGame
{
    public class chapter_to_game : MonoBehaviour
    {

        Button lvl;

        // Use this for initialization
        void Start()
        {
            lvl = GetComponent<Button>();
            lvl.onClick.AddListener(OnMouseDown);
        }

        // Update is called once per frame
        void Update()
        {

        }
        public static void OnMouseDown()
        {
            if (chapterNumber2.chapterNumberHolder2.chapterNumber == 2)
                Initiate.Fade("gameScreenTest2",Color.black, 5f);
            else if (chapterNUmber3.chapterNUmberHolder3.chapterNumber == 3)
                Initiate.Fade("gameScreenTest3", Color.black, 5f);
            else
                Initiate.Fade("gameScreen", Color.black, 5f);
        }
    }
}