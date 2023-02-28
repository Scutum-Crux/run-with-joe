using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canYenileme : MonoBehaviour
{
    public AudioSource au;
    public int saglikdoldurma = 1;


    public health _health;

    public int maxHealth = 3;






    private void OnCollisionEnter2D(Collision2D temas)
    {

        float xpozisyonu = Random.Range(-8f, 8f);
        float ypozisyonu = Random.Range(7.5f, 11f);

        if (temas.gameObject.tag == "zemin")

        {
            transform.position = new Vector2(xpozisyonu, ypozisyonu);
        }

        else if (temas.gameObject.tag == "karakter")
        {
            transform.position = new Vector2(xpozisyonu, ypozisyonu);
            au.Play();
            healthrefresh();


        }



    }



    void healthrefresh()
    {
        if (_health.playerHealth == maxHealth)
        {
            saglikdoldurma = 0;
            _health.playerHealth = _health.playerHealth + 0;

        }
        else
        {
            saglikdoldurma = 1;
            _health.playerHealth = _health.playerHealth + saglikdoldurma;
            _health.UpdateHealth();

        }


    }
}
