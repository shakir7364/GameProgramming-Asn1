using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private Rigidbody2D rb2d;
    private float horizontal;
    private float verticle;
    private Vector2 movement;

    // Use this for initialization
    void Start ()
    {
        rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        if (Input.GetKey(KeyCode.A))
            transform.Translate(new Vector2(-.15f, 0));
        if (Input.GetKey(KeyCode.D))
            transform.Translate(new Vector2(.15f, 0));
        if (Input.GetKey(KeyCode.S))
            transform.Translate(new Vector2(0, -.15f));
        if (Input.GetKey(KeyCode.W))
            transform.Translate(new Vector2(0, .15f));
    }
}
