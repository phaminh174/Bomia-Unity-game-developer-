using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    public LevelLoad LevelLoad;
    public float LevelTime;
    public int fruitsAmount;
    public void Replay()
    {
        LevelLoad.LoadNextLevel(SceneManager.GetActiveScene().buildIndex);
    }

    public void FruitsSubtract()
    {
        fruitsAmount--;
        if (fruitsAmount==0)
        {
            LevelLoad.LoadNextLevel(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
