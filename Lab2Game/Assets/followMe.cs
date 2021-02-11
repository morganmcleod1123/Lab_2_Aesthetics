using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followMe : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D body;
    private float horizontal;
    private float vertical;
    private float runSpeed = 10f;
    private float moveLimiter = 2 ;
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }
    private void FixedUpdate()
    {
        if (horizontal != 0 && vertical != 0)
        {
           horizontal = horizontal/ moveLimiter;
           vertical = vertical/ moveLimiter;
        }
        body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
    }
}
