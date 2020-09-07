using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoad : MonoBehaviour
{
    public float timeBetweenScenes;
    public Animator LoadScenesAnim;


    public void LoadNextLevel(int LevelIndex)
    {
        StartCoroutine(LoadLevel(LevelIndex));
    }
    IEnumerator LoadLevel(int LevelIndex)
    {
        LoadScenesAnim.SetTrigger("LevelEnd");
        yield return new WaitForSeconds(timeBetweenScenes);
        SceneManager.LoadScene(LevelIndex);
    }
}
