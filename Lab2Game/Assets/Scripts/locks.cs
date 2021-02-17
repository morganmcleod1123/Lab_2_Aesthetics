using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class locks : MonoBehaviour
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
       
        if (GameManager.Instance.returnscore() == 0 && (collision.gameObject.tag == "locks"))
            {
            Debug.Log("you have collided with the lock");
            Destroy(collision.gameObject);
            }
        
  
        }
    }
