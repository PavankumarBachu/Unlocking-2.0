using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class question_Count_debug : MonoBehaviour {

    static Text debugQuestionCount;

    // Use this for initialization
    void Start () {
        debugQuestionCount = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        debugQuestionCount.text = display_Result.Result_display.questionCount.ToString();
    }
}
