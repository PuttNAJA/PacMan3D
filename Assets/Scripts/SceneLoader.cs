using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public void ToGame()
    {
        SceneManager.LoadScene("InGame");
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void ToMain()
    {
        SceneManager.LoadScene("Home");
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }

    public void ToOver()
    {

        SceneManager.LoadScene("GameOver");
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }

    public void ToWin()
    {
        SceneManager.LoadScene("Win");
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }

    public void ToQuit()
    {
        Application.Quit();
    }
}
