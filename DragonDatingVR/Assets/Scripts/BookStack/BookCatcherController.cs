using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookCatcherController : MonoBehaviour {

    public float speed;

    public Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        float moveHorizontal = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(moveHorizontal, 0f);

        rb2d.AddForce(movement * speed);
	}
}
