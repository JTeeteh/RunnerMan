using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Stage_1");

    }

    /*public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }*/

    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }
    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }
    /*public void VashuKek()
    {
        SceneManager.LoadScene("VashScare");
    }
    public void YouFool()
    {
        SceneManager.LoadScene("GameOver");
    }
    public void ReTry()
    {
        SceneManager.LoadScene("Stage 1");
    }*/
}
