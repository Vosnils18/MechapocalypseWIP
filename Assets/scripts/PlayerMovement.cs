using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform firepoint;
    public float moveSpeed = 7f;
    public Rigidbody2D rb;
    public Camera cam;
    Vector2 movement;
    //Vector2 mousePos;
    Vector2 mouseScreen;
    //Vector2 firepointPosition;

    public SpriteRenderer spriteRenderer;

    public bool isFacingRight;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mouseScreen = cam.ScreenToViewportPoint(Input.mousePosition);
        //mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    private void FixedUpdate()
    {
        //firepointPosition = new Vector2(firepoint.position.x, firepoint.position.y);
        //Vector2 lookDir = mousePos - firepointPosition;
        //float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90;
        //firepoint.rotation = Quaternion.Euler(0f, 0f, angle);


        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        if (mouseScreen.x >= 0.5)
        {
            isFacingRight = true;
        } else
        {
            isFacingRight = false;
        }

        if(isFacingRight == false)
        {
            spriteRenderer.flipX = true;
        } else
        {
            spriteRenderer.flipX = false;
        }
    }
}
