using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigidBody;
    [SerializeField] private Transform GFX;
    [SerializeField] private float moveSpeed = 10f;
    [SerializeField] private float jumpForce = 10f;
    
    [SerializeField] private bool isMoving = false;
    [SerializeField] private bool isJumping = false;
    [SerializeField] private bool isGrounded = false;
    
    [SerializeField] private int jumpCounter = 0;
    [SerializeField] private int totalJumps = 1;
    [SerializeField] private LayerMask groundLayer;
    //[SerializeField] private Transform feetPos;
    public bool canMoveVertical = false;
    public bool canMoveHorizontal = false;
    public bool canJump = false;

    [Header("Projectile Objects")]
    // projectile vars
    public ProjectileBehavior ProjectilePrefab;
    public Transform LaunchOffset;
    

    public void moveCharacterRight()
    {
        if (canMoveHorizontal)
        {
            rigidBody.velocity = new Vector2(moveSpeed, rigidBody.velocity.y);
            isMoving = true;
        }
    }

    public void moveCharacterLeft()
    {
        if (canMoveHorizontal)
        {
            rigidBody.velocity = new Vector2(-moveSpeed, rigidBody.velocity.y);
            isMoving = true;
        }
    }

    public void moveCharacterDown()
    {
        if (canMoveVertical)
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, -moveSpeed);
            isMoving = true;
        }
    }

    public void moveCharacterUp()
    {
        if (canMoveVertical)
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, moveSpeed);
            isMoving = true;
        }
    }

    public void resetSpeedHorizontal()
    {
        if (canMoveHorizontal)
        {
            isMoving = false;
            rigidBody.velocity = new Vector2(0f, rigidBody.velocity.y);
            //rigidBody.velocity = new Vector2(-1, rigidBody.velocity.y);
        }
    }

    public void resetSpeedVertical()
    {
        if (canMoveVertical)
        {
            isMoving = false;
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, 0f);
        }
    }

    public void characterJump()
    {
        if(canJump && (isGrounded || jumpCounter < totalJumps))
        {
            isJumping = true;
            jumpCounter++;
            rigidBody.velocity = Vector2.up * jumpForce;
        }
    }

    public void checkGrounded()
    {
        //isGrounded = Physics2D.OverlapCircle(feetPos.position, groundDistance, groundLayer);
        isGrounded = rigidBody.IsTouchingLayers(groundLayer);
        isJumping = !isGrounded;
        //if (!isJumping) jumpCounter = 0;
    }

    public void resetJump()
    {
        if(canJump && isGrounded)
        {
            jumpCounter = 0;
        }
    }

    // projectile updates
    private void Update()
    {
        // spawning projectile
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(ProjectilePrefab, LaunchOffset.position, transform.rotation);
        }
    }
}
