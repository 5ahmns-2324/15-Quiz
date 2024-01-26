using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerScript : MonoBehaviour
{
    public bool correct = false;
	public QuestionManager qM;
   public void Answer()
   {
		if (correct)
		{
			Debug.Log("correct Answer");
			qM.Correct();
		}
		else
		{
            Debug.Log("wrong Answer");
        }
   }
}
