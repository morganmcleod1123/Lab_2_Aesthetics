using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foundstamp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "stamp") {
            Debug.Log("I got the stamp");
            Destroy(collision.gameObject);
            GameManager.Instance.IncStamps(1);
            //GetComponent<AudioSource>().Play();
        }
    }

}
