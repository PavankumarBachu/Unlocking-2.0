using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class toClassic : MonoBehaviour {
    Button btn;
	// Use this for initialization
	void Start () {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(OnMouseDown);
	}
	
	// Update is called once per frame
	void OnMouseDown () {
        Initiate.Fade("Classic_screen", Color.black, 10f);
	}
}
