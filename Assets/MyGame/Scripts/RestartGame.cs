using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class RestartGame : MonoBehaviour
{
    public Button restartBtn;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Restart()
    {
        SceneManager.LoadScene("QuizScene");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
