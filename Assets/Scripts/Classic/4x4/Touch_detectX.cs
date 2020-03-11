using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;
namespace detectTouchx
{
    public class Touch_detectX : MonoBehaviour
    {
        public Button dot;
        public static bool done = false;
        public static bool judjement = true;
        public Sprite image;
        public int number;
        public static int[] originalArray;
        static int[] presentArray;
        static int index = 0;
        static bool input_enabled;
        static bool oneButtonTouched = false;
        // Use this for initialization
        void Start()
        {
            index = 0;
            // dot = GetComponent<Button>();
            // dot.onClick.AddListener(OnMouseDown);
            originalArray = PatternNumberGenerator4x.Programx.finalArray;
            presentArray = new int[PatternNumberGenerator4x.Programx.finalArray.Length];
            Invoke("EnableInput", 0.3f);
        }
        void EnableInput()
        {
            input_enabled = true;
            oneButtonTouched = false;
        }
        // Update is called once per frame
        void Update()
        {
            if (oneButtonTouched && Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                detectTouchx.Touch_detectX.done = false;
                detectTouchx.Touch_detectX.judjement = true;
                if (resultDisplayX.Result_displayX.questionCount <= 3)
                {
                    Initiate.Fade("gameScreen_4x", Color.black,5f);
                }
                else
                {
                    Initiate.Fade("Result4x", Color.black,10f);
                }

            }

            // If time is up then reinitialise all the variables for the next scene 
            // So that it dosen't take input from the user after the time is up
            if (!(clock_counter.CountdownScript.canCount))
            {
                done = true;
                judjement = false;
                input_enabled = false;
            }
        }
        public void onhoverOnButton()
        {
            oneButtonTouched = true;
            if (input_enabled)
            {
                if (index < originalArray.Length)
                {
                    // Checking whether the number is already present or not
                    bool present = false;
                    for (int i = 0; i < index; ++i)
                    {
                        if (presentArray[i] == number)
                            present = true;
                    }
                    // Push the number if the number is first or not present in the array
                    if (!present || index == 0)
                        presentArray[index] = number;
                    // Entered first wrong digit
                    if (!present && number != originalArray[index])
                    {
                        Debug.Log("wrong answer");
                        done = true;
                        judjement = false;
                        input_enabled = false;
                        oneButtonTouched = false;
                        // We should not count the time if user touches wrong digit
                        // Vibrate when wrong button is pressed
                        Handheld.Vibrate();
                        clock_counter.CountdownScript.canCount = false;
                        // Display retry button
                    }
                    // Increment the index only if the number is valid
                    if (!present || index == 0)
                        index++;

                }
                // Change the dot color when touched
                dot.GetComponent<Image>().sprite = image;
                // Check if the input pattern is correct or not with checkSum()
                if (index == originalArray.Length)
                {
                    checkSum();
                }
            }
        }
        void checkSum()
        {
            // When this function is called that means user didn't enter any wrong digit till size of the number
            // So no need to check the whole array again
            // We just reinitialise all the variables for the next scene
            done = true;
            judjement = true;
            input_enabled = false;
            // Go to next Level
            // Display ads
        }

    }

}