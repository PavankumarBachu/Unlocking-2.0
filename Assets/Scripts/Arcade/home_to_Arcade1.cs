using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class home_to_Arcade1 : MonoBehaviour {
    Button arcadebtn;
    private void Start()
    {
        arcadebtn = GetComponent<Button>();
        arcadebtn.onClick.AddListener(changeScreen);
    }
    public void changeScreen()
    {
        Initiate.Fade("Arcade_Lvl_Difficulty", Color.black ,10f);
    }
}
