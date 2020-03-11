using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class anim_for_home : MonoBehaviour
{
    public Sprite[] Anim;
    public Image obj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        obj.sprite=Anim[(int)(Time.time*10)%Anim.Length];
    }
}
