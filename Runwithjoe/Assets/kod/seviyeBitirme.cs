using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class seviyeBitirme : MonoBehaviour
{


    public void seviye1bitirme()
    {
        seviyeYonetici.seviye2 = true;
        SceneManager.LoadScene(3);


    }

    public void seviye2bitirme()
    {
        seviyeYonetici.seviye3 = true;
        SceneManager.LoadScene(3);
    }
    public void seviye3bitirme()
    {
        seviyeYonetici.seviye4 = true;
        SceneManager.LoadScene(3);
    }
    public void seviye4bitirme()
    {
        seviyeYonetici.seviye5 = true;
        SceneManager.LoadScene(3);
    }
    public void seviye5bitirme()
    {
        seviyeYonetici.seviye6 = true;
        SceneManager.LoadScene(3);
    }
    public void seviye6bitirme()
    {
        seviyeYonetici.seviye7 = true;
        SceneManager.LoadScene(3);
    }
    public void seviye7bitirme()
    {
        seviyeYonetici.seviye8 = true;
        SceneManager.LoadScene(3);
    }

    public void seviye8bitirme()
    {
        seviyeYonetici.gameEnd = true;
        SceneManager.LoadScene(11);
    }
}
