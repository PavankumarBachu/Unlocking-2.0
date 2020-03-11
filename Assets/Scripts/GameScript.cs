using UnityEngine;
using System.Collections;

public class GameScript : MonoBehaviour
{

    public static bool isGameOver;

    // Use this for initialization
    void Start()
    {

        isGameOver = false;

        GameOver();

    }

    void GameOver()
    {
        isGameOver = true;

        Debug.Log("GAME OVER");
    }

    // Update is called once per frame
    void Update()
    {

    }
}

