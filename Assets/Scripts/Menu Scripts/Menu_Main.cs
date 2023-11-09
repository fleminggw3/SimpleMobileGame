using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Main : MonoBehaviour
{
    public void pressPlay() {
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }

    public void pressQuit() {
        Debug.Log("QUIT GAME");
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
