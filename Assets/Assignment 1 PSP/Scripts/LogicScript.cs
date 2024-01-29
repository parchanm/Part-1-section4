using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public GameObject gameOverScreen; //making a reference to gameoverscreen
    public GameObject gameWinScreen;

    public void restartGasme()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //on click, load the active scene
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true); //game over screen active
    }

    public void gameWin()
    {
        gameWinScreen.SetActive(true); //game win screen active
    }
}
