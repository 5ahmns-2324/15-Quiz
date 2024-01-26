using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QuestionManager : MonoBehaviour
{
    public List<QuestionAnswerScript> QnA;
    public GameObject[] options;
    public int currentQuestion;
    public bool nextQuestion = false;
    public Button nextBtn;
    public AnswerScriptum[] aS;
    public int questionCount = 0;
    public Toggle randomizedQ;
    public CountManager cM;
    public AudioSource bGSound;
    public AudioSource correctSound;
    public AudioSource wrongSound;
    public Sprite[] sprites;
    public Image image;
   



    public TextMeshProUGUI questionTxt;

    private void Start()
    {
        GenerateQuestion();
    }

    public void Correct()
    {
        //wenn Frage richtig beantwortet ist, erscheint Weiter Button
        correctSound.Play(); 
        nextQuestion = true;
        nextBtn.gameObject.SetActive(true);
        questionCount++;
       
    }

    void SetAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswerScriptum>().correct = false;
            
            options[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = QnA[currentQuestion].answers[i];

            if (QnA[currentQuestion].correctAnswer == i + 1)
            {
                options[i].GetComponent<AnswerScriptum>().correct = true;
                
                
            }
        }
    }

    public void GenerateQuestion()
    {
        image.sprite = sprites[Random.Range(0, sprites.Length)];
        if (randomizedQ.isOn)
        {
            currentQuestion = Random.Range(0, QnA.Count);
        }
        else
        {
            currentQuestion++;
            
        }
        if (currentQuestion >= QnA.Count)
        {
            cM.countdownTime = 0;
            cM.panel.gameObject.SetActive(true);
        }
        questionTxt.text = QnA[currentQuestion].question;
        SetAnswers();
        nextBtn.gameObject.SetActive(false);
        
    }

}
