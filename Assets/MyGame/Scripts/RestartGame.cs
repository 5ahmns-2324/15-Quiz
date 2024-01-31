using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class RestartGame : MonoBehaviour
{
    public Button restartBtn;
 
    public void Restart()
    {
        SceneManager.LoadScene("QuizScene");
    }
}
