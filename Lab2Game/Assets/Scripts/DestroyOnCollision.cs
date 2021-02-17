using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    private bool dead;
    // Start is called before the first frame update
    void Start()
    {
        dead = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (dead)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            dead = true;
        }
    }
}
