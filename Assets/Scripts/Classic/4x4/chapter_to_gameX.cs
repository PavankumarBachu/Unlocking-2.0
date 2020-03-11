using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chapter_to_gameX : MonoBehaviour {

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
    private void OnMouseDown()
    {
        Initiate.Fade("gameScreen_4x", Color.black , 5f);
    }
}
