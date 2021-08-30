using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsometricMovement : MonoBehaviour
{

    private Rigidbody2D rb;
    private Animator animator;

    public float movementSpeed = 5f;
    Vector2 movement;


    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        rb.MovePosition(rb.position + movement * movementSpeed * Time.fixedDeltaTime);
    }
}
