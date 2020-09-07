using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruits : MonoBehaviour
{
    public string FruitsName;
    public LayerMask WhatisTouching;
    public Animator fruitAnim;

    private void Start()
    {
        fruitAnim.Play(FruitsName+"Anim");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            CircleCollider2D circlebody2d = gameObject.GetComponent<CircleCollider2D>();
            circlebody2d.enabled = false;
            fruitAnim.SetTrigger("Collected");
            Destroy(gameObject, 0.5f);
        }
    }
}
