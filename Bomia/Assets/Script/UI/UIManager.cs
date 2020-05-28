using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void OnBacktoMenuClicked()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}
