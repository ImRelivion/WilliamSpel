using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarController : MonoBehaviour
{
    [SerializeField]
    float jumpForce = 200;

    [SerializeField]

    float speed = 1f;

    [SerializeField]

    Transform groundChecker;

    [SerializeField]
    LayerMask groundLayer;

    Rigidbody2D rb;

    bool hasReleasedJump = true;
    bool isGrounded = false;

    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxisRaw("Horizontal");

        Vector2 movement = new Vector2(xMove, 0) * speed * Time.deltaTime;
        transform.Translate(movement); 

        isGrounded = Physics2D.OverlapCircle(groundChecker.position, 0.2f, groundLayer);


        if (Input.GetAxisRaw("Jump") > 0 && hasReleasedJump && isGrounded == true)
        {
            rb.AddForce(Vector2.up * jumpForce);
            hasReleasedJump = false;
        }
        else if (Input.GetAxisRaw("Jump") == 0)
        {
            hasReleasedJump = true;
        }
        
       
        
    }
}
