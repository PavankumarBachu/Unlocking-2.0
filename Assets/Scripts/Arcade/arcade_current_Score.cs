using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class arcade_current_Score : MonoBehaviour {
    Text scoreArea;
	// Use this for initialization
	void Start () {
        scoreArea = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        scoreArea.text = (arcadestatistics.Arcaade_Statistics_Setter.correctAnswerCount * 100 ).ToString();
	}
}
