using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dog : MonoBehaviour
{
    // Start is called before the first frame update

    public List<GameObject> locs;
    private Queue<GameObject> qlocs;
    public float duration = 3f;

    void Start()
    {
        qlocs = new Queue<GameObject>();
        foreach (GameObject go in locs)
        {
            qlocs.Enqueue(go);
        }
        NextUp();
    }
    void NextUp()
    {
        GameObject pong = qlocs.Dequeue();
        StartCoroutine(LerpPosition(pong.transform.position));
        qlocs.Enqueue(pong);
    }

    IEnumerator LerpPosition(Vector3 targetPosition)
    {
        float time = 0;
        Vector3 startPosition = transform.position;
        while(time< duration)
        {
            transform.position = Vector3.Lerp(startPosition, targetPosition, time / duration);
            time += Time.deltaTime;
            yield return null;
        }
        transform.position = targetPosition;
        NextUp();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.GameOver();
        }
    }

}
