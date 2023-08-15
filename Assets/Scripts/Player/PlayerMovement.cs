using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    Animator playerAnimator;
    Rigidbody2D rb;

    float horizontal;
    float vertical;

    [SerializeField] float runSpeed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        playerAnimator = FindObjectOfType<Animator>();
    }

    void SetupInput()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    void SetupAnimation()
    {
        playerAnimator.SetFloat("Horizontal", horizontal);
        playerAnimator.SetFloat("Vertical", vertical);

        if (vertical != 0 || horizontal != 0)
        {
            playerAnimator.SetFloat("IdleHorizontal", horizontal);
            playerAnimator.SetFloat("IdleVertical", vertical);
        }
    }

    void Update()
    {
        SetupInput();
        SetupAnimation();
    }

    private void FixedUpdate()
    {
        Move();
    }

    public void Move()
    {
        Vector2 playerVelocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
        playerAnimator.SetFloat("Speed", playerVelocity.magnitude);
        rb.velocity = playerVelocity;
    }
}
