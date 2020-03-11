using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class home_to_Howtoplay : MonoBehaviour {
    Button btn;

	// Use this for initialization
	void Start () {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(gotoHTP);
	}
	
	// Update is called once per frame
	void gotoHTP () {
        Initiate.Fade("How_to_Play", Color.black, 10f);
	}
}
