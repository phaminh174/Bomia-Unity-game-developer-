using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuCanvas : MonoBehaviour
{
    public GameObject Menu, Instruction;
    public void OnClickedStart()
    {
        SceneManager.LoadScene(1);
    }

    public void OnClickedExit()
    {
        Application.Quit();
    }

    public void OnClickedInstruction()
    {
        Menu.SetActive(false);
        Instruction.SetActive(true);
    }

    public void OnClickedBackButton()
    {
        Menu.SetActive(true);
        Instruction.SetActive(false);
    }
}
