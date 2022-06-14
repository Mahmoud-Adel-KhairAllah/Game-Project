using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player_Controller : MonoBehaviour
{
    [SerializeField]
    float speedValue = 200;
    [SerializeField]
    float jumpValue = 2500;
    Transform tr;
    Rigidbody2D rb;
    Animator anmi;
    bool facingRight = true;
    bool isGrounded = false;

    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
        anmi=GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        // ********************* Jump ********

        bool isJump = CrossPlatformInputManager.GetButton("Jump");
        if (isJump && isGrounded)
        {
            isGrounded = false;
            rb.AddForce(new Vector2(0, jumpValue));
            anmi.SetBool("jump", true);

        }

    }
    private void FixedUpdate()
    {
        // ********************* Move *********

        float move = CrossPlatformInputManager.GetAxis("Horizontal");
        anmi.SetFloat("speed", Mathf.Abs(move));

        rb.velocity = new Vector2(speedValue * Time.deltaTime * move, rb.velocity.y); // Method -2

        // ********************* Flip *******

        // Method -1
        if (move > 0 && transform.localScale.x < 0)
        {
            Flip();
        }
        else if (move < 0 && transform.localScale.x > 0)
        {
            Flip();
        }
        if (transform.position.y <= -5.47)
        {
            Application.Quit(0);
            transform.position=(new Vector2(-11.57f, -1.56f)); 
            Debug.Log("Game over");
          
        }
         

    }
    void Flip()
    {
        Vector3 currentScale = transform.localScale;
        currentScale.x *= -1;
        transform.localScale = currentScale;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        string t=collision.collider.tag;


        isGrounded = true;
        anmi.SetBool("jump", false);

    }

}