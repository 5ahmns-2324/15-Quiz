using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class AnswerController : MonoBehaviour
{
    public string[] answers = new string[5];
    public bool answerCorrect;
    public Button btn;
    public ColorBlock cblCorrect;
    public ColorBlock cblWrong;
    public Button nextQ;
    
    
  

    public void Maus()
    {
        string objName = name;
        Debug.Log(objName);
     


        if (answerCorrect)
        {
            Debug.Log("correct");
            btn.colors = cblCorrect;
            

        }
        else
        {
            Debug.Log("wrong");
            btn.colors = cblWrong;
        }
    }
    void Update()
    {
        nextQ.gameObject.SetActive(true);
    }
}
