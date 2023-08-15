using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    PlayerAnimations playerAnimations;
    Rigidbody2D rb;

    float horizontal;
    float vertical;

    [SerializeField] float runSpeed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        playerAnimations = GetComponent<PlayerAnimations>();
    }

    void SetupInput()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    void SetupAnimation()
    {
        playerAnimations.SetFloatForAllAnimators("Horizontal", horizontal);
        playerAnimations.SetFloatForAllAnimators("Vertical", vertical);

        if (vertical != 0 || horizontal != 0)
        {
            playerAnimations.SetFloatForAllAnimators("IdleHorizontal", horizontal);
            playerAnimations.SetFloatForAllAnimators("IdleVertical", vertical);
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
        playerAnimations.SetFloatForAllAnimators("Speed", playerVelocity.magnitude);
        rb.velocity = playerVelocity;
    }
}
