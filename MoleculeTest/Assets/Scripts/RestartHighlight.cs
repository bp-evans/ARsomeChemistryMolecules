using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartHighlight : MonoBehaviour
{

    public void RestartGame()
    {
        SceneManager.LoadScene("TestForTouchCollision");
    }
}