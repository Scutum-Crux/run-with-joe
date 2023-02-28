using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class keyScript : MonoBehaviour
{


    public AudioSource au;
    public GameObject nextbuton;
    public GameObject key;
    void Start()
    {

        InvokeRepeating("rastgeleolustur", 10f, 10f);

    }

    void OnCollisionEnter2D(Collision2D temas)
    {

        float xpozisyonu = Random.Range(-8f, 8f);
        float ypozisyonu = Random.Range(7.5f, 11f);


        if (temas.gameObject.tag == "zemin")
        {
            key.gameObject.SetActive(false);

        }
        if (temas.gameObject.tag == "karakter")
        {

            Time.timeScale = 0;
            nextbuton.gameObject.SetActive(true);
            AudioListener.volume = 2;
            au.Play();

        }

    }
    public void rastgeleolustur()
    {
        float xpozisyonu = Random.Range(-8f, 8f);
        float ypozisyonu = Random.Range(7.5f, 11f);

        Instantiate(key, new Vector2(xpozisyonu, ypozisyonu), Quaternion.identity);

    }
}
