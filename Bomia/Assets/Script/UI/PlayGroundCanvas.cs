using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayGroundCanvas : MonoBehaviour
{
    public GameObject closedRoot, openRoot;
    public Text Score_Paused, Score_PlayGround, Score_DieCanvas;
    int intScore = 0;
    
    public void OnclickedPaused()
    {
        Time.timeScale = 0;
        closedRoot.SetActive(false);
        openRoot.SetActive(true);
    }

    public void AddScore()
    {
        intScore += 10;
        //Score_PlayGround.text = intScore.ToString();
        Score_PlayGround.text = Score_DieCanvas.text = Score_Paused.text = "Score: " + intScore.ToString();
    }
}
