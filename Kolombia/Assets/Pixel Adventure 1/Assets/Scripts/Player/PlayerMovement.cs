using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed;
    public float JumpForce;
    
    private bool isOnGround = true;
    private bool isTouchingFront = false;

    private bool wallSliding;
    public float wallSlidingSpeed;

    public LayerMask WhatisGround;
    public Transform frontCheck;
    public Transform groundCheck;
    public float checkRadius;

    private bool WallJumping;
    public float xWallForce;
    public float yWallForce;
    public float WallJumpTime;

    public int extraJumpValue;
    int extraJump;

    public Animator PlayerAnim;
    public TimeCount TimeCount;

    Rigidbody2D Player;
    Vector3 m_Velociy = Vector3.zero;
    bool isDoubleJump;
    bool isFacingRight = true;


    private void Start()
    {
       Player = gameObject.GetComponent<Rigidbody2D>();
       extraJump = extraJumpValue;
    }

    private void Update()
    {
        Jump();
        Movement();
    }

    public void WallJump()
    {
        isTouchingFront = Physics2D.OverlapCircle(frontCheck.position, checkRadius, WhatisGround);

        if (isTouchingFront && !isOnGround ) 
        {
            wallSliding = true;
        }
        else
        {
            wallSliding = false;
        }

        if (wallSliding)
        {
            Player.velocity = new Vector2(Player.velocity.x, -wallSlidingSpeed);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && wallSliding)
        {
            WallJumping = true;
            Invoke("SetWallJumpingToFalse", WallJumpTime);
        }
        if (WallJumping)
        {
            if (isTouchingFront)
            {
                Player.velocity = new Vector2(xWallForce * -transform.localScale.x, yWallForce);
            }
        }
        PlayerAnim.SetBool("OnWall", wallSliding);
    }
    public void SetWallJumpingToFalse()
    {
        WallJumping = false;
    }
    public void Movement()
    {
        //input
        float input = Input.GetAxis("Horizontal");
        if (input != 0 || Input.GetAxis("Vertical") != 0) startCounting();

        if (!wallSliding && !isTouchingFront) 
            Player.velocity = new Vector2(Speed * input, Player.velocity.y);
        else Player.velocity = new Vector2(0, Player.velocity.y);

        //kiem tra mat dat
        isOnGround = Physics2D.OverlapCircle(groundCheck.position, checkRadius, WhatisGround);
        //isOnGround = Physics2D.OverlapBox(groundCheck.position, new Vector2(0.3f, 0), WhatisGround);

        //kiem tra cham tuong
        isTouchingFront = Physics2D.OverlapCircle(frontCheck.position, checkRadius, WhatisGround);

        //chuyen huong nhan vat
        if (!isFacingRight && input > 0)
        {
            Flip();
        }
        else if (isFacingRight && input < 0)
        {
            Flip();
        }
        if (Player.velocity.y < 0 || wallSliding) WallJump();

        //thuc hien animation
        if (isOnGround && input != 0) PlayerAnim.SetBool("Run", true);
        else PlayerAnim.SetBool("Run", false);
        PlayerAnim.SetBool("Jump", !isOnGround);
        PlayerAnim.SetFloat("VelocityFall", Player.velocity.y);

    }

    void Flip()
    {
        isFacingRight = !isFacingRight;
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }

    void Jump()
    {
        if (isOnGround || wallSliding)
        {
            extraJump = extraJumpValue;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && extraJump > 0)
        {
            Player.velocity = Vector2.up * JumpForce;
            extraJump--;
            if (extraJump == 0) PlayerAnim.SetTrigger("Double Jump");
            //PlayerAnim.SetBool("Jump", true);
            
        } /*else if (Input.GetKeyDown(KeyCode.UpArrow) && extraJump == 0 && isOnGround)
        {
            Player.velocity = Vector2.up * JumpForce;
            
            //PlayerAnim.SetBool("Jump", true);
        } //else if (Input.GetKeyDown(KeyCode.UpArrow) && extraJump == 0 && isOnGround)*/
    }
    
    void startCounting()
    {
        if (!TimeCount.startCounting) TimeCount.startCounting = true;
    }

   
}
