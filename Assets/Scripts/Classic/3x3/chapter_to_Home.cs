using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chapter_to_Home : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Initiate.Fade("Home", Color.black, 10f);
        }
    }
}
