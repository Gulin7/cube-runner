using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ENDGAME : MonoBehaviour
{
    public void OnTriggerEnter()
    {
        SceneManager.LoadScene(0);
    }
}
