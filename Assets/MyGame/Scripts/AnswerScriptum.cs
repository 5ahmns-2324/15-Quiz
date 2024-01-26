using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerScriptum : MonoBehaviour
{
    public bool correct = false;
    public QuestionManager qM;
    public Button btn;
    public Color startColor;

    void Start()
    {
        startColor = GetComponent<Image>().color;    
    }
    public void Answer()
    {
        if (correct)
        {
            GetComponent<Image>().color = Color.green;
            Debug.Log("correct Answer");
            qM.Correct();
            
        }
        else
        {
            GetComponent<Image>().color = Color.red;
            Debug.Log("wrong Answer");
        }


    }


    public void ResetColorNew()
    {
        GetComponent<Image>().color = Color.white;
       
    }
}
