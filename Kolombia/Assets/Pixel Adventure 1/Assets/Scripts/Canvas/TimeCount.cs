using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCount : MonoBehaviour
{
    public LevelController LevelController;
    public Text timeCount;
    public bool startCounting;
    public Animator animator;

    private void Start()
    {
        timeCount.text = LevelController.LevelTime.ToString("0.00");
    }
    // Update is called once per frame
    void Update()
    {
        if (startCounting) timeSubtract();
    }

    public void timeSubtract()
    {
        if (LevelController.LevelTime <= 5)
        {
            animator.Play("FlashingTimeAnim");
        }
        if (LevelController.LevelTime <= 0)
        {
            timeCount.text = "0.00";
        }
        else
        {
            LevelController.LevelTime -= Time.deltaTime;
            timeCount.text = LevelController.LevelTime.ToString("0.00");
        }
    }

    public void StopCountingTime()
    {
        startCounting = false;
    }
}
