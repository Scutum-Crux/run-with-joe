using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class health : MonoBehaviour
{

    public cubuk skor;
    public int playerHealth;
    [SerializeField] private Image[] hearts;


    public void UpdateHealth()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < playerHealth)
            {
                hearts[i].color = Color.red;

            }

            else
            {
                hearts[i].color = Color.black;
            }


            if (playerHealth == 0)
            {
                SceneManager.LoadScene(2);


            }

        }


    }

    void Start()
    {
        UpdateHealth();

    }


}
