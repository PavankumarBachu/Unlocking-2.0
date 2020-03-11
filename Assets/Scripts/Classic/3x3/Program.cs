using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
/*
1 ==== > 2,4,5,6,8
2 ==== > 1,3,4,5,6,7,9
3 ==== > 2,4,5,6,8
4 ==== > 1,2,3,5,7,8,9
5 ==== > 1,2,3,4,6,7,8,9
6 ==== > 1,2,3,5,7,8,9
7 ==== > 2,4,5,6,8
8 ==== > 1,3,4,5,6,7,9
9 ==== > 2,4,5,6,8
*/
namespace PatternGameNumberGenerator
{
    class Program : UnityEngine.MonoBehaviour
    {
        static int computeDebugNumber = 0;
        // The number array
        public static int[] finalArray;
        // Text box on the screen
        public Text num;
        // Final number in string format
        public static String final_num = "";
        // Helps us to escape from the infinite loop while generating the number
        public static int loopCount = 0;
        // Size of the number displayes
        public static int SIZE = 5;
        // Maximum number that can appear in the number
        public static int MAX = 9;
        // Variables for setting variable question lenghts
        public static int fqs;
        public static int sqs;
        public static int tqs;
        // Disappear time
        public static float disappearTime;
        public void Update()
        {
            // To make the question disappear after some time
            if (chapterNumber2.chapterNumberHolder2.chapterNumber == 2)
            {
                if (clock_counter.CountdownScript.timer <= clock_counter.CountdownScript.mainTimer - disappearTime)
                {
                    num.text = "";
                }

            }
            if (chapterNUmber3.chapterNUmberHolder3.chapterNumber == 3)
            {
                int timer = (int)clock_counter.CountdownScript.timer;
                float timerr = (float)clock_counter.CountdownScript.timer;
                int current_time = (int)Time.deltaTime;
                if (timer % 2 != 0)
                {
                    if (timerr - timer >= 0.5f)
                    {
                        num.text = "";

                    }
                    else
                    {
                        num.text = final_num;
                    }
                }
                else
                {
                    if (timerr - timer >= 0.5f)
                    {
                        num.text = "";

                    }
                    else
                    {
                        num.text = final_num;
                    }
                }
            }
        }
        private void Awake()
        {
            num.text = "";
            num = GetComponent<Text>();
            // Setting variable question lengths
            if (display_Result.Result_display.questionCount == 1)
            {
                SIZE = fqs;
            }
            else if (display_Result.Result_display.questionCount == 2)
            {
                SIZE = sqs;
            }
            else
            {
                SIZE = tqs;
            }
            Compute();
            display_Result.Result_display.questionCount++;
            num.text = final_num;
        }
        public static void Compute()
        {
            Debug.Log("****");
            Debug.Log(computeDebugNumber);
            Debug.Log("****");
            computeDebugNumber++;
            // Number of possibilites for each number
            int[] lengths = new int[9] { 5, 7, 5, 7, 8, 7, 5, 7, 5 };
            int[,] n = new int[9, 8] {
                { 2, 4, 5, 6, 8, 0, 0, 0 },
                { 1, 3, 4, 5, 6, 7, 9, 0 },
                { 2, 4, 5, 6, 8, 0, 0, 0 },
                { 1, 2, 3, 5, 7, 8, 9, 0 },
                { 1, 2, 3, 4, 6, 7, 8, 9 },
                { 1, 2, 3, 5, 7, 8, 9, 0 },
                { 2, 4, 5, 6, 8, 0, 0, 0 },
                { 1, 3, 4, 5, 6, 7, 9, 0 },
                { 2, 4, 5, 6, 8, 0, 0, 0 }
            };
            System.Random r = new System.Random();
            finalArray = new int[SIZE];
            int index = 0;
            // Generating the first number
            finalArray[index] = r.Next(MAX) + 1;
            bool valid;
            int a;
            while (index < SIZE - 1)
            {

                loopCount = 0;
                valid = false;
                do
                {
                    a = n[finalArray[index] - 1, r.Next(lengths[finalArray[index] - 1])];
                    valid = !present(finalArray, index, a);
                    ++loopCount;
                }
                // Assuming that we do get the number for maximum 50 tries
                while (!valid && loopCount < 50);
                if (valid)
                    finalArray[++index] = a;
                else
                {
                    Compute();
                }
                final_num = "";
                for (int i = 0; i < finalArray.Length; i++)
                {
                    final_num += finalArray[i].ToString() + " ";
                }
            }
        }
        public static bool present(int[] arr, int len, int num)
        {
            int i;
            for (i = 0; i < len; i++)
            {
                if (arr[i] == num)
                    return true;
            }
            return false;
        }
    }
}