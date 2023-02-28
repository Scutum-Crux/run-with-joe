using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class can2 : MonoBehaviour
{

    public AudioSource au;
    [SerializeField] private int cubukdamage;
    [SerializeField] public health _health;


    private void OnCollisionEnter2D(Collision2D temas)
    {
        if (temas.gameObject.tag == "karakter")
        {
            damage();
            au.Play();

        }


    }

    void damage()
    {
        _health.playerHealth = _health.playerHealth - cubukdamage;
        _health.UpdateHealth();


    }


}
