using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class levelScripts : MonoBehaviour
{
    public Button button1, button2, button3, button4, button5, button6, button7, button8;


    public void buton1()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
        AudioListener.volume = 1;
    }
    public void buton2()
    {
        SceneManager.LoadScene(4);
        Time.timeScale = 1;
        AudioListener.volume = 1;
    }
    public void buton3()
    {
        SceneManager.LoadScene(5);
        Time.timeScale = 1;
        AudioListener.volume = 1;
    }
    public void buton4()
    {
        SceneManager.LoadScene(6);
        Time.timeScale = 1;
        AudioListener.volume = 1;
    }
    public void buton5()
    {
        SceneManager.LoadScene(7);
        Time.timeScale = 1;
        AudioListener.volume = 1;
    }
    public void buton6()
    {
        SceneManager.LoadScene(8);
        Time.timeScale = 1;
        AudioListener.volume = 1;
    }

    public void buton7()
    {
        SceneManager.LoadScene(9);
        Time.timeScale = 1;
        AudioListener.volume = 1;
    }
    public void buton8()
    {
        SceneManager.LoadScene(10);
        Time.timeScale = 1;
        AudioListener.volume = 1;
    }

}
