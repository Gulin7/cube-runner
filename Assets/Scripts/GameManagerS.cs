using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerS : MonoBehaviour
{
    bool GameEnd = false;
    float delay = 1.5f;
    public GameObject completelevelUI;
    public void GameOver()
    {
        if (GameEnd == false)
        {
            GameEnd = true;
            Debug.Log("Game Over");
            Invoke("Restart", delay);
        }    
    }    
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void FinishLevel()
    {
        if (GameEnd == false)
        {
            GameEnd = true;
            Debug.Log("You've finished the level!Congratulations!");
            completelevelUI.SetActive(true);
        }
    }
}
