using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shield : MonoBehaviour
{
    public float speed;
    private Rigidbody2D body;

    // Update is called once per frame
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        body.velocity = transform.right * speed;
    }
}
