using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NavigationScript : MonoBehaviour
{
    public string[] questions = new string[5];
    public TextMeshProUGUI question;
    public AnswerController a1;
    public AnswerController a2;
    public AnswerController a3;
    public Canvas[] questionss = new Canvas[2];
    
    
    // Start is called before the first frame update
    void Start()
    {
        SetRandomQuestion();
        

    }

    public void Weiter()
    {
        
        
         SetRandomQuestion();
        
        

    }
    // Update is called once per frame
    
    public void SetRandomQuestion()
    {
       
        question.text = questions[Random.Range(1, 5)];
        

     

    }


}
