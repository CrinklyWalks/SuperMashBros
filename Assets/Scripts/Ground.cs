using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public Collider2D feet;
    public Rigidbody2D player;
    public float jumpForce = 10f;
    private bool ground = false;
    // Start is called before the first frame update
    void Start()
    {
        feet = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.Space) && ground)
        {
            player.velocity = new Vector2(player.velocity.x, player.velocity.y + jumpForce);
        }
    }
    void OnCollisionStay2D()
    {
        ground = true;
    }
    void OnCollisionExit2D()
    {
        ground = false;
    }   
}