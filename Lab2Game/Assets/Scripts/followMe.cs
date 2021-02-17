using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followMe : MonoBehaviour
{
    public TrailRenderer trail;

    private Rigidbody2D body;
    private float horizontal;
    private float vertical;
    private float runSpeed = 10f;
    public float moveLimiter = 2 ;

    private bool speedBoost;


    void Start()
    {
        trail = gameObject.GetComponentInChildren<TrailRenderer>();
        body = GetComponent<Rigidbody2D>();
        speedBoost = false;
        trail.emitting = false;
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
        if (!speedBoost)
        {
             body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
            trail.emitting = false;
        
        } else
         {
             body.velocity = new Vector2(horizontal * runSpeed * 1.5f, vertical * runSpeed * 1.5f);
             trail.emitting = true;
         }
    }
    public void Boost(bool boosting) {
        this.speedBoost = boosting;
    }
}
