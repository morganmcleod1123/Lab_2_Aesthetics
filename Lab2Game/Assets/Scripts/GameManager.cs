using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private float score = 0;
    public static GameManager Instance { get; private set; }

    public GameObject dialogueBox;
    public GameObject dialogueText;

    public TextMeshProUGUI scoreText;

    private Coroutine dialogCO;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else 
        {
            Destroy(gameObject);
        }
    }
    public void StartDialogue(string text) 
    {
        dialogueBox.SetActive(true);
        dialogCO = StartCoroutine(TypeText(text));
    }
    public void StopDialogue()
    {
        dialogueBox.SetActive(false);
        StopCoroutine(dialogCO);
    }

    IEnumerator TypeText(string text) {
        dialogueText.GetComponent<TextMeshProUGUI>().text = "";
        foreach (char c in text.ToCharArray()) {
            dialogueText.GetComponent<TextMeshProUGUI>().text += c;
            yield return new WaitForSeconds(0.05f);
        }
    }
    public void IncStamps(int ds)
    {
        score += ds;
        scoreText.text = "Stamps: " + score;
    }
    public void DecStamps(int ds)
    {
        if (score == 0)
        {
            score = 0;
        }
        else
        {
            score -= ds;
            scoreText.text = "Stamps: " + score;
        }
    }
}
