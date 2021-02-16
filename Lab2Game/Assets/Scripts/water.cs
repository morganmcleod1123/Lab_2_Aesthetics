using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Walking on Water");
        if (collision.gameObject.CompareTag("Player"))
        {
            followMe fm = collision.gameObject.GetComponent<followMe>();
            fm.Boost(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Leaving the Water");
        if (collision.gameObject.CompareTag("Player")) {
            followMe fm = collision.gameObject.GetComponent<followMe>();
            fm.Boost(false);
        }
    }
}
