using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace arcadeResultDisplay
{
    public class Arcade_Result_Display : MonoBehaviour
    {
        // Use this for initialization
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {

            if (arcadecountdown.Arcade_Countdown_Script.canCount)
            {
                if (arcadedetecttouch.Arcade_Touch_Detect.done)
                {
                    if (arcadedetecttouch.Arcade_Touch_Detect.judjement)
                    {
                        arcadestatistics.Arcaade_Statistics_Setter.correctAnswerCount++;
                        arcadedetecttouch.Arcade_Touch_Detect.judjement = true;
                        arcadedetecttouch.Arcade_Touch_Detect.done = false;
                        Initiate.Fade("Arcade", Color.black, 5f);

                    }
                    else
                    {
                        arcadedetecttouch.Arcade_Touch_Detect.judjement = true;
                        arcadedetecttouch.Arcade_Touch_Detect.done = false;
                        Initiate.Fade("ArcadeResult", Color.black, 10f);
                    }
                }

            }
            // If time is up then reinitialise all the variables for the next scene 
            // So that it dosen't take input from the user after the time is up
            else
            {
                arcadedetecttouch.Arcade_Touch_Detect.judjement = true;
                arcadedetecttouch.Arcade_Touch_Detect.done = false;
                Initiate.Fade("ArcadeResult", Color.black, 10f);
            }

        }
    }
}