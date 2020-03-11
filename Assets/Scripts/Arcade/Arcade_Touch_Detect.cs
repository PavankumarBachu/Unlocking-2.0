using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace arcadedetecttouch
{
    public class Arcade_Touch_Detect : MonoBehaviour
    {

        public Button dot;
        public static bool done = false;
        public static bool judjement = true;
        public Sprite image;
        public int number;
        public static int[] originalArray;
        static int[] presentArray;
        static int index = 0;
        public static bool input_enabled;
        public static bool oneButtonTouched = false;
        // Use this for initialization
        void Start()
        {
            index = 0;
            // dot = GetComponent<Button>();
            // dot.onClick.AddListener(OnMouseDown);
            oneButtonTouched = false;
            originalArray= arcadePatternNumberGenerator.Arcade_Program.finalArray;
            presentArray = new int[arcadePatternNumberGenerator.Arcade_Program.finalArray.Length];
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
                arcadedetecttouch.Arcade_Touch_Detect.judjement = true;
                arcadedetecttouch.Arcade_Touch_Detect.done = false;
                Initiate.Fade("ArcadeResult", Color.black, 10f);
                arcadecountdown.Arcade_Countdown_Script.curenttime = 20;

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
                        done = true;
                        judjement = false;
                        input_enabled = false;
                        // We should not count the time if user touches wrong digit
                        arcadecountdown.Arcade_Countdown_Script.canCount = false;
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