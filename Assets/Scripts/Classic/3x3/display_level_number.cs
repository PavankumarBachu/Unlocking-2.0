using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class display_level_number : MonoBehaviour {

    Text lvlnumber;
    // Use this for initialization
	void Start () {
        lvlnumber = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        lvlnumber.text = level_Progress.LevelProgress.selectedLevel.ToString();
	}
}
