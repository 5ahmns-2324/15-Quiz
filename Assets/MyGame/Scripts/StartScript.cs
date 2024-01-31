using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class StartScript : MonoBehaviour
{
    public Image startBG;
    public Button startBtn;
    public Toggle rndm;
    

    public void StartGame()
    {
        startBG.gameObject.SetActive(false);
        startBtn.gameObject.SetActive(false);
        rndm.gameObject.SetActive(false);
    }

 
}
