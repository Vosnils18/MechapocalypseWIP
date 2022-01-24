using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    
    public Transform firepoint;
    public GameObject bulletPrefab;
    public Camera cam;

    Vector2 mousePos;
    Vector2 firepointPosition;

    public float bulletForce = 20f;

    // Update is called once per frame
    void Update()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot() 
    {
        GameObject bullet = Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firepoint.up * bulletForce, ForceMode2D.Impulse);
    }

    private void FixedUpdate()
    {
        firepointPosition = new Vector2(firepoint.position.x, firepoint.position.y);
        Vector2 lookDir = mousePos - firepointPosition;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90;
        firepoint.rotation = Quaternion.Euler(0f, 0f, angle);
    }
}
