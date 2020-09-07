using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public PlayerMovement Player;
    public Animator PlayerAnim;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {
            //Player.isOnGround = true;
            //Player.isTouchingFront = false;
            //PlayerAnim.SetBool("Jump", false);
        }
    }


}
