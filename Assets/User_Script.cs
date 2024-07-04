using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class User_Script : MonoBehaviour
{
    public float speed;
    public float jump;

    private float move;

    public Rigidbody2D myRigidbody;
    // Start is called before the first frame update

    void Start()
    {
        gameObject.name = "Steve Rogers";
    }

    // Update is called once per frame
    void Update()
    {
        flip();

        move = Input.GetAxis("Horizontal");

        myRigidbody.velocity = new Vector2(speed = move, myRigidbody.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            myRigidbody.AddForce(new Vector2(myRigidbody.velocity.x, jump));
        }
    }

    void flip()
    {
        if (Keyboard.current.downArrowKey.wasPressedThisFrame)
        {
            transform.Rotate(0, 180, 0);
        }
    }
}