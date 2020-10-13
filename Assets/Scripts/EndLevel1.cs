using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevel1 : MonoBehaviour
{
    public GameManagerS gameManager;

    public void OnTriggerEnter ()
    {
        gameManager.FinishLevel();
    }
}
