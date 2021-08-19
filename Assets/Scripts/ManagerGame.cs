using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ManagerGame : MonoBehaviour
{
    private bool gameEnded = false;
    // Update is called once per frame
    void Update()
    {
        if (gameEnded)
            return;

        if (PlayerStats.Lives <= 0)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        gameEnded = true;
        SceneManager.LoadScene("GameOverScene");
        Debug.Log ("Game Over!");
    }
}
