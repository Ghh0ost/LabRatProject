using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fall : MonoBehaviour
{
    public float fallSpeed = 4.0f; //how fast the object fall
    private bool CanFall;

    //should move the pigeon down the screen
    void Update()
    {
        if (CanFall == true)
        {
            transform.Translate(Vector2.down * fallSpeed * Time.deltaTime);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}

