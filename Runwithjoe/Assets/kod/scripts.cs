using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scripts : MonoBehaviour
{
    float hiz;
    public float harekethizi;
    void Update()
    {
        // hiz = harekethizi * Input.GetAxis("Horizontal");
        transform.Translate(hiz * Time.deltaTime, 0f, 0f);

        float sinirlar = Mathf.Clamp(transform.position.x, -8.19f, 8.9f);
        transform.position = new Vector2(sinirlar, transform.position.y);
    }

    public void sol()
    {
        hiz = -13;
    }

    public void sag()
    {
        hiz = 13;
    }


    public void dur()
    {
        hiz = 0;
    }
}
