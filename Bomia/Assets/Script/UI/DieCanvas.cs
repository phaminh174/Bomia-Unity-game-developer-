using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieCanvas : MonoBehaviour
{
    public GameObject closedRoot, openRoot;
    public void Set()
    {
        closedRoot.SetActive(false);
        openRoot.SetActive(true);
    }
}
