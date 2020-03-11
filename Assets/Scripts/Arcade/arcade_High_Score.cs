using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class arcade_High_Score : MonoBehaviour {
    Text highScoreArea;
	// Use this for initialization
	void Start () {
        highScoreArea = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        highScoreArea.text = PlayerPrefs.GetInt("highScore" + highScoresetting.highScoreSetter.selectedDifficulty).ToString();
    }
}
