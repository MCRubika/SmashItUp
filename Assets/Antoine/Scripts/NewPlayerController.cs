using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlayerController : MonoBehaviour
{
    private Rigidbody2D rb;

    public float speed;
    public float jumpSpeed;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        //Movement
        float directionX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(directionX * speed, rb.velocity.y);

        //Jump
        if (Input.GetButtonDown("ButtonA") || Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
        }
    }
}
