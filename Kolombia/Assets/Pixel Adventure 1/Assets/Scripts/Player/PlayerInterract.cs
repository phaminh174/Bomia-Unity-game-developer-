using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInterract : MonoBehaviour
{
    public PlayerMovement PlayerMovement;
    public Rigidbody2D Player;
    public Animator PlayerAnim;
    public TimeCount TimeCount;
    public LevelController EventController;

    private void Update()
    {
        if (TimeCount.LevelController.LevelTime <= 0) PlayerFail();
    }

    public void PlayerFail()
    {
        TimeCount.StopCountingTime();
        Player.AddForce(Vector2.left);
        PlayerAnim.Play("HurtAnim");
        CapsuleCollider2D capsule = gameObject.GetComponent<CapsuleCollider2D>();
        Destroy(gameObject, 1f);
        capsule.enabled = false;
        PlayerMovement.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("SpikeTrap"))
        {
            PlayerFail();
        } else
        if (collision.CompareTag("Fruit"))
        {
            EventController.FruitsSubtract();
        }
    }
}
