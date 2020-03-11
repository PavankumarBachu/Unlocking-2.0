using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class home_to_chapter3 : MonoBehaviour {
    // Use this for initialization
    Button classic;
    void Start()
    {
        classic = GetComponent<Button>();
        classic.onClick.AddListener(OnMouseDown);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseDown()
    {
        Initiate.Fade("chapterScreen3", Color.black, 10f);
    }
}
