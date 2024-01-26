using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountManager : MonoBehaviour
{
    public TextMeshProUGUI countdownText;
    public float countdownTime = 20f;
    public QuestionManager qM;
    public Image panel;
    public Button restart;
    public TextMeshProUGUI countRes;
    

    void Start()
    {
        InvokeRepeating("Countdown", 1f, 1f);
        if (qM.nextQuestion)
        {
            CancelInvoke();
            
        }
    }

  
        

    void Countdown()
    {

        if (countdownTime <= 0f)
        {

            Debug.Log("Countdown reached zero!");

            CancelInvoke("Countdown");
            panel.gameObject.SetActive(true);
            restart.gameObject.SetActive(true);
            countRes.gameObject.SetActive(true);
            countRes.text = qM.questionCount.ToString();


        }

        countdownTime -= 1f;

        
        UpdateCountdownText();

        
       
    }

    void UpdateCountdownText()
    {
        
        int minutes = Mathf.FloorToInt(countdownTime / 60f);
        int seconds = Mathf.FloorToInt(countdownTime % 60f);

       
        countdownText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
