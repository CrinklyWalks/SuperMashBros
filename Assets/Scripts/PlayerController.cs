using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // public float jumpForce = 10f;
    public float walkSpeed = 10f;
    public float sprintSpeed = 20f;
    private bool facingRight = true;
    private Rigidbody2D rigi;
    private float moveH = 0f;
    public Animator anim;
    private bool push = false;
    private bool running = false;
    // public GameObject feet;
    private float time = 6.9f;
    private bool eeee;
    
    // Start is called before the first frame update
    void Start()
    {
        rigi = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        if(Input.GetKey("d"))
        {
            moveH = 1;
        }
        else if(Input.GetKey("a"))
        {
            moveH = -1;
        }
        else
        {
            moveH = 0;
            anim.SetBool("Walk", false);
            anim.SetBool("NotMoving", true);
        }
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            running = true;
        }
        if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            running = false;
        }

        if(moveH > 0 && !facingRight)
        {
            if(!push)
            {
            anim.SetBool("Walk", true);
            }
            Flip();
        }
        if(moveH < 0 && facingRight)
        {
            if(!push)
            {
                anim.SetBool("Walk", true);
            }
            Flip();
        }

        if(!running)
        {
            rigi.velocity = new Vector2(moveH * walkSpeed, rigi.velocity.y);
        }
        if(running)
        {
            rigi.velocity = new Vector2(moveH * sprintSpeed, rigi.velocity.y);
        }
        if(Input.GetKey("m"))
        {
            anim.SetBool("El buton", true);
            time = Time.deltaTime;
        }
    }
    void OnCollisionStay2D(Collision2D colision)
    {
        if(colision.gameObject.tag == "Pushing")
        {
            if(Input.GetKeyDown("e"))
            {
                push = true;
            }
            else if(Input.GetKeyUp("e"))
            {
                push = false;
            }
        }
        
    }
    void Flip()
    {
        facingRight = !facingRight;
        Vector2 theScale = transform.localScale;
        theScale.x = -1 * theScale.x;
        transform.localScale = theScale;
    }
}
