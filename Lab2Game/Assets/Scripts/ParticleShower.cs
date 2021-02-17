using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleShower : MonoBehaviour
{
    public GameObject particles;
    public GameObject trash;
    private ParticleSystem ps;
    // Start is called before the first frame update
    void Start()
    {
        ps = particles.GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Congratulations()
    {
        //ps.Play();
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            if (GameManager.Instance.score > 0)
            {
                ps.Play();
                if (GameManager.Instance.score == 0)
                {
                    Destroy(trash);
                }
            }
        }
    }
}
