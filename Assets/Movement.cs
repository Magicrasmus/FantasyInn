using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        
        
            movement.x = Input.GetAxis("Horizontal");
            movement.y = Input.GetAxis("Vertical");


        

    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position += moveSpeed * Time.fixedDeltaTime * movement);
    }
}
