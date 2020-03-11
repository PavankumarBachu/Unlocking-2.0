using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class home_to_chapter4X : MonoBehaviour {
    Button classic;
    // Use this for initialization
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
        Initiate.Fade("chapterScreen4x", Color.black, 10f);
    }
}
