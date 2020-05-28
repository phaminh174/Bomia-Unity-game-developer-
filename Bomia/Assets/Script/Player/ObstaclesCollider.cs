using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesCollider : MonoBehaviour
{
    public GameObject closedRoot, openRoot;
    public void Set()
    {
        closedRoot.SetActive(false);
        openRoot.SetActive(true);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Obstacles"))
        {
            Set();
            Destroy(gameObject);
        }
    }
}
