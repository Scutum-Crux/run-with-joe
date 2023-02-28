using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    public bool oyundurdurma = false;
    public void oyundurdur()
    {
        if (oyundurdurma==false)
        {
            Time.timeScale = 0;
            oyundurdurma = true;
            AudioListener.volume = 0;

        }
        else
        {
            Time.timeScale = 1;
            oyundurdurma = false;
            AudioListener.volume = 1;
        }
    }
}
