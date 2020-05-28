using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausedCanvas : MonoBehaviour
{
    public GameObject closedRoot, openRoot;
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }
    public void Resume()
    {
        closedRoot.SetActive(false);
        openRoot.SetActive(true);
        Time.timeScale = 1;
    }
}
