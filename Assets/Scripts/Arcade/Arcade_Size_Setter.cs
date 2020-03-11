using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arcade_Size_Setter : MonoBehaviour {

	// Use this for initialization
	void Start () {
        System.Random t = new System.Random();
        PatternGameNumberGenerator.Program.SIZE = t.Next(3,10);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
