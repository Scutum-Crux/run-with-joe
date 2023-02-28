using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class restartgame : MonoBehaviour
{

    public void restartthegame()
    {


        SceneManager.LoadScene(3);

    }

    public void mainmenu()
    {
        SceneManager.LoadScene(0);
    }

    public void quitgame()
    {
        Application.Quit();

    }
}
