using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FindAudioSource : MonoBehaviour {
    Toggle toggle;
    AudioSource source;
    static bool muted;
	// Use this for initialization
	void Start () {
        toggle = GetComponent<Toggle>();
        source = GameObject.Find("AudioManager").GetComponent<AudioSource>() ;
        toggle.onValueChanged.AddListener(
            (value) => {
                ToggleMute(value);
            }
        );

        toggle.isOn = muted;
        source.mute = muted;
	}
	
    void ToggleMute(bool value)
    {
        muted = value;
        source.mute = muted;
    }
	
}
