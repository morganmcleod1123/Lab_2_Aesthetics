using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class givestamp : MonoBehaviour
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
        if (collision.gameObject.tag == "house" && GameManager.Instance.returnscore() > 0)
        {
            Debug.Log("stamp given");
            GameManager.Instance.DecStamps(1);
            GetComponent<AudioSource>().Play();
            
        }
    }
}
