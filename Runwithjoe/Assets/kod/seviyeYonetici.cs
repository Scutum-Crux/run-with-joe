using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class seviyeYonetici : MonoBehaviour
{

    public Button s1Button, s2Button, s3Button, s4Button, s5Button, s6Button, s7Button, s8Button;
    public static bool seviye1, seviye2, seviye3, seviye4, seviye5, seviye6, seviye7, seviye8, gameEnd;

    public void Start()
    {

        seviye1 = true;
    }

    private void Update()
    {

        if (seviye2 == true)
        {
            s2Button.interactable = true;

        }
        if (seviye3 == true)
        {
            s3Button.interactable = true;

        }
        if (seviye4 == true)
        {
            s4Button.interactable = true;

        }
        if (seviye5 == true)
        {
            s5Button.interactable = true;

        }
        if (seviye6 == true)
        {
            s6Button.interactable = true;

        }
        if (seviye7 == true)
        {
            s7Button.interactable = true;

        }
        if (seviye8 == true)
        {
            s8Button.interactable = true;

        }

    }
}
