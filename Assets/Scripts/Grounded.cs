using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Grounded : MonoBehaviour
{
    private int doubleJump = 2;
    public Rigidbody2D Player;
    public float jumpForce = 20f;
    Player1 playerController;
    private bool jumping;

    void Awake()
    {
        Player = GetComponent<Rigidbody2D>();
        playerController = new Player1();

        playerController.PlayerControl.Jump.performed += ctx => Up(true);
        playerController.PlayerControl.Jump.canceled += ctx => Up(false);

    }

    bool Up(bool state)
    {
        jumping = state;
        return jumping;
    }

    void OnCollisionStay2D(Collision2D coid)
    {
        if((coid.gameObject.tag == "ground" || doubleJump <=0) && jumping )
        {
            doubleJump -= 1;
            Debug.Log("You've jumped");
        }
    }
}
