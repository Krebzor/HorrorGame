using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator animator;
    private SpriteRenderer mySpriteRenderer;

    
    public float movementSpeed = 2f;
    public float slowMovement = 1f;
    

    Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        animator = this.GetComponent<Animator>();
        mySpriteRenderer = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");

        rb.MovePosition(rb.position + movement * movementSpeed * Time.fixedDeltaTime);
        if (movement.x < 0)
        {
            mySpriteRenderer.flipX = true;
        } else if (movement.x > 0)
        {
            mySpriteRenderer.flipX = false;
        }
        if (movement.x != 0)
        {
            animator.SetBool("isWalking", true);
        } else
        {
            animator.SetBool("isWalking", false);
        }

        SlowWalk();

    }

    public void SlowWalk()
    {
        if (Input.GetButton("Jump"))
        {
            movementSpeed = slowMovement;
        } else
        {
            movementSpeed = 2f;
        }
    }
}
