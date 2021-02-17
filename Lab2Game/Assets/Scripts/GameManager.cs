using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   
    public static GameManager Instance { get; private set; }
    
    public float score = 0;
    public float stampsCollected = 0;
    
    //public GameObject particles;

    public GameObject dialogueBox;
    public GameObject dialogueText;


    public TextMeshProUGUI scoreText;
    public GameObject startButton;
    public GameObject backgroundImage;

    public GameObject canvas;
    public GameObject events;

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
            DontDestroyOnLoad(gameObject);
            DontDestroyOnLoad(canvas);
            DontDestroyOnLoad(events);
            //DontDestroyOnLoad(particles);
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

    public void HideDialog(string text)
    {
        dialogueBox.SetActive(false);
        StopAllCoroutines();
    }
    public void IncStamps(int ds)
    {
        score += ds;
        scoreText.text = "Stamps: " + score;
        stampsCollected += ds;
        //stamps -= ds;
        //Debug.Log("Stamps: " + stamps);
        Debug.Log("Score:" + score);
        
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
    
    public void StartButton()
    {
        startButton.SetActive(false);
        StartCoroutine(LoadYourAsyncScene("MailmanWorld"));
    }

    public void EndGame() 
    {
        StartCoroutine(LoadYourAsyncScene("End Screen"));
    }

    IEnumerator LoadYourAsyncScene(string scene) 
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(scene);
        while (!asyncLoad.isDone) 
        {
            yield return null;
        }
        StartCoroutine(ColorLerp(new Color(1, 1, 1, 0), 2));
    }

    
    IEnumerator ColorLerp(Color endValue, float duration)
    {
        float time = 0;
        Image sprite = backgroundImage.GetComponent<Image>();
        Color startValue = sprite.color;
        while (time< duration)
        {
            sprite.color = Color.Lerp(startValue, endValue, time / duration);
            time += Time.deltaTime;
            yield return null;
        }
        sprite.color = endValue;
    }
    public void GameOver()
    {
        startButton.SetActive(true);
        StopAllCoroutines();
        StartCoroutine(ColorLerp(new Color(1, 1, 1, 1), 2));
        //HideDialog();
        
    }
    public float returnscore()
    {
        return score;
    }
    public float returnstamps()
    {
        //Debug.Log(stamps);
        return stampsCollected;
    }

}

