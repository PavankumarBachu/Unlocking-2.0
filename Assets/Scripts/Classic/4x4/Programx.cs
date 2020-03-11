using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
namespace PatternNumberGenerator4x
{
    public class Programx : MonoBehaviour
    {
        public Text number;
        public static int loopCount = 0;
        public static int SIZE = 12;
        public static int MAX = 16;
        public static string final_num = "";
        public static int[] finalArray;
        public static int fqs;
        public static int sqs;
        public static int tqs;
        public static float disappearTime;
        public void Awake()
        {
            if (resultDisplayX.Result_displayX.questionCount == 1)
            {
                SIZE = fqs;
            }
            else if (resultDisplayX.Result_displayX.questionCount == 2)
            {
                SIZE = sqs;
            }
            else
            {
                SIZE = tqs;
            }
            Compute();
            resultDisplayX.Result_displayX.questionCount++;
            number.text = final_num;
        }
        public void Update()
        {
            if (chapterNUmber4x2.chapterNumberHolder4x2.chapterNumber4x == 4)
            {
                int timer = (int)clock_counter.CountdownScript.timer;
                if (timer % 2 == 0)
                {
                    number.text = "";
                }
                else
                {
                    number.text = final_num;
                }
            }
        }
        static void Compute()
        {
            int[] lengths = new int[16] { 9, 10, 11, 9, 11, 12, 12, 11, 9, 10, 10, 9, 9, 12, 11, 9};
            int[,] n = new int[16, 14] {
                { 2,5,6,7,8,10,12,14,15,0,0,0,0,0},
                { 1,3,5,6,7,8,9,11,13,15,0,0,0,0 },
                { 2,4,5,6,7,8,10,12,13,14,16,0,0,0 },
                { 3,5,6,7,8,9,11,14,15,0,0,0,0,0 },
                { 1,2,3,4,6,9,10,11,12,14,16,0,0,0 },
                { 1,2,3,4,5,7,9,10,11,12,13,15,0,0 },
                { 1,2,3,4,6,8,9,10,11,12,14,16,0,0 },
                { 1,2,3,4,7,9,10,11,12,13,15,0,0,0 },
                { 5,6,7,8,10,13,14,15,16,0,0,0,0,0 },
                { 5,6,7,8,9,11,13,14,15,16,0,0,0,0 },
                { 5,6,7,8,10,12,13,14,15,16,0,0,0,0 },
                { 5,6,7,8,11,13,14,15,16,0,0,0,0,0 },
                { 2,3,6,8,9,10,11,12,14,0,0,0,0,0},
                { 1,3,4,5,7,8,9,10,11,12,13,15,0,0},
                { 1,2,4,6,8,9,10,11,12,14,16,0,0,0},
                { 2,3,5,7,9,10,11,12,15,0,0,0,0,0}
            };

            System.Random r = new System.Random();
            finalArray = new int[SIZE];
            int index = 0;
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
                while (!valid && loopCount < 50);
                if (valid)
                    finalArray[++index] = a;
                else
                {
                    Compute();
                }
                final_num = "";
                for (int i = 0; i < finalArray.Length; i++)
                    final_num += finalArray[i].ToString() + " ";
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
