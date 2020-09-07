using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedFruits : MonoBehaviour
{
    public LayerMask WhatisTouching;
    public Animator fruitsAnim;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            fruitsAnim.SetTrigger("Collected");
            Destroy(gameObject, 0.5f);
        }
    }
}
