using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class cubuk : MonoBehaviour
{


    private static int skor;
    public TextMeshProUGUI skoryazisi;

    private void Start()
    {

        skor = 0;
    }

    void Update()
    {

        skoryazisi.text = skor.ToString();

    }
    void OnCollisionEnter2D(Collision2D temas)
    {

        float xpozisyonu = Random.Range(-8f, 8f);
        float ypozisyonu = Random.Range(7.5f, 11f);

        if (temas.gameObject.tag == "zemin")

        {
            transform.position = new Vector2(xpozisyonu, ypozisyonu);
            skor += 10;


        }
        else if (temas.gameObject.tag == "karakter")
        {
            transform.position = new Vector2(xpozisyonu, ypozisyonu);


        }


    }



}
