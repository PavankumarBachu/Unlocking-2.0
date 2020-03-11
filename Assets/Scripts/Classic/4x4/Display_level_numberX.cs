using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Display_level_numberX : MonoBehaviour {

    Text lvlnumber;

    // Use this for initialization
    void Start () {
        lvlnumber = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        lvlnumber.text = levelProgressX.levelProgressX.selectedLevel.ToString();
    }
}
